using System;

namespace Kino.Database
{
	public class Employee
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public int Department_Id { get; set; }

		public int Job_Id { get; set; }

		public decimal Salary { get; set; }

		public DateTime Job_Start { get; set; }

		public DateTime Job_End { get; set; }

		public string Phone { get; set; }

		public string Email { get; set; }

		public override string ToString()
		{
			return $"{Name} {Surname}";
		}
	}
}