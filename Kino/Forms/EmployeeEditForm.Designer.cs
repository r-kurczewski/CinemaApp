namespace Kino.Forms
{
	partial class EmployeeEditForm
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
			this.NameBox = new System.Windows.Forms.TextBox();
			this.SurnameBox = new System.Windows.Forms.TextBox();
			this.SalaryBox = new System.Windows.Forms.TextBox();
			this.JobBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.JobStartBox = new System.Windows.Forms.DateTimePicker();
			this.JobEndBox = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(114, 35);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(121, 20);
			this.NameBox.TabIndex = 0;
			// 
			// SurnameBox
			// 
			this.SurnameBox.Location = new System.Drawing.Point(114, 61);
			this.SurnameBox.Name = "SurnameBox";
			this.SurnameBox.Size = new System.Drawing.Size(121, 20);
			this.SurnameBox.TabIndex = 0;
			// 
			// SalaryBox
			// 
			this.SalaryBox.Location = new System.Drawing.Point(114, 166);
			this.SalaryBox.Name = "SalaryBox";
			this.SalaryBox.Size = new System.Drawing.Size(121, 20);
			this.SalaryBox.TabIndex = 0;
			// 
			// JobBox
			// 
			this.JobBox.FormattingEnabled = true;
			this.JobBox.Location = new System.Drawing.Point(114, 139);
			this.JobBox.Name = "JobBox";
			this.JobBox.Size = new System.Drawing.Size(121, 21);
			this.JobBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(82, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Imie";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nazwisko";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Data zatrudnienia";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Data zwolnienia";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(69, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Pensja";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(46, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Stanowisko";
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(160, 226);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 7;
			this.CancelButton.Text = "Anuluj";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(54, 226);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 8;
			this.SaveButton.Text = "Zapisz";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// JobStartBox
			// 
			this.JobStartBox.CustomFormat = "dd.MM.yyyy";
			this.JobStartBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.JobStartBox.Location = new System.Drawing.Point(114, 87);
			this.JobStartBox.Name = "JobStartBox";
			this.JobStartBox.Size = new System.Drawing.Size(121, 20);
			this.JobStartBox.TabIndex = 9;
			// 
			// JobEndBox
			// 
			this.JobEndBox.Checked = false;
			this.JobEndBox.CustomFormat = "dd.MM.yyyy";
			this.JobEndBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.JobEndBox.Location = new System.Drawing.Point(114, 113);
			this.JobEndBox.Name = "JobEndBox";
			this.JobEndBox.ShowCheckBox = true;
			this.JobEndBox.Size = new System.Drawing.Size(121, 20);
			this.JobEndBox.TabIndex = 9;
			// 
			// EmployeeEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.JobEndBox);
			this.Controls.Add(this.JobStartBox);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.JobBox);
			this.Controls.Add(this.SalaryBox);
			this.Controls.Add(this.SurnameBox);
			this.Controls.Add(this.NameBox);
			this.Name = "EmployeeEditForm";
			this.Text = "Dane pracownika";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.TextBox SurnameBox;
		private System.Windows.Forms.TextBox SalaryBox;
		private System.Windows.Forms.ComboBox JobBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.DateTimePicker JobStartBox;
		private System.Windows.Forms.DateTimePicker JobEndBox;
	}
}