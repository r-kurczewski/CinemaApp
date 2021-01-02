using MySql.Data.Entity;
using System;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class TicketTypeContext : DbContext
	{
		public DbSet<TicketType> Context { get; set; }

		public TicketTypeContext() : base() { }

		public TicketTypeContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<TicketType>().MapToStoredProcedures();
		}
	}
}