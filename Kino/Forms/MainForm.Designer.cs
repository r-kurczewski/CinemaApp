namespace Kino.Forms
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.PremiereDate = new System.Windows.Forms.Label();
			this.RatingLabel = new System.Windows.Forms.Label();
			this.BuyTicketButton = new System.Windows.Forms.Button();
			this.MovieGenres = new System.Windows.Forms.Label();
			this.MovieTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Search = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.PremiereMax = new System.Windows.Forms.DateTimePicker();
			this.PremiereMin = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.GenreSelect = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.LengthMax = new System.Windows.Forms.TextBox();
			this.LengthMin = new System.Windows.Forms.TextBox();
			this.RatingMax = new System.Windows.Forms.TextBox();
			this.RatingMin = new System.Windows.Forms.TextBox();
			this.TitleBox = new System.Windows.Forms.TextBox();
			this.movieList = new System.Windows.Forms.ListBox();
			this.movieImage = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.departmentID = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dbSelect = new System.Windows.Forms.ComboBox();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.AddEditButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.departmentsGridView = new System.Windows.Forms.DataGridView();
			this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bdproj_fullDataSet = new Kino.bdproj_fullDataSet();
			this.seancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.seancesTableAdapter = new Kino.bdproj_fullDataSetTableAdapters.seancesTableAdapter();
			this.ticketsTableAdapter = new Kino.bdproj_fullDataSetTableAdapters.ticketsTableAdapter();
			this.departmentsTableAdapter = new Kino.bdproj_fullDataSetTableAdapters.departmentsTableAdapter();
			this.ProfitReportButton = new System.Windows.Forms.Button();
			this.EmployeesReportButton = new System.Windows.Forms.Button();
			this.MovieReportButton = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.ticketsibfk3BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.movieImage)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdproj_fullDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.seancesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ticketsibfk3BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(680, 518);
			this.tabControl1.TabIndex = 1;
			this.tabControl1.TabStop = false;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.PremiereDate);
			this.tabPage1.Controls.Add(this.RatingLabel);
			this.tabPage1.Controls.Add(this.BuyTicketButton);
			this.tabPage1.Controls.Add(this.MovieGenres);
			this.tabPage1.Controls.Add(this.MovieTitle);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.movieList);
			this.tabPage1.Controls.Add(this.movieImage);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(672, 492);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Panel użytkownika";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// PremiereDate
			// 
			this.PremiereDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PremiereDate.Location = new System.Drawing.Point(570, 416);
			this.PremiereDate.Name = "PremiereDate";
			this.PremiereDate.Size = new System.Drawing.Size(96, 35);
			this.PremiereDate.TabIndex = 7;
			this.PremiereDate.Text = "Data premiery: 25.12.2018";
			this.PremiereDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.PremiereDate.Visible = false;
			// 
			// RatingLabel
			// 
			this.RatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RatingLabel.Location = new System.Drawing.Point(377, 416);
			this.RatingLabel.Name = "RatingLabel";
			this.RatingLabel.Size = new System.Drawing.Size(67, 39);
			this.RatingLabel.TabIndex = 7;
			this.RatingLabel.Text = "Ocena: 8.2/10";
			this.RatingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.RatingLabel.Visible = false;
			// 
			// BuyTicketButton
			// 
			this.BuyTicketButton.Location = new System.Drawing.Point(476, 447);
			this.BuyTicketButton.Name = "BuyTicketButton";
			this.BuyTicketButton.Size = new System.Drawing.Size(75, 23);
			this.BuyTicketButton.TabIndex = 6;
			this.BuyTicketButton.Text = "Zarezerwuj";
			this.BuyTicketButton.UseVisualStyleBackColor = true;
			this.BuyTicketButton.Visible = false;
			this.BuyTicketButton.Click += new System.EventHandler(this.BuyTicketButton_Click);
			// 
			// MovieGenres
			// 
			this.MovieGenres.AutoEllipsis = true;
			this.MovieGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.MovieGenres.Location = new System.Drawing.Point(380, 359);
			this.MovieGenres.Name = "MovieGenres";
			this.MovieGenres.Size = new System.Drawing.Size(259, 42);
			this.MovieGenres.TabIndex = 5;
			this.MovieGenres.Text = "Dramat, Komedia, Obyczajowe";
			this.MovieGenres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MovieGenres.Visible = false;
			// 
			// MovieTitle
			// 
			this.MovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.MovieTitle.Location = new System.Drawing.Point(375, 304);
			this.MovieTitle.Name = "MovieTitle";
			this.MovieTitle.Size = new System.Drawing.Size(264, 70);
			this.MovieTitle.TabIndex = 5;
			this.MovieTitle.Text = "Tytuł filmu";
			this.MovieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MovieTitle.UseMnemonic = false;
			this.MovieTitle.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.Search);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.PremiereMax);
			this.panel1.Controls.Add(this.PremiereMin);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.SearchButton);
			this.panel1.Controls.Add(this.GenreSelect);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.LengthMax);
			this.panel1.Controls.Add(this.LengthMin);
			this.panel1.Controls.Add(this.RatingMax);
			this.panel1.Controls.Add(this.RatingMin);
			this.panel1.Controls.Add(this.TitleBox);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(672, 60);
			this.panel1.TabIndex = 2;
			// 
			// Search
			// 
			this.Search.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Search.Location = new System.Drawing.Point(583, 19);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(73, 23);
			this.Search.TabIndex = 6;
			this.Search.Text = "Szukaj";
			this.Search.UseVisualStyleBackColor = false;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label8.Location = new System.Drawing.Point(6, 36);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 15);
			this.label8.TabIndex = 5;
			this.label8.Text = "Premiera";
			// 
			// PremiereMax
			// 
			this.PremiereMax.Checked = false;
			this.PremiereMax.CustomFormat = "dd-MM-yyyy";
			this.PremiereMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.PremiereMax.Location = new System.Drawing.Point(192, 33);
			this.PremiereMax.Name = "PremiereMax";
			this.PremiereMax.ShowCheckBox = true;
			this.PremiereMax.Size = new System.Drawing.Size(96, 20);
			this.PremiereMax.TabIndex = 0;
			// 
			// PremiereMin
			// 
			this.PremiereMin.Checked = false;
			this.PremiereMin.CustomFormat = "dd-MM-yyyy";
			this.PremiereMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.PremiereMin.Location = new System.Drawing.Point(70, 33);
			this.PremiereMin.Name = "PremiereMin";
			this.PremiereMin.ShowCheckBox = true;
			this.PremiereMin.Size = new System.Drawing.Size(96, 20);
			this.PremiereMin.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(302, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Długość";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(431, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Ocena";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(395, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "-";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(172, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(14, 20);
			this.label7.TabIndex = 3;
			this.label7.Text = "-";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(513, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "-";
			// 
			// SearchButton
			// 
			this.SearchButton.BackColor = System.Drawing.Color.WhiteSmoke;
			this.SearchButton.Location = new System.Drawing.Point(847, 6);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 4;
			this.SearchButton.Text = "Szukaj";
			this.SearchButton.UseVisualStyleBackColor = false;
			// 
			// GenreSelect
			// 
			this.GenreSelect.FormattingEnabled = true;
			this.GenreSelect.Location = new System.Drawing.Point(304, 6);
			this.GenreSelect.Name = "GenreSelect";
			this.GenreSelect.Size = new System.Drawing.Size(121, 21);
			this.GenreSelect.TabIndex = 3;
			this.GenreSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(250, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Gatunek";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tytuł";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// LengthMax
			// 
			this.LengthMax.Location = new System.Drawing.Point(412, 33);
			this.LengthMax.Name = "LengthMax";
			this.LengthMax.Size = new System.Drawing.Size(32, 20);
			this.LengthMax.TabIndex = 1;
			// 
			// LengthMin
			// 
			this.LengthMin.Location = new System.Drawing.Point(358, 33);
			this.LengthMin.Name = "LengthMin";
			this.LengthMin.Size = new System.Drawing.Size(32, 20);
			this.LengthMin.TabIndex = 1;
			// 
			// RatingMax
			// 
			this.RatingMax.Location = new System.Drawing.Point(530, 6);
			this.RatingMax.Name = "RatingMax";
			this.RatingMax.Size = new System.Drawing.Size(32, 20);
			this.RatingMax.TabIndex = 1;
			// 
			// RatingMin
			// 
			this.RatingMin.Location = new System.Drawing.Point(476, 6);
			this.RatingMin.Name = "RatingMin";
			this.RatingMin.Size = new System.Drawing.Size(32, 20);
			this.RatingMin.TabIndex = 1;
			// 
			// TitleBox
			// 
			this.TitleBox.Location = new System.Drawing.Point(44, 7);
			this.TitleBox.Name = "TitleBox";
			this.TitleBox.Size = new System.Drawing.Size(200, 20);
			this.TitleBox.TabIndex = 1;
			// 
			// movieList
			// 
			this.movieList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.movieList.FormattingEnabled = true;
			this.movieList.ItemHeight = 20;
			this.movieList.Location = new System.Drawing.Point(9, 65);
			this.movieList.Name = "movieList";
			this.movieList.Size = new System.Drawing.Size(348, 424);
			this.movieList.TabIndex = 0;
			this.movieList.SelectedIndexChanged += new System.EventHandler(this.movieList_SelectedIndexChanged);
			// 
			// movieImage
			// 
			this.movieImage.BackColor = System.Drawing.Color.Transparent;
			this.movieImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movieImage.BackgroundImage")));
			this.movieImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.movieImage.Location = new System.Drawing.Point(425, 96);
			this.movieImage.Name = "movieImage";
			this.movieImage.Size = new System.Drawing.Size(173, 205);
			this.movieImage.TabIndex = 4;
			this.movieImage.TabStop = false;
			this.movieImage.Visible = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.departmentID);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.dbSelect);
			this.tabPage2.Controls.Add(this.DeleteButton);
			this.tabPage2.Controls.Add(this.AddEditButton);
			this.tabPage2.Controls.Add(this.dataGridView1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(672, 492);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Panel kierownika";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// departmentID
			// 
			this.departmentID.Location = new System.Drawing.Point(289, 465);
			this.departmentID.Name = "departmentID";
			this.departmentID.ReadOnly = true;
			this.departmentID.Size = new System.Drawing.Size(24, 20);
			this.departmentID.TabIndex = 4;
			this.departmentID.Text = "1";
			this.departmentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(171, 468);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Kierownik oddziału nr:";
			// 
			// dbSelect
			// 
			this.dbSelect.FormattingEnabled = true;
			this.dbSelect.Location = new System.Drawing.Point(6, 463);
			this.dbSelect.Name = "dbSelect";
			this.dbSelect.Size = new System.Drawing.Size(121, 21);
			this.dbSelect.TabIndex = 2;
			this.dbSelect.SelectedIndexChanged += new System.EventHandler(this.dbSelect_SelectedIndexChanged);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(591, 463);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteButton.TabIndex = 1;
			this.DeleteButton.Text = "Usuń";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// AddEditButton
			// 
			this.AddEditButton.Location = new System.Drawing.Point(486, 463);
			this.AddEditButton.Name = "AddEditButton";
			this.AddEditButton.Size = new System.Drawing.Size(99, 23);
			this.AddEditButton.TabIndex = 1;
			this.AddEditButton.Text = "Dodaj/Modyfikuj";
			this.AddEditButton.UseVisualStyleBackColor = true;
			this.AddEditButton.Click += new System.EventHandler(this.AddNewButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 6);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(660, 451);
			this.dataGridView1.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.MovieReportButton);
			this.tabPage3.Controls.Add(this.EmployeesReportButton);
			this.tabPage3.Controls.Add(this.ProfitReportButton);
			this.tabPage3.Controls.Add(this.button2);
			this.tabPage3.Controls.Add(this.button3);
			this.tabPage3.Controls.Add(this.departmentsGridView);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(672, 492);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Panel właściciela";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(591, 463);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Usuń";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.RemoveButton2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(486, 463);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(99, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Dodaj/Modyfikuj";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.AddEditButton2_Click);
			// 
			// departmentsGridView
			// 
			this.departmentsGridView.AllowUserToAddRows = false;
			this.departmentsGridView.AllowUserToDeleteRows = false;
			this.departmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.departmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.departmentsGridView.Location = new System.Drawing.Point(6, 6);
			this.departmentsGridView.Name = "departmentsGridView";
			this.departmentsGridView.ReadOnly = true;
			this.departmentsGridView.Size = new System.Drawing.Size(660, 451);
			this.departmentsGridView.TabIndex = 0;
			// 
			// departmentsBindingSource
			// 
			this.departmentsBindingSource.DataMember = "departments";
			this.departmentsBindingSource.DataSource = this.bdproj_fullDataSet;
			// 
			// bdproj_fullDataSet
			// 
			this.bdproj_fullDataSet.DataSetName = "bdproj_fullDataSet";
			this.bdproj_fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// seancesBindingSource
			// 
			this.seancesBindingSource.DataMember = "seances";
			this.seancesBindingSource.DataSource = this.bdproj_fullDataSet;
			// 
			// seancesTableAdapter
			// 
			this.seancesTableAdapter.ClearBeforeFill = true;
			// 
			// ticketsTableAdapter
			// 
			this.ticketsTableAdapter.ClearBeforeFill = true;
			// 
			// departmentsTableAdapter
			// 
			this.departmentsTableAdapter.ClearBeforeFill = true;
			// 
			// ProfitReportButton
			// 
			this.ProfitReportButton.Location = new System.Drawing.Point(56, 463);
			this.ProfitReportButton.Name = "ProfitReportButton";
			this.ProfitReportButton.Size = new System.Drawing.Size(75, 23);
			this.ProfitReportButton.TabIndex = 5;
			this.ProfitReportButton.Text = "Zysk";
			this.ProfitReportButton.UseVisualStyleBackColor = true;
			this.ProfitReportButton.Click += new System.EventHandler(this.ProfitReportButton_Click);
			// 
			// EmployeesReportButton
			// 
			this.EmployeesReportButton.Location = new System.Drawing.Point(218, 463);
			this.EmployeesReportButton.Name = "EmployeesReportButton";
			this.EmployeesReportButton.Size = new System.Drawing.Size(75, 23);
			this.EmployeesReportButton.TabIndex = 5;
			this.EmployeesReportButton.Text = "Pracownicy";
			this.EmployeesReportButton.UseVisualStyleBackColor = true;
			this.EmployeesReportButton.Click += new System.EventHandler(this.EmployeesReportButton_Click);
			// 
			// MovieReportButton
			// 
			this.MovieReportButton.Location = new System.Drawing.Point(137, 463);
			this.MovieReportButton.Name = "MovieReportButton";
			this.MovieReportButton.Size = new System.Drawing.Size(75, 23);
			this.MovieReportButton.TabIndex = 5;
			this.MovieReportButton.Text = "Filmy";
			this.MovieReportButton.UseVisualStyleBackColor = true;
			this.MovieReportButton.Click += new System.EventHandler(this.MovieReportButton_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 468);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "Raporty";
			// 
			// ticketsibfk3BindingSource
			// 
			this.ticketsibfk3BindingSource.DataMember = "tickets_ibfk_3";
			this.ticketsibfk3BindingSource.DataSource = this.seancesBindingSource;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 543);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Kino";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.movieImage)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdproj_fullDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.seancesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ticketsibfk3BindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox TitleBox;
		private System.Windows.Forms.ListBox movieList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox GenreSelect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox LengthMax;
		private System.Windows.Forms.TextBox LengthMin;
		private System.Windows.Forms.TextBox RatingMax;
		private System.Windows.Forms.TextBox RatingMin;
		private System.Windows.Forms.Button Search;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker PremiereMax;
		private System.Windows.Forms.DateTimePicker PremiereMin;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button BuyTicketButton;
		private System.Windows.Forms.Label MovieGenres;
		private System.Windows.Forms.Label MovieTitle;
		private System.Windows.Forms.PictureBox movieImage;
		private System.Windows.Forms.Label RatingLabel;
		private System.Windows.Forms.Label PremiereDate;
		private bdproj_fullDataSet bdproj_fullDataSet;
		private System.Windows.Forms.BindingSource seancesBindingSource;
		private bdproj_fullDataSetTableAdapters.seancesTableAdapter seancesTableAdapter;
		private System.Windows.Forms.DataGridView departmentsGridView;
		private System.Windows.Forms.BindingSource ticketsibfk3BindingSource;
		private bdproj_fullDataSetTableAdapters.ticketsTableAdapter ticketsTableAdapter;
		private System.Windows.Forms.BindingSource departmentsBindingSource;
		private bdproj_fullDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button AddEditButton;
		private System.Windows.Forms.ComboBox dbSelect;
		private System.Windows.Forms.TextBox departmentID;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button MovieReportButton;
		private System.Windows.Forms.Button EmployeesReportButton;
		private System.Windows.Forms.Button ProfitReportButton;
	}
}

