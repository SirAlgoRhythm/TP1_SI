using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideApp
{
	internal class AlgoritmeJeton
	{
		static string GenererJeton()
		{
			string key = Math.Round((double)(DateTime.Now.Ticks) / 60 / 1000).ToString();
			string hash = "";
			ulong numberHash = 0;

			for (int i = 0; i < 5; i++)
			{
				ulong temp = (ulong)key[i];
				if (i < 1) { numberHash = temp; }
				else { numberHash = ulong.Parse(numberHash.ToString() + temp.ToString()); }
			}

			hash = (numberHash * (numberHash % 13)).ToString();

			hash.ToCharArray().Reverse();
			return hash.Substring(0, 8);
		}
	}
}
