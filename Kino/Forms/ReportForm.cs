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
	public partial class ReportForm : Form
	{
		public ReportForm(object dataSource)
		{
			InitializeComponent();

			dataGridView1.DataSource = dataSource;
		}
	}
}
