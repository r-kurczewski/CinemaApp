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
	public partial class EmployeeEditForm : Form
	{
		Employee employee;
		int id;
		bool newItem;

		public EmployeeEditForm(Employee employee, int departmentID)
		{
			InitializeComponent();

			this.employee = employee;
			id = departmentID;
			newItem = employee is null;
			JobBox.DataSource = Program.dbContext.Jobs.ToList();
			if (newItem) return;
			NameBox.Text = employee.Name;
			SurnameBox.Text = employee.Surname;
			JobStartBox.Value = employee.Job_Start.Date;
			if (employee.Job_End != null)
			{
				JobEndBox.Checked = employee.Job_End.HasValue;
				JobEndBox.Value = employee.Job_End.Value.Date;
			}
			SalaryBox.Text = employee.Salary.ToString();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (newItem)
				{
					employee = new Employee();
					Program.dbContext.Employees.Add(employee);
				}
				employee.Department_Id = id;
				employee.Name = NameBox.Text;
				employee.Surname = SurnameBox.Text;
				employee.Job_Start = JobStartBox.Value.Date;
				employee.Job_End = JobEndBox.Checked ? (DateTime?)JobEndBox.Value.Date : null;
				employee.Job_Id = ((Job)JobBox.SelectedItem).ID;
				employee.Salary = decimal.Parse(SalaryBox.Text);
				Program.dbContext.SaveChanges();
				Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Nie udało się zapisać. {ex.Message}");
				throw ex;
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
