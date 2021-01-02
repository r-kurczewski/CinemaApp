﻿using Kino.Database;
using Kino.Database.Model;
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

		public static CinemaContext dbContext;

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
			dbContext = new CinemaContext(connection);

			var query = dbContext.Clients.ToList();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			connection.Close();
		}

	}
}
