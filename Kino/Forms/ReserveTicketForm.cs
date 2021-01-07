using Kino.Database.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Kino.Forms
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
		private Label label7;
		private Label label8;
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
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
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
			this.seatNumber.IntegralHeight = false;
			this.seatNumber.Location = new System.Drawing.Point(345, 351);
			this.seatNumber.Name = "seatNumber";
			this.seatNumber.Size = new System.Drawing.Size(53, 21);
			this.seatNumber.TabIndex = 3;
			this.seatNumber.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(254, 354);
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
			this.label6.Location = new System.Drawing.Point(254, 381);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Typ biletu";
			this.label6.Visible = false;
			// 
			// ticketType
			// 
			this.ticketType.FormattingEnabled = true;
			this.ticketType.Location = new System.Drawing.Point(313, 378);
			this.ticketType.Name = "ticketType";
			this.ticketType.Size = new System.Drawing.Size(85, 21);
			this.ticketType.TabIndex = 3;
			this.ticketType.Visible = false;
			this.ticketType.SelectedIndexChanged += new System.EventHandler(this.ticketType_SelectedIndexChanged);
			// 
			// priceLabel
			// 
			this.priceLabel.AutoSize = true;
			this.priceLabel.Location = new System.Drawing.Point(315, 403);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(74, 13);
			this.priceLabel.TabIndex = 7;
			this.priceLabel.Text = "Cena: 12.00zł";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(254, 332);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Seans 3D: Nie";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(257, 308);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 13);
			this.label8.TabIndex = 9;
			this.label8.Text = "Lokalizacja: Lektor";
			// 
			// ReserveTicketForm
			// 
			this.ClientSize = new System.Drawing.Size(719, 443);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
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
			departmentsList.DataSource = Program.dbContext.Departments.ToList();
			ticketType.DataSource = Program.dbContext.TicketTypes.ToList();
		}

		private void departmentsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedDepartment = (Department)departmentsList.SelectedValue;
			var query = (from s in Program.dbContext.Seances
							 join c in Program.dbContext.CinemaRooms 
							 on s.Cinema_Room_ID equals c.ID
							 where c.Department_ID == selectedDepartment.ID
							 select s).ToList();
			seancesList.DataSource = query;
			SetDetailsVisible(seancesList.Items.Count > 0);
		}

		private void seancesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedSeance = (Seance)seancesList.SelectedValue;
			int roomSeats = Program.dbContext.CinemaRooms.FirstOrDefault(x => x.ID == selectedDepartment.ID).Total_Seats;
			var seats = new SortedSet<int>(Enumerable.Range(1, roomSeats));

			var takenSeats = Program.dbContext.Tickets.
				Where(x=> x.Seance_ID == selectedSeance.ID).
				Select(x=>x.Seat_Number).ToList();

			seats.ExceptWith(takenSeats);
			seatNumber.DataSource = seats.ToList();
			label7.Text = $"3D: {(selectedSeance.Is3D ? "Tak" : "Nie")}";
			label8.Text = $"Lokalizacja: {selectedSeance.Localisation}";
			ticketType_SelectedIndexChanged(null, null);
		}

		private void SetDetailsVisible(bool visible)
		{
			label1.Visible = visible;
			label2.Visible = visible;
			label3.Visible = visible;
			label4.Visible = visible;
			label5.Visible = visible;
			label6.Visible = visible;
			label7.Visible = visible;
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
			Client client = Program.dbContext.Clients.
				FirstOrDefault(x => x.Name == nameBox.Text 
				&& x.Surname == surnameBox.Text
				&& x.Phone == phoneBox.Text 
				&& x.Email == emailBox.Text);

			if(client is null)
			{
				try
				{
					Program.dbContext.Clients.Add(new Client()
					{
						Name = nameBox.Text,
						Surname = surnameBox.Text,
						Phone = phoneBox.Text,
						Email = emailBox.Text
					});
					Program.dbContext.SaveChanges();
				}
				catch
				{
					MessageBox.Show("Nie udało się zarezerwować. Spróbuj ponownie");
					return;
				}
			}
			else
			{
				try
				{
					Program.dbContext.Tickets.Add(new Ticket()
					{
						Seance_ID = selectedSeance.ID,
						Seat_Number = (int)seatNumber.SelectedValue,
						Client_ID = client.ID,
						Ticket_Type_ID = selectedTicketType.ID
					});
					Program.dbContext.SaveChanges();
					MessageBox.Show("Rezerwacja została dokonana.");
				}
				catch (MySqlException)
				{
					MessageBox.Show("Nie udało się zarezerwować. Spróbuj ponownie");
					return;
				}
			}
		}

		private void ticketType_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedTicketType = (TicketType)ticketType.SelectedValue;
			priceLabel.Text = "Cena: " + (selectedSeance.Is3D ? selectedTicketType.Price3D : selectedTicketType.Price) + "zł";
		}
	}
}
