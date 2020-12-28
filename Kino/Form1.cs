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
	public partial class Form1 : Form
	{
		public Form1()
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

			List<Movie> results = Program.movies.Context
				.Where(x => x.Title != string.Empty ? x.Title.Contains(title) : true)
				.Where(x => ratingMin.HasValue ? x.Rating >= ratingMin.Value : true)
				.Where(x => ratingMax.HasValue ? x.Rating <= ratingMax.Value : true)
				.Where(x => PremiereMin.Checked ? x.Premiere >= PremiereMin.Value : true)
				.Where(x => PremiereMax.Checked ? x.Premiere <= PremiereMax.Value : true)
				.Where(x => lengthMin.HasValue ? x.Length >= lengthMin.Value : true)
				.Where(x => lengthMax.HasValue ? x.Length <= lengthMax.Value : true)
				.ToList();

			if(genreID != null)
				results = results.Where(x => Program.movieGenres.Context.Any(g => x.ID == g.Movie_ID && g.Genre_ID == genreID)).ToList();
			movieList.DataSource = results;
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void movieList_SelectedIndexChanged(object sender, EventArgs e)
		{
			Movie movie = Program.movies.Context.FirstOrDefault(x=> x.Title == ((ListBox)sender).Text);
			movieImage.Visible = true;
			MovieTitle.Visible = true;
			MovieGenres.Visible = true;
			BuyTicketButton.Visible = true;
			MovieTitle.Text = movie.Title;
		}
	}
}
