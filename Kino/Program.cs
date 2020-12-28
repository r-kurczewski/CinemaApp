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
		public static MovieContext movies;
		public static GenreContext genres;
		public static MovieGenreContext movieGenres;

		[STAThread]
		static void Main()
		{
			connection = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString); 
			connection.Open();
			movies = new MovieContext(connection, false);
			genres = new GenreContext(connection, false);
			movieGenres = new MovieGenreContext(connection, false);

			//foreach (var movGen in movieGenres.Context)
			//	Console.WriteLine(movGen);


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			connection.Close();
		}

	}
}
