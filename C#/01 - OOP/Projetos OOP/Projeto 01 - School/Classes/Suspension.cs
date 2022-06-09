using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class Suspension　// 休学
	{
		public string   ID        { get; set; } // ID
		public string   Reason    { get; set; } // 理由
		public DateTime CreatedAt { get; set; } // 日付

		public Suspension(string Reason)
		{
			this.ID        = new Util().UniqueID();
			this.Reason    = Reason;
			this.CreatedAt = DateTime.Now;
		}
	}
}
