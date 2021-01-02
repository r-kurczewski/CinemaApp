namespace Kino.Database
{
	public class Client
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Phone { get; set; }

		public string Email { get; set; }

		public override string ToString()
		{
			return $"{Name} {Surname}";
		}
	}
}