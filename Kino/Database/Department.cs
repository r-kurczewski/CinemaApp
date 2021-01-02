namespace Kino.Database
{
	public class Department
	{
		public int ID { get; set; }

		public string City { get; set; }

		public string Name { get; set; }

		public override string ToString()
		{
			return $"{Name}";
		}
	}
}