using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ClientSideApp
{
	public static class AlgoritmeJeton
	{
		public static string getKey()
        {
            DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long elapsedTicks = (DateTime.UtcNow - UnixEpoch).Ticks;
            long elapsedMinutes = elapsedTicks / TimeSpan.TicksPerMinute;
            string key = elapsedMinutes.ToString();
            Console.WriteLine(key); 
            string hash = "";

            foreach (char c in key)
            {
                hash += (int)c;
            }

            Console.WriteLine(hash);
            BigInteger hashNumber = BigInteger.Parse(hash);
            hash = (hashNumber * (hashNumber % 13)).ToString();
            Console.WriteLine(hash);
            char[] hashArray = hash.ToCharArray();
            Array.Reverse(hashArray);
            hash = new string(hashArray);
            Console.WriteLine(hash);
            return hash.Substring(0, 8);
        }

        private static string ReverseString(string str)
		{
			char[] strArray = str.ToCharArray();
            Array.Reverse(strArray);
            string reversedStr = new string(strArray);
            return reversedStr;
		}
	}
}
