using Kino.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
	public partial class MainForm : Form
	{
		public static Movie selectedMovie;

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//movieList.DataSource = Program.movies.Context.ToList();
			var defaultGenre = new Genre()
			{
				ID = -1,
				Name = "Dowolny"
			};
			List<Genre> genres = new List<Genre>() { defaultGenre };
			genres.AddRange(Program.genres.Context.ToList());
			GenreSelect.DataSource = genres;

			//MySqlTransaction transaction = Program.connection.BeginTransaction();

			//try
			//{
			//	// DbConnection that is already opened
			//	using (var movies = Program.movies)
			//	{
			//		foreach (var movie in movies.Movies)
			//			Console.WriteLine(movie.Title);

			//		movies.Database.UseTransaction(transaction);
			//		movies.SaveChanges();

			//		transaction.Commit();
			//	}
			//}
			//catch
			//{
			//	transaction.Rollback();
			//	throw;
			//}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Search_Click(object sender, EventArgs e)
		{
			string title = TitleBox.Text;
			string genre = GenreSelect.Text;
			int? genreID = Program.genres.Context.FirstOrDefault(x => x.Name == genre)?.ID;
			decimal? ratingMin = RatingMin.Text.ToNullableDecimal();
			decimal? ratingMax = RatingMax.Text.ToNullableDecimal();
			TimeSpan? lengthMin = LengthMin.Text.ToNullableTimeSpan();
			TimeSpan? lengthMax = LengthMax.Text.ToNullableTimeSpan();

			List<MySqlParameter> parameters = new List<MySqlParameter>();
			var sql = @"SELECT DISTINCT movies.* FROM `movies` JOIN movie_genres ON movies.id = movie_id JOIN genres on genres.id = genre_id";
			List<string> conditions = new List<string>();
			if (title != string.Empty)
			{
				conditions.Add("title = @title");
				parameters.Add(new MySqlParameter("@title", title));
			}
			if (ratingMin.HasValue)
			{
				conditions.Add("rating >= @ratingMin");
				parameters.Add(new MySqlParameter("@ratingMin", ratingMin.Value));
			}
			if (ratingMax.HasValue)
			{
				conditions.Add("rating <= @ratingMax");
				parameters.Add(new MySqlParameter("@ratingMax", ratingMax.Value));
			}
			if (PremiereMin.Checked)
			{
				conditions.Add("premiereMin >= @premiereMin");
				parameters.Add(new MySqlParameter("@premiereMin", PremiereMin.Value));
			}
			if (PremiereMax.Checked)
			{
				conditions.Add("premiereMax <= @premiereMax");
				parameters.Add(new MySqlParameter("@premiereMax", PremiereMax.Value));
			}
			if (lengthMin.HasValue)
			{
				conditions.Add("length >= @lengthMin");
				parameters.Add(new MySqlParameter("@lengthMin", lengthMin.Value));
			}
			if (lengthMax.HasValue)
			{
				conditions.Add("length <= @lengthMax");
				parameters.Add(new MySqlParameter("@lengthMax", lengthMax.Value));
			}
			if (genreID.HasValue)
			{
				conditions.Add("genre_id = @genreID");
				parameters.Add(new MySqlParameter("@genreID", genreID.Value));
			}

			if(conditions.Count > 0) sql += " WHERE " + string.Join(" AND ", conditions);
			Console.WriteLine(sql);
			var query = Program.movies.Context.SqlQuery(sql, parameters.ToArray());
			movieList.DataSource = query.ToList();
		}

		private void movieList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selected = (ListBox)sender;
			selectedMovie = FindMovie(selected.Text);
			movieImage.Visible = true;
			MovieTitle.Visible = true;
			MovieGenres.Visible = true;
			BuyTicketButton.Visible = true;
			PremiereDate.Visible = true;
			RatingLabel.Visible = true;

			var movie = selectedMovie;

			MovieTitle.Text = movie.Title;

			var pId = new MySqlParameter("@id", movie.ID);
			var genres = Program.genres.Context.SqlQuery
				("SELECT * FROM `movie_genres` " +
				"JOIN genres ON movie_genres.genre_id = genres.id " +
				"WHERE movie_id= @id", pId);
			MovieGenres.Text = string.Join(", ", genres);

			RatingLabel.Text = $"Ocena: {movie.Rating}/10";

			PremiereDate.Text = $"Data premiery: {movie.Premiere}";
		}

		Movie FindMovie(string title)
		{
			var bytes = Encoding.Default.GetBytes(title);
			var encTitle = Encoding.Convert(Encoding.Default, Encoding.UTF8, bytes);
			var pTitle = new MySqlParameter("@title", encTitle);
			var query = Program.movies.Context.SqlQuery("SELECT * FROM MOVIES WHERE TITLE = @title", pTitle);
			return query.First();
		}

		private void BuyTicketButton_Click(object sender, EventArgs e)
		{
			var reserveTicket = new ReserveTicketForm(selectedMovie);
			reserveTicket.ShowDialog();
		}
	}
}
