using MySql.Data.Entity;
using System;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class CinemaContext : DbContext
	{
		public DbSet<CinemaRoom> Context { get; set; }

		public CinemaContext() : base() { }

		public CinemaContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<CinemaRoom>().MapToStoredProcedures();
		}
	}
}