﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	abstract class Person {
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public bool IsEmployee { get; set; }

		public Person(string Name, string Phone, string Email, bool IsEmployee) {
			this.Name = Name;
			this.Phone = Phone;
			this.Email = Email;
			this.IsEmployee = IsEmployee;
		}

		public Person() {

		}
	}
}
