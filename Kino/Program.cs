using Kino.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
	static class Program
	{
		public static MySqlConnection connection;

		public static CinemaRoomContext cinemaRooms;
		public static ClientContext clients;
		public static DepartmentContext departments;
		public static EmployeeContext employees;
		public static GenreContext genres;
		public static JobContext jobs;
		public static MovieContext movies;
		public static MovieGenreContext movieGenres;
		public static SeanceContext seances;
		public static TicketContext tickets;
		public static TicketTypeContext ticketTypes;

		[STAThread]
		static void Main()
		{
			try
			{
				connection = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString);
				connection.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			cinemaRooms = new CinemaRoomContext(connection, false);
			clients = new ClientContext(connection, false);
			departments = new DepartmentContext(connection, false);
			employees = new EmployeeContext(connection, false);
			genres = new GenreContext(connection, false);
			jobs = new JobContext(connection, false);
			movies = new MovieContext(connection, false);
			movieGenres = new MovieGenreContext(connection, false);
			seances = new SeanceContext(connection, false);
			tickets = new TicketContext(connection, false);
			ticketTypes = new TicketTypeContext(connection, false);

			var query = clients.Context.ToList();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			connection.Close();
		}

	}
}
