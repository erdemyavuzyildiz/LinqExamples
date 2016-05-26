using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var studentList = new List<Student>();

			studentList.Add(new Student {id = 1, classroom = 1});
			studentList.Add(new Student {id = 2, classroom = 1});
			studentList.Add(new Student {id = 3, classroom = 1});
			studentList.Add(new Student {id = 1, classroom = 2});
			studentList.Add(new Student {id = 2, classroom = 2});
			studentList.Add(new Student {id = 3, classroom = 2});

			var studentList2 = new List<Student>();

			studentList2.Add(new Student {id = 1, classroom = 1});
			studentList2.Add(new Student {id = 2, classroom = 1});
			studentList2.Add(new Student {id = 3, classroom = 1});
			studentList2.Add(new Student {id = 1, classroom = 2});
			studentList2.Add(new Student {id = 2, classroom = 2});
			studentList2.Add(new Student {id = 3, classroom = 2});
			studentList2.Add(new Student {id = 4, classroom = 2});

			var showExtra = studentList2.Where(x => studentList.All(y => y.id != x.id)).ToList();
			var result1 = studentList.GroupBy(x => new {x.id}).Select(x => new {x.Key.id, x.Key}).ToList();
		}
	}

	public class Student
	{
		public string name { get; set; }
		public int id { get; set; }
		public int classroom { get; set; }
	}
}