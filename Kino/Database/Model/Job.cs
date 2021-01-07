namespace Kino.Database.Model
{
	public class Job
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public decimal Min_Salary { get; set; }

		public decimal? Max_Salary { get; set; }

		public override string ToString()
		{
			return $"{Name}";
		}
	}
}