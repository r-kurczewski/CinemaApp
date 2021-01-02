using MySql.Data.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class DepartmentContext : DbContext
	{
		public DbSet<Department> Context { get; set; }

		public DepartmentContext() : base() { }

		public DepartmentContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Department>().MapToStoredProcedures();
		}
	}
}