using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Sales : Employee {

		public decimal TotalSales { get; set; }
		public string Region { get; set; }
		public decimal Quota { get; set; }

		public Sales(string Name, string Phone, string Email, decimal Salary, string JobTitle, string Region, decimal Quota)
			: base(Name, Phone, Email, Salary, JobTitle) {
			this.Region = Region;
			this.Quota = Quota;
			TotalSales = 0;
		}

		public Sales() {

		}
	}
}
