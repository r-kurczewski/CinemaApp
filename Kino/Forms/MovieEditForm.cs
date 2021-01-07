using Kino.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino.Forms
{
	public partial class MovieEditForm : Form
	{
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button SaveButton;
		private Button CancelButton;

		Movie movie;
		bool newItem;

		public MovieEditForm(Movie movie)
		{
			InitializeComponent();

			this.movie = movie;
			newItem = movie is null;
			if (newItem) return;
			textBox1.Text = movie.Title;
			textBox2.Text = movie.Rating.ToString();
			textBox3.Text = movie.Length.ToString();
			textBox4.Text = movie.Premiere.ToString("dd.MM.yyyy");
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (newItem)
				{
					movie = new Movie();
					Program.dbContext.Movies.Add(movie);
				}
				movie.Title = textBox1.Text;
				movie.Rating = decimal.Parse(textBox2.Text);
				movie.Length = TimeSpan.Parse(textBox3.Text);
				movie.Premiere = DateTime.Parse(textBox4.Text);
				Program.dbContext.SaveChanges();
				Close();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Nie udało się zapisać. {ex.Message}");
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(107, 46);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(107, 72);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(107, 98);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(107, 124);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Tytuł";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Rating";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(53, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Długość";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Premiera";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(41, 226);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Zapisz";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(147, 226);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 4;
			this.CancelButton.Text = "Anuluj";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// MovieEditForm
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "MovieEditForm";
			this.Text = "Dane filmu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
