using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class Util // 使えるコマンド
	{
		Random rnd = new Random();
		public Util() { }

		public string UniqueID()
		{
			return ( 
				(DateTime.Now.Ticks * rnd.Next(50)).ToString().Substring(0, 10)
			);
		}
	}
}
