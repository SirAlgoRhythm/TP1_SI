const http = require("http");
const fs = require("fs");
const child_process = require("child_process");

var fail = 0;

function getKey() {
  let key = Math.round(new Date().valueOf() / 60 / 1000).toString();
  let hash = "";

  for (let i = 0; i < key.length; i++) {
    hash += key.charCodeAt(i);
  }

  hash = hash * (hash % 13);
  hash = hash.toString().split("").reverse().join("");
  return hash.toString().substring(0, 8);
}

function getOldKey() {
  let key = Math.round(new Date().valueOf() / 60 / 1000 - 1).toString();
  let hash = "";

  for (let i = 0; i < key.length; i++) {
    hash += key.charCodeAt(i);
  }

  hash = hash * (hash % 13);
  hash = hash.toString().split("").reverse().join("");
  return hash.toString().substring(0, 8);
}

const server = http.createServer((req, res) => {
  if (req.url === "/api/keys" && req.method === "GET") {
    res.writeHead(200, { "Content-Type": "application/json" });
    res.end(JSON.stringify({ key: getKey(), oldKey: getOldKey() }));
    return;
  }

  if (req.url === "/api/data" && req.method === "POST") {
    let body = "";
    req.on("data", (chunk) => {
      body += chunk.toString();
    });
    req.on("end", () => {
      const inputValue = JSON.parse(body).inputValue;
      if (getKey() == inputValue) {
        res.writeHead(200, { "Content-Type": "application/json" });
        res.end(JSON.stringify({ message: "Accès confirmé!", color: "green" }));
      } else {
        fail += 1;
        if (fail >= 5) {
          res.writeHead(400, { "Content-Type": "application/json" });
          res.end(JSON.stringify({ message: "Serveur fermé!", color: "red" }));
          server.close();
          process.exit();
        } else {
          res.writeHead(200, { "Content-Type": "application/json" });
          res.end(JSON.stringify({ message: "Accès refusé!", color: "red" }));
        }
      }
    });
    return;
  }

  fs.readFile("./index.html", "utf8", (err, content) => {
    if (err) {
      console.error("Could not read file");
      res.end();
      return;
    }
    res.writeHead(200, { "Content-Type": "text/html; charset=UTF-8" });
    res.end(content);
  });
});

server.listen(3000, () => {
  console.log("Server listening on http://localhost:3000");
  child_process.exec("start http://localhost:3000");
});
