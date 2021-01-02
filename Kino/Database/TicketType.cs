using System.ComponentModel.DataAnnotations.Schema;

namespace Kino.Database
{
	[Table("ticket_types")]
	public class TicketType
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public decimal Price { get; set; }

		public decimal Price3D { get; set; }

		public override string ToString()
		{
			return $"{Name}";
		}
	}
}