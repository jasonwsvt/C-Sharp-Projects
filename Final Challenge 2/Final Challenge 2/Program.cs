using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Challenge_2
{
	class Program
	{
		static void Main()
		{
			using (var ctx = new SchoolContext())
			{
				var s = new Student() { StudentName = "Jason" };
				ctx.Students.Add(s);
				ctx.SaveChanges();
				Console.WriteLine("Number of students: " + ctx.Students.Count());
			}
		}
	}

	public class Student
	{
		public int StudentId { get; set; }
		public string StudentName { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public int ClassYear { get; set; }
	}

	public class SchoolContext: DbContext
	{
		public SchoolContext() : base()
		{

		}

		public DbSet<Student> Students { get; set; }
	}
}
