using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kino.Database.Model
{
	public class Ticket
	{
		[Key, Column(Order = 0)]
		public int Seance_ID { get; set; }

		[Key, Column(Order = 1)]
		public int Seat_Number { get; set; }

		public int Client_ID { get; set; }

		public int Ticket_Type_ID { get; set; }

		public bool Payment_Status { get; set; }

		public override string ToString()
		{
			return $"{Seance_ID} {Seat_Number} {Client_ID}";
		}
	}
}