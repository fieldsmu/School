using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Program {
		static void Main(string[] args) {

			Student Marcus = new Student("Marcus", "513-444-4444", "johndoe@gmail.com", false, false, 4.0);
			Instructor Greg = new Instructor("Greg", "513-444-4444", "johndoe@gmail.com", 60000, "Boot Camp Instructor", "CSharp");
			Sales Dave = new Sales("Dave", "513-444-4444", "johndoe@gmail.com", 50000, "Sales Associate", "Greater Cincinnati", 50000.00M) {
				TotalSales = 23000
			};
			Sales Jeff = new Sales("Jeff", "513-444-4444", "johndoe@gmail.com", 50000, "Sales Associate", "Greater Cincinnati", 50000.00M) {
				TotalSales = 37000
			};
			Operations Larry = new Operations("Larry", "513-444-4444", "johndoe@gmail.com", 40000, "Operations Associate");

			List<Person> People = new List<Person> {
				Marcus,
				Greg,
				Dave,
				Larry
			};

			decimal totalSales = 0;
			foreach (Person Person in People) {
				if (Person is Sales Sales) {
					totalSales += Sales.TotalSales;
				}
			}
			Console.WriteLine(totalSales);

		}
	}
}
