using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideApp
{
	public static class AlgoritmeJeton
	{
		public static string GenererJeton()
		{
            DateTime origine = new DateTime(1970,1,1);
            TimeSpan span = DateTime.Now - origine; 
            Double nbSecondes = (Double) span.TotalMilliseconds;
			string key = Math.Round(nbSecondes / 60 / 1000).ToString();
			string hash = "";
			ulong numberHash = 0;

			for (int i = 0; i < key.Length; i++)
			{
				ulong temp = (ulong)key[i];
				if (i < 1) { numberHash = temp; }
				else { numberHash = ulong.Parse(numberHash.ToString() + temp.ToString()); }
			}

			hash = (numberHash * (numberHash % 13)).ToString();

			hash = ReverseString(hash);
			return hash.Substring(0,8);
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
