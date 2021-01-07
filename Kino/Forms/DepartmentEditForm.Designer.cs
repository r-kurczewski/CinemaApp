namespace Kino.Forms
{
	partial class DepartmentEditForm
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
			this.CityBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(156, 126);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 9;
			this.CancelButton.Text = "Anuluj";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(50, 126);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 10;
			this.SaveButton.Text = "Zapisz";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CityBox
			// 
			this.CityBox.Location = new System.Drawing.Point(101, 26);
			this.CityBox.Name = "CityBox";
			this.CityBox.Size = new System.Drawing.Size(100, 20);
			this.CityBox.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Miasto";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(101, 52);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(100, 20);
			this.NameBox.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Nazwa";
			// 
			// DepartmentEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 161);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CityBox);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SaveButton);
			this.Name = "DepartmentEditForm";
			this.Text = "Dane oddziału";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TextBox CityBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.Label label2;
	}
}