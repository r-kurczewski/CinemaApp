using MySql.Data.Entity;
using System;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class MovieContext : DbContext
	{
		public DbSet<Movie> Context { get; set; }

		public MovieContext() : base()
		{

		}

		public MovieContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection)
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Movie>().MapToStoredProcedures();
		}
	}

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