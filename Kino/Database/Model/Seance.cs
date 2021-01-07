using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kino.Database.Model
{
	public class Seance
	{
		public int ID { get; set; }

		public int Cinema_Room_ID { get; set; }

		public int Movie_ID { get; set; }

		public DateTime Date { get; set; }

		[Column("3D")]
		public bool Is3D { get; set; }

		public string Localisation { get; set; }

		public LocalisationType GetLocalisation() => (LocalisationType)Enum.Parse(typeof(LocalisationType), Localisation, true);

		public override string ToString()
		{
			return $"{Date.ToString("dddd, dd MMMM yyyy")}";
		}

		public enum LocalisationType
		{
			[Description("Brak")] Brak,
			[Description("Lector")] Lektor,
			[Description("Dubbing")] Dubbing,
			[Description("Napisy")] Napisy
		}
	}
}