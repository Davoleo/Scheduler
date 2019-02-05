using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
	public partial class Projects : Form
	{
		public Projects()
		{
			InitializeComponent();
		}

		public static String[] statuses = {"Active", "Idle", "Inactive", "Complete"};

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Entry formEntry = new Entry();
			formEntry.ShowDialog();
		}
	}
}
