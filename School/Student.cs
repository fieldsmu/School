using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Student : Person {

		private static int NextId = 1;

		public bool IsVeteran { get; set; } = false;
		public int StudentId { get; set; }
		public double GPA { get; set; }

		public Student(string Name, string Phone, string Email, bool IsEmployee, bool IsVeteran, double GPA)
			: base(Name, Phone, Email, IsEmployee) {
			this.IsVeteran = IsVeteran;
			this.GPA = GPA;
			this.StudentId = NextId++;
		}
		public Student() {

		}
	}
}
