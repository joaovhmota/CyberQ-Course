using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSchool.Classes;

namespace ProjetoSchool.Interfaces
{
	internal interface ISchoolSystem // 学校の企画
	{
		public string              Name          { get; set; } // 学校の名
		public List<SchoolClasses> SchoolClasses { get; set; } // 授業
		public List<Student>       Students      { get; set; } // 学生
		public List<Subject>       Subjects      { get; set; } // 科目
		public List<Teacher>       Teachers      { get; set; } // 先生
		public List<Worker>        Workers       { get; set; } // 従業員
		public float               Avarage       { get; set; } // 平均
		public float               MinAvarage    { get; set; } // 最小限平均
	}
}
