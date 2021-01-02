using System.ComponentModel.DataAnnotations.Schema;

namespace Kino.Database
{
	[Table("movie_genres")]
	public class MovieGenres
	{
		public int ID { get; set; }

		public int Movie_ID { get; set; }

		public int Genre_ID { get; set; }

		public override string ToString()
		{
			return $"{Movie_ID}->{Genre_ID}";
		}
	}
}