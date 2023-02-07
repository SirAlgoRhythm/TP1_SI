var key = new Date().valueOf() / 60 / 1000;
//millis unix en minutes

function simpleHash(key) {
  let hash = 0;

  for (let i = 0; i < key.length; i++) {
    hash += key.charCodeAt(i);
  }

  hash = hash * (hash % 13);
  return btoa(hash).substring(0, 8);
}

