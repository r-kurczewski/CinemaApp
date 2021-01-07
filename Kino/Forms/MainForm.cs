using Kino.Database.Model;
using Kino.Forms;
using Kino.Other;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Kino.Database;
using System.Data.SqlClient;

namespace Kino.Forms
{
	public partial class MainForm : Form
	{
		public static Movie selectedMovie;
		private Genre defaultGenre;


		List<DbSelectOption> dbList = new List<DbSelectOption>();
		private DbSelectOption selectedDb;

		class DbSelectOption
		{
			public string label;
			public Action load;
			public Action addEdit;
			public Action delete;

			public DbSelectOption(string label, Action load, Action addEdit, Action delete)
			{
				this.label = label;
				this.load = load;
				this.addEdit = addEdit;
				this.delete = delete;
			}

			public override string ToString()
			{
				return label;
			}
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Program.dbContext = new Database.CinemaContext(Program.connection);
			//movieList.DataSource = Program.movies.Context.ToList();
			defaultGenre = new Genre()
			{
				ID = -1,
				Name = "Dowolny"
			};
			List<Genre> genres = new List<Genre>() { defaultGenre };
			genres.AddRange(Program.dbContext.Genres.ToList());
			GenreSelect.DataSource = genres;

			dbList.Add(new DbSelectOption("Filmy", () => // load
			{
				Program.dbContext.Movies.OrderBy(x => x.ID).Load();
				var query = Program.dbContext.Movies.Local.ToBindingList();
				dataGridView1.DataSource = query;
			}, () => // addEdit
			{
				Movie movie = null;
				if (dataGridView1.SelectedRows.Count == 1)
				{
					movie = (Movie)dataGridView1.SelectedRows[0].DataBoundItem;
				}
				new MovieEditForm(movie).ShowDialog();
				RefreshGridView();
			}, () => // delete
			{
				try
				{
					var movie = (Movie)dataGridView1.SelectedRows[0].DataBoundItem;
					if (MessageBox.Show("Czy na pewno chcesz usunąć rekord?", "Usuń rekord", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						Program.dbContext.Movies.Remove(Program.dbContext.Movies.First(x => x.ID == movie.ID));
						Program.dbContext.SaveChanges();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie udało się usunąć rekordu. " + ex.Message);
				}
				finally
				{
					RefreshGridView();
				}

			}));
			dbList.Add(new DbSelectOption("Pracownicy", () =>
			{
				var id = int.Parse(departmentID.Text);
				Program.dbContext.Employees.OrderBy(x => x.ID).Load();
				var query = Program.dbContext.Employees.Local.ToBindingList().Where(x => x.Department_Id == id).ToList();
				dataGridView1.DataSource = query;
			}, () =>
			{
				Employee employee = null;
				if (dataGridView1.SelectedRows.Count == 1)
				{
					employee = (Employee)dataGridView1.SelectedRows[0].DataBoundItem;
				}
				new EmployeeEditForm(employee, int.Parse(departmentID.Text)).ShowDialog();
				RefreshGridView();
			}, () =>
			{
				try
				{
					var employee = (Employee)dataGridView1.SelectedRows[0].DataBoundItem;
					if (MessageBox.Show("Czy na pewno chcesz usunąć rekord?", "Usuń rekord", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						Program.dbContext.Employees.Remove(Program.dbContext.Employees.First(x => x.ID == employee.ID));
						Program.dbContext.SaveChanges();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie udało się usunąć rekordu. " + ex.Message);
				}
				finally
				{
					RefreshGridView();
				}
			}));
			dbList.Add(new DbSelectOption("Seanse", () =>
			{
				int id = int.Parse(departmentID.Text);
				var query = (from s in Program.dbContext.Seances
								 join c in Program.dbContext.CinemaRooms on s.Cinema_Room_ID equals c.ID
								 where c.Department_ID == id
								 orderby s.ID
								 select s).ToList();
				var bindingList = new BindingList<Seance>(query);
				dataGridView1.DataSource = bindingList;
			}, () =>
			{
				Seance seance = null;
				if (dataGridView1.SelectedRows.Count == 1)
				{
					seance = (Seance)dataGridView1.SelectedRows[0].DataBoundItem;
				}
				new SeanceEdit(seance, int.Parse(departmentID.Text)).ShowDialog();
				RefreshGridView();
			}, () =>
			{
				try
				{
					var seance = (Seance)dataGridView1.SelectedRows[0].DataBoundItem;
					if (MessageBox.Show("Czy na pewno chcesz usunąć rekord?", "Usuń rekord", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						Program.dbContext.Seances.Remove(Program.dbContext.Seances.First(x => x.ID == seance.ID));
						Program.dbContext.SaveChanges();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie udało się usunąć rekordu. " + ex.Message);
				}
				finally
				{
					RefreshGridView();
				}
			}));
			dbSelect.DataSource = dbList;

			Program.dbContext.Departments.Load();
			departmentsGridView.DataSource = Program.dbContext.Departments.Local.ToBindingList();
		}

		private void dbSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshGridView();
		}

		private void RefreshGridView()
		{
			Program.dbContext = new CinemaContext(Program.connection);
			selectedDb = (DbSelectOption)dbSelect.SelectedValue;
			selectedDb.load();
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
			Genre genre = (Genre)GenreSelect.SelectedValue;
			decimal? ratingMin = RatingMin.Text.ToNullableDecimal();
			decimal? ratingMax = RatingMax.Text.ToNullableDecimal();
			TimeSpan? lengthMin = LengthMin.Text.ToNullableTimeSpan();
			TimeSpan? lengthMax = LengthMax.Text.ToNullableTimeSpan();

			var query = (from m in Program.dbContext.Movies
							 join mg in Program.dbContext.MovieGenres on m.ID equals mg.Movie_ID
							 join g in Program.dbContext.Genres on mg.Genre_ID equals g.ID
							 where (title == string.Empty || m.Title.Contains(title))
							 && (!ratingMin.HasValue || m.Rating >= ratingMin)
							 && (!ratingMax.HasValue || m.Rating <= ratingMax)
							 && (!PremiereMin.Checked || m.Premiere >= PremiereMin.Value)
							 && (!PremiereMax.Checked || m.Premiere <= PremiereMax.Value)
							 && (!lengthMin.HasValue || m.Length >= lengthMin.Value)
							 && (!lengthMax.HasValue || m.Length <= lengthMax.Value)
							 && (genre.ID == defaultGenre.ID || g.ID == genre.ID)
							 select m).Distinct().ToList();
			movieList.DataSource = query;
			ShowMovieDetails(movieList.Items.Count > 0);
		}

		private void movieList_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedMovie = (Movie)movieList.SelectedValue;

			var movie = selectedMovie;

			MovieTitle.Text = movie.Title;

			var genres = (from mg in Program.dbContext.MovieGenres
							  join m in Program.dbContext.Movies on mg.Movie_ID equals m.ID
							  join g in Program.dbContext.Genres on mg.Genre_ID equals g.ID
							  where mg.Movie_ID == movie.ID
							  select g.Name).ToList();

			MovieGenres.Text = string.Join(", ", genres);

			RatingLabel.Text = $"Ocena: {movie.Rating}/10";

			PremiereDate.Text = $"Data premiery: {movie.Premiere}";

			ShowMovieDetails(true);
		}

		private void ShowMovieDetails(bool visible)
		{
			movieImage.Visible = visible;
			MovieTitle.Visible = visible;
			MovieGenres.Visible = visible;
			BuyTicketButton.Visible = visible;
			PremiereDate.Visible = visible;
			RatingLabel.Visible = visible;
		}

		private void BuyTicketButton_Click(object sender, EventArgs e)
		{
			var reserveTicket = new ReserveTicketForm(selectedMovie);
			reserveTicket.ShowDialog();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}



		private void SaveButton_Click(object sender, EventArgs e)
		{
			Program.dbContext.SaveChanges();
			MessageBox.Show("Zapisano zmiany");
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			selectedDb.delete();
		}

		private void AddNewButton_Click(object sender, EventArgs e)
		{
			selectedDb.addEdit();
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			RefreshGridView();
		}

		private void RemoveButton2_Click(object sender, EventArgs e)
		{
			try
			{
				var department = (Department)departmentsGridView.SelectedRows[0].DataBoundItem;
				if (MessageBox.Show("Czy na pewno chcesz usunąć rekord?", "Usuń rekord", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Program.dbContext.Departments.Remove(Program.dbContext.Departments.First(x => x.ID == department.ID));
					Program.dbContext.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Nie udało się usunąć rekordu. " + ex.Message);
			}
			finally
			{
				RefreshGridView2();
			}
		}

		private void AddEditButton2_Click(object sender, EventArgs e)
		{
			Department department = null;
			if (departmentsGridView.SelectedRows.Count == 1)
			{
				department = (Department)departmentsGridView.SelectedRows[0].DataBoundItem;
			}
			new DepartmentEditForm(department).ShowDialog();

			RefreshGridView2();
		}

		private void RefreshGridView2()
		{
			Program.dbContext = new CinemaContext(Program.connection);
			Program.dbContext.Departments.Load();
			departmentsGridView.DataSource = Program.dbContext.Departments.Local.ToBindingList();
		}

		private void ProfitReportButton_Click(object sender, EventArgs e)
		{
			var select = "SELECT * FROM profit_monthly";
			var dataAdapter = new MySqlDataAdapter(select, Program.connection);

			var commandBuilder = new MySqlCommandBuilder(dataAdapter);
			var ds = new DataSet();
			dataAdapter.Fill(ds);

			new ReportForm(ds.Tables[0]).ShowDialog();
		}

		private void MovieReportButton_Click(object sender, EventArgs e)
		{
			var select = "SELECT * FROM most_profitable_movies";
			var dataAdapter = new MySqlDataAdapter(select, Program.connection);

			var commandBuilder = new MySqlCommandBuilder(dataAdapter);
			var ds = new DataSet();
			dataAdapter.Fill(ds);

			new ReportForm(ds.Tables[0]).ShowDialog();
		}

		private void EmployeesReportButton_Click(object sender, EventArgs e)
		{
			var select = "SELECT * FROM employee_list";
			var dataAdapter = new MySqlDataAdapter(select, Program.connection);

			var commandBuilder = new MySqlCommandBuilder(dataAdapter);
			var ds = new DataSet();
			dataAdapter.Fill(ds);

			new ReportForm(ds.Tables[0]).ShowDialog();
		}
	}
}
