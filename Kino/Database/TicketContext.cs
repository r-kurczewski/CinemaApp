using MySql.Data.Entity;
using System;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class TicketContext : DbContext
	{
		public DbSet<Ticket> Context { get; set; }

		public TicketContext() : base() { }

		public TicketContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Ticket>().MapToStoredProcedures();
		}
	}
}