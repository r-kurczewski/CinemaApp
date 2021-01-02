using Kino.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Kino
{
	public partial class ReserveTicketForm : Form
	{
		private IContainer components;
		private ComboBox departmentsList;
		private ListBox seancesList;
		private PictureBox roomScheme;
		private ComboBox seatNumber;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox nameBox;
		private TextBox surnameBox;
		private TextBox phoneBox;
		private TextBox emailBox;
		private Button ReserveButton;
		private Label label6;
		private ComboBox ticketType;
		private Label priceLabel;
		private BindingSource bindingSource1;

		private Seance selectedSeance;
		private Department selectedDepartment;
		private TicketType selectedTicketType;


		public ReserveTicketForm(Movie movie)
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveTicketForm));
			this.departmentsList = new System.Windows.Forms.ComboBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.seancesList = new System.Windows.Forms.ListBox();
			this.roomScheme = new System.Windows.Forms.PictureBox();
			this.seatNumber = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.surnameBox = new System.Windows.Forms.TextBox();
			this.phoneBox = new System.Windows.Forms.TextBox();
			this.emailBox = new System.Windows.Forms.TextBox();
			this.ReserveButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.ticketType = new System.Windows.Forms.ComboBox();
			this.priceLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roomScheme)).BeginInit();
			this.SuspendLayout();
			// 
			// departmentsList
			// 
			this.departmentsList.FormattingEnabled = true;
			this.departmentsList.Location = new System.Drawing.Point(12, 12);
			this.departmentsList.Name = "departmentsList";
			this.departmentsList.Size = new System.Drawing.Size(211, 21);
			this.departmentsList.TabIndex = 0;
			this.departmentsList.SelectedIndexChanged += new System.EventHandler(this.departmentsList_SelectedIndexChanged);
			// 
			// seancesList
			// 
			this.seancesList.FormattingEnabled = true;
			this.seancesList.Location = new System.Drawing.Point(12, 49);
			this.seancesList.Name = "seancesList";
			this.seancesList.Size = new System.Drawing.Size(211, 381);
			this.seancesList.TabIndex = 1;
			this.seancesList.SelectedIndexChanged += new System.EventHandler(this.seancesList_SelectedIndexChanged);
			// 
			// roomScheme
			// 
			this.roomScheme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.roomScheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomScheme.BackgroundImage")));
			this.roomScheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.roomScheme.Location = new System.Drawing.Point(274, 49);
			this.roomScheme.Name = "roomScheme";
			this.roomScheme.Size = new System.Drawing.Size(397, 241);
			this.roomScheme.TabIndex = 2;
			this.roomScheme.TabStop = false;
			this.roomScheme.Visible = false;
			// 
			// seatNumber
			// 
			this.seatNumber.FormattingEnabled = true;
			this.seatNumber.Location = new System.Drawing.Point(366, 317);
			this.seatNumber.Name = "seatNumber";
			this.seatNumber.Size = new System.Drawing.Size(53, 21);
			this.seatNumber.TabIndex = 3;
			this.seatNumber.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(275, 320);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Numer siedzenia";
			this.label1.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(527, 317);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Imie";
			this.label2.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(500, 343);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nazwisko";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(494, 369);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Nr telefonu";
			this.label4.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(518, 395);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "E-mail";
			this.label5.Visible = false;
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(559, 314);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(136, 20);
			this.nameBox.TabIndex = 5;
			this.nameBox.Visible = false;
			// 
			// surnameBox
			// 
			this.surnameBox.Location = new System.Drawing.Point(559, 340);
			this.surnameBox.Name = "surnameBox";
			this.surnameBox.Size = new System.Drawing.Size(136, 20);
			this.surnameBox.TabIndex = 5;
			this.surnameBox.Visible = false;
			// 
			// phoneBox
			// 
			this.phoneBox.Location = new System.Drawing.Point(559, 366);
			this.phoneBox.Name = "phoneBox";
			this.phoneBox.Size = new System.Drawing.Size(136, 20);
			this.phoneBox.TabIndex = 5;
			this.phoneBox.Visible = false;
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(559, 392);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(136, 20);
			this.emailBox.TabIndex = 5;
			this.emailBox.Visible = false;
			// 
			// ReserveButton
			// 
			this.ReserveButton.Location = new System.Drawing.Point(417, 408);
			this.ReserveButton.Name = "ReserveButton";
			this.ReserveButton.Size = new System.Drawing.Size(75, 23);
			this.ReserveButton.TabIndex = 6;
			this.ReserveButton.Text = "Zarezerwuj";
			this.ReserveButton.UseVisualStyleBackColor = true;
			this.ReserveButton.Visible = false;
			this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(275, 347);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Typ biletu";
			this.label6.Visible = false;
			// 
			// ticketType
			// 
			this.ticketType.FormattingEnabled = true;
			this.ticketType.Location = new System.Drawing.Point(334, 344);
			this.ticketType.Name = "ticketType";
			this.ticketType.Size = new System.Drawing.Size(85, 21);
			this.ticketType.TabIndex = 3;
			this.ticketType.Visible = false;
			this.ticketType.SelectedIndexChanged += new System.EventHandler(this.ticketType_SelectedIndexChanged);
			// 
			// priceLabel
			// 
			this.priceLabel.AutoSize = true;
			this.priceLabel.Location = new System.Drawing.Point(336, 369);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(80, 13);
			this.priceLabel.TabIndex = 7;
			this.priceLabel.Text = "Cena: 120.00zł";
			// 
			// ReserveTicketForm
			// 
			this.ClientSize = new System.Drawing.Size(719, 443);
			this.Controls.Add(this.priceLabel);
			this.Controls.Add(this.ReserveButton);
			this.Controls.Add(this.emailBox);
			this.Controls.Add(this.phoneBox);
			this.Controls.Add(this.surnameBox);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ticketType);
			this.Controls.Add(this.seatNumber);
			this.Controls.Add(this.roomScheme);
			this.Controls.Add(this.seancesList);
			this.Controls.Add(this.departmentsList);
			this.Name = "ReserveTicketForm";
			this.Text = "Wybierz seans";
			this.Load += new System.EventHandler(this.ReserveTicketForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roomScheme)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void ReserveTicketForm_Load(object sender, EventArgs e)
		{
			departmentsList.DataSource = Program.departments.Context.ToList();
			ticketType.DataSource = Program.ticketTypes.Context.ToList();
		}

		private void departmentsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedDepartment = (Department)departmentsList.SelectedValue;
			var sql = @"SELECT seances.*, 3d AS Is3d FROM seances 
							JOIN cinema_rooms ON (cinema_room_id = cinema_rooms.id)
							WHERE department_id = @dID AND movie_id = @mID";
			var dID = new MySqlParameter("dID", selectedDepartment.ID);
			var mID = new MySqlParameter("mID", MainForm.selectedMovie.ID);
			var query = Program.seances.Context.SqlQuery(sql, dID, mID);
			seancesList.DataSource = query.ToList();
			SetDetailsVisible(seancesList.Items.Count > 0);
		}

		private void seancesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedSeance = (Seance)seancesList.SelectedValue;
			var sql = @"SELECT * FROM cinema_rooms 
							WHERE department_id = @id;";
			var pId = new MySqlParameter("@id", selectedDepartment.ID);
			int roomSeats = Program.cinemaRooms.Context.SqlQuery(sql, pId).FirstOrDefault().Total_Seats;
			var seats = new SortedSet<int>(Enumerable.Range(1, roomSeats));

			sql = @"SELECT * FROM tickets
					WHERE seance_id = @id";
			var pID = new MySqlParameter("@id", selectedSeance.ID);
			var takenSeats = new SortedSet<int>(Program.tickets.Context.SqlQuery(sql, pID).Select(x => x.Seat_Number));

			seats.ExceptWith(takenSeats);
			seatNumber.DataSource = seats.ToList();
		}

		private void SetDetailsVisible(bool visible)
		{
			label1.Visible = visible;
			label2.Visible = visible;
			label3.Visible = visible;
			label4.Visible = visible;
			label5.Visible = visible;
			label6.Visible = visible;
			seatNumber.Visible = visible;
			ticketType.Visible = visible;
			nameBox.Visible = visible;
			surnameBox.Visible = visible;
			phoneBox.Visible = visible;
			emailBox.Visible = visible;
			roomScheme.Visible = visible;
			ReserveButton.Visible = visible;
		}

		private void ReserveButton_Click(object sender, EventArgs e)
		{
			if (nameBox.Text == string.Empty || surnameBox.Text == string.Empty 
				|| phoneBox.Text == string.Empty || emailBox.Text == string.Empty)
			{
				MessageBox.Show("Wypełnij poprawnie wszystkie pola");
				return;
			}
			var sql = @"SELECT * FROM clients WHERE name = @name AND surname = @surname AND phone = @phone AND email = @email";
			List<string> conditions = new List<string>();
			List<MySqlParameter> parameters = new List<MySqlParameter>();
			parameters.Add(new MySqlParameter("@name", nameBox.Text));
			parameters.Add(new MySqlParameter("@surname", surnameBox.Text));
			parameters.Add(new MySqlParameter("@phone", phoneBox.Text));
			parameters.Add(new MySqlParameter("@email", emailBox.Text));
			int? clientID = Program.clients.Context.SqlQuery(sql, parameters.ToArray()).FirstOrDefault()?.ID;

			MySqlCommand cmd;
			while(!clientID.HasValue)
			{
				var sql2 = @"INSERT INTO clients(name, surname, phone, email) VALUES (@name, @surname, @phone, @email)";
				cmd = new MySqlCommand(sql2, Program.connection);
				cmd.Parameters.AddRange(parameters.ToArray());
				cmd.ExecuteNonQuery();
			}

			sql = @"INSERT INTO tickets (seance_id, seat_number, client_id, ticket_type_id) 
					VALUES (@seance, @seat, @client, @ticketType)";
			parameters = new List<MySqlParameter>();
			parameters.Add(new MySqlParameter("@seance", selectedSeance.ID));
			parameters.Add(new MySqlParameter("@seat", (int)seatNumber.SelectedValue));
			parameters.Add(new MySqlParameter("@client", clientID.Value));
			parameters.Add(new MySqlParameter("@ticketType", selectedTicketType.ID));
			cmd = new MySqlCommand(sql, Program.connection);
			cmd.Parameters.AddRange(parameters.ToArray());
			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Rezerwacja została dokonana.");
			}
			catch(MySqlException)
			{
				MessageBox.Show("Nie udało się zarezerwować. Spróbuj ponownie");
			}
		}

		private void ticketType_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedTicketType = (TicketType)ticketType.SelectedValue;
			priceLabel.Text = "Cena: " + (selectedSeance.Is3D ? selectedTicketType.Price3D : selectedTicketType.Price) + "zł";
		}
	}
}
