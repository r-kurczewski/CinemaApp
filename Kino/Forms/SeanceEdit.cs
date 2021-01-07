using Kino.Database.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Kino.Forms
{
	public partial class SeanceEdit : Form
	{
		Seance seance;
		bool newItem;

		public SeanceEdit(Seance seance, int departmentID)
		{
			InitializeComponent();

			this.seance = seance;
			newItem = seance is null;
			CinemaRoomPick.DataSource = Program.dbContext.CinemaRooms.Where(x => x.Department_ID == departmentID).ToList();
			MoviePick.DataSource = Program.dbContext.Movies.ToList();
			LocalisationPick.DataSource = Enum.GetValues(typeof(Seance.LocalisationType));
			if (newItem) return;

			DatePick.Text = seance.Date.ToString("dd.MM.yyyy HH:mm");
			CinemaRoomPick.SelectedItem = Program.dbContext.CinemaRooms.First(x => x.ID == seance.Cinema_Room_ID);
			MoviePick.SelectedItem = Program.dbContext.Movies.First(x => x.ID == seance.Movie_ID);
			LocalisationPick.SelectedItem = seance.GetLocalisation();
			Is3DCheckbox.Checked = seance.Is3D;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (newItem)
				{
					seance = new Seance();
					Program.dbContext.Seances.Add(seance);
				}
				seance.Cinema_Room_ID = ((CinemaRoom)CinemaRoomPick.SelectedItem).ID;
				seance.Movie_ID = ((Movie)MoviePick.SelectedItem).ID;
				seance.Date = DateTime.Parse(DatePick.Text);
				seance.Localisation = ((Seance.LocalisationType)LocalisationPick.SelectedItem).ToString();
				seance.Is3D = Is3DCheckbox.Checked;
				Program.dbContext.SaveChanges();
				Close();
			}
			catch (Exception ex)
			{
				Exception exception = ex;
				while (exception.InnerException != null)
				{
					exception = exception.InnerException;
				}
				MessageBox.Show($"Nie udało się zapisać. {exception.Message}");
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
