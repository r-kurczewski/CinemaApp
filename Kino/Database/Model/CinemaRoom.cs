using System.ComponentModel.DataAnnotations.Schema;

namespace Kino.Database.Model
{
	[Table("cinema_rooms")]
	public class CinemaRoom
	{
		public int ID { get; set; }

		public int Department_ID { get; set; }

		public int Room_Number { get; set; }

		public int Total_Seats { get; set; }

		public override string ToString()
		{
			return $"{Room_Number}";
		}
	}
}