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
	public partial class DepartmentEditForm : Form
	{
		Department department;
		bool newItem;

		public DepartmentEditForm(Department department)
		{
			InitializeComponent();

			this.department = department;
			newItem = department is null;
			if (newItem) return;
			CityBox.Text = department.City;
			NameBox.Text = department.Name;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (newItem)
				{
					department = new Department();
					Program.dbContext.Departments.Add(department);
				}
				department.City = CityBox.Text;
				department.Name = NameBox.Text;
				Program.dbContext.SaveChanges();
				Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Nie udało się zapisać. {ex.Message}");
			}
		}
	}
}
