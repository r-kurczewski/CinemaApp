using MySql.Data.Entity;
using System;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class GenreContext : DbContext
	{
		public DbSet<Genre> Context { get; set; }

		public GenreContext() : base() { }

		public GenreContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Genre>().MapToStoredProcedures();
		}
	}

	public class Genre
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}