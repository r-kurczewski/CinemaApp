using MySql.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class EmployeeContext : DbContext
	{
		public DbSet<Employee> Context { get; set; }

		public EmployeeContext() : base() { }

		public EmployeeContext(DbConnection existingConnection, bool contextOwnsConnection)
		  : base(existingConnection, contextOwnsConnection) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Employee>().MapToStoredProcedures();
		}
	}
}