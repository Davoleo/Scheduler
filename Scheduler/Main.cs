using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduler.utils;

namespace Scheduler
{
	public partial class Main : Form
	{

		public Main()
		{
			InitializeComponent();
		}

		public static Color greenTheme = Color.FromArgb(0, 170, 85);
		public static Color yellowTheme = Color.FromArgb(189, 0, 0);
		public static Color redTheme = Color.FromArgb(255, 230, 0);


		private void Main_Load(object sender, EventArgs e)
		{
			groupTODO.Paint += groupTODO_Paint;
			

			//Environment
		}

		private void groupTODO_Paint(object sender, PaintEventArgs e)
		{
			GroupBox box = (GroupBox) sender;
			Utils.DrawGroupBox(box, e.Graphics, greenTheme, greenTheme, Color.Black);
		}

		private void btnProjects_Click(object sender, EventArgs e)
		{
			Projects projectForm = new Projects();
			projectForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Settings setttingsForm = new Settings();
			setttingsForm.ShowDialog();
		}
	}
}
