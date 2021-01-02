using MySql.Data.Entity;
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
}