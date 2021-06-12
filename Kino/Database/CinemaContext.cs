using Kino.Database.Model;
using MySql.Data.Entity;
using System.Data.Common;
using System.Data.Entity;

namespace Kino.Database
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class CinemaContext : DbContext
	{
		public DbSet<CinemaRoom> CinemaRooms { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Job> Jobs { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<MovieGenre> MovieGenres { get; set; }
		public DbSet<Seance> Seances { get; set; }
		public DbSet<Ticket> Tickets { get; set; }
		public DbSet<TicketType> TicketTypes { get; set; }

		public CinemaContext() : base() { }

		public CinemaContext(DbConnection existingConnection, bool contextOwnsConnection = false)
		  : base(existingConnection, contextOwnsConnection) { }
	}
}