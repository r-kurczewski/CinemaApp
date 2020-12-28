using MySql.Data.Entity;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class MovieGenreContext : DbContext
	{
		public DbSet<Movie_Genres> Context { get; set; }

		public MovieGenreContext() : base() { }

		public MovieGenreContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Movie_Genres>().MapToStoredProcedures();
		}
	}

	public class Movie_Genres
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