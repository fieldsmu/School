using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Instructor : Employee {

		public string Subject { get; set; }

		public Instructor(string Name, string Phone, string Email, decimal Salary, string JobTitle, string Subject)
			: base(Name, Phone, Email, Salary, JobTitle){
			this.Subject = Subject;
		}

		public Instructor() {

		}

	}
}
