using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	abstract class Employee : Person {

		private static int NextId = 1;

		public int EmployeeId { get; set; }
		public decimal Salary { get; private set; }
		public string JobTitle { get; set; }

		public void SetSalary(decimal NewSalary) {
			if (NewSalary <= 0) {
				throw new ApplicationException("Salary must be positive and non-zero");
			}
			Salary = NewSalary;
		}

		public Employee(string Name, string Phone, string Email, decimal Salary, string JobTitle)
			: base(Name, Phone, Email, true){
			SetSalary(Salary);
			this.JobTitle = JobTitle;
		}

		public Employee() {

		}
	}
}
