using System;

namespace Kino.Database.Model
{
	public class Movie
	{
		public int ID { get; set; }

		public string Title { get; set; }

		public decimal Rating { get; set; }

		public TimeSpan Length { get; set; }

		public DateTime Premiere { get; set; }

		public override string ToString()
		{
			return Title;
			//return $"{ID}, {Title}, {Rating}, {Length.ToString("h'godz. 'mm'min'")}, {Premiere.ToString("dd.MM.yyyy")}";
		}
	}
}