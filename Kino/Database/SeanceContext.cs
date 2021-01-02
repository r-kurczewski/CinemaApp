using MySql.Data.Entity;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class SeanceContext : DbContext
	{
		public DbSet<Seance> Context { get; set; }

		public SeanceContext() : base() { }

		public SeanceContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Seance>().MapToStoredProcedures();
		}
	}
}