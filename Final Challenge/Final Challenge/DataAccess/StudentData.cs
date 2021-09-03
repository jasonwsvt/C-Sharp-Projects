using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Challenge.DataAccess
{
	public class Student : DbContext
	{
		public Student StudentContext(): base()
		{
			Student s = new();

			return s;
		}

		public DbSet<Student> Students { get; set; }

	}
}
