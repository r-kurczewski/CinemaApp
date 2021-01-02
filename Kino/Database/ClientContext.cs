using MySql.Data.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class ClientContext : DbContext
	{
		public DbSet<Client> Context { get; set; }
		public DbSet<Genre> Genres { get; }

		public ClientContext() : base() { }

		public ClientContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection) { }

	}
}