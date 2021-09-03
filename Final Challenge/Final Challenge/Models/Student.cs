using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Challenge.Models
{
	public class Student
	{
		public int StudentId { get; set; }
		public string StudentName { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public int ClassYear { get; set; }
	}
}
