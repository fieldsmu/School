using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Operations : Employee {

		public Operations(string Name, string Phone, string Email, decimal Salary, string JobTitle)
			: base(Name, Phone, Email, Salary, JobTitle) {
		}

		public Operations() {

		}
	}
}
