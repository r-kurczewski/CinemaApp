using MySql.Data.Entity;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class MovieGenreContext : DbContext
	{
		public DbSet<MovieGenres> Context { get; set; }

		public MovieGenreContext() : base() { }

		public MovieGenreContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<MovieGenres>().MapToStoredProcedures();
		}
	}
}