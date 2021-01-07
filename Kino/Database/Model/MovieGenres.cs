using System.ComponentModel.DataAnnotations.Schema;

namespace Kino.Database.Model
{
	[Table("movie_genres")]
	public class MovieGenre
	{
		public int ID { get; set; }

		public int Movie_ID { get; set; }

		public int Genre_ID { get; set; }

		public override string ToString()
		{
			return $"{Movie_ID}--{Genre_ID}";
		}
	}
}