namespace Kino.Forms
{
	partial class SeanceEdit
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CancelButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.CinemaRoomPick = new System.Windows.Forms.ComboBox();
			this.MoviePick = new System.Windows.Forms.ComboBox();
			this.DatePick = new System.Windows.Forms.TextBox();
			this.Is3DCheckbox = new System.Windows.Forms.CheckBox();
			this.LocalisationPick = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(162, 226);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 5;
			this.CancelButton.Text = "Anuluj";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(56, 226);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "Zapisz";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CinemaRoomPick
			// 
			this.CinemaRoomPick.FormattingEnabled = true;
			this.CinemaRoomPick.Location = new System.Drawing.Point(103, 49);
			this.CinemaRoomPick.Name = "CinemaRoomPick";
			this.CinemaRoomPick.Size = new System.Drawing.Size(121, 21);
			this.CinemaRoomPick.TabIndex = 7;
			// 
			// MoviePick
			// 
			this.MoviePick.FormattingEnabled = true;
			this.MoviePick.Location = new System.Drawing.Point(103, 76);
			this.MoviePick.Name = "MoviePick";
			this.MoviePick.Size = new System.Drawing.Size(121, 21);
			this.MoviePick.TabIndex = 7;
			// 
			// DatePick
			// 
			this.DatePick.Location = new System.Drawing.Point(103, 103);
			this.DatePick.Name = "DatePick";
			this.DatePick.Size = new System.Drawing.Size(121, 20);
			this.DatePick.TabIndex = 8;
			// 
			// Is3DCheckbox
			// 
			this.Is3DCheckbox.AutoSize = true;
			this.Is3DCheckbox.Location = new System.Drawing.Point(184, 156);
			this.Is3DCheckbox.Name = "Is3DCheckbox";
			this.Is3DCheckbox.Size = new System.Drawing.Size(40, 17);
			this.Is3DCheckbox.TabIndex = 9;
			this.Is3DCheckbox.Text = "3D";
			this.Is3DCheckbox.UseVisualStyleBackColor = true;
			// 
			// LocalisationPick
			// 
			this.LocalisationPick.FormattingEnabled = true;
			this.LocalisationPick.Location = new System.Drawing.Point(103, 129);
			this.LocalisationPick.Name = "LocalisationPick";
			this.LocalisationPick.Size = new System.Drawing.Size(121, 21);
			this.LocalisationPick.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Sala kinowa";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Film";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(67, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Data";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Lokalizacja";
			// 
			// SeanceEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Is3DCheckbox);
			this.Controls.Add(this.DatePick);
			this.Controls.Add(this.LocalisationPick);
			this.Controls.Add(this.MoviePick);
			this.Controls.Add(this.CinemaRoomPick);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SaveButton);
			this.Name = "SeanceEdit";
			this.Text = "Dane seansu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ComboBox CinemaRoomPick;
		private System.Windows.Forms.ComboBox MoviePick;
		private System.Windows.Forms.TextBox DatePick;
		private System.Windows.Forms.CheckBox Is3DCheckbox;
		private System.Windows.Forms.ComboBox LocalisationPick;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}