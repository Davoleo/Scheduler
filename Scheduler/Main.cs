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

		private void Main_Load(object sender, EventArgs e)
		{
			groupTODO.Paint += groupTODO_Paint;
			//Environment
		}

		private void groupTODO_Paint(object sender, PaintEventArgs e)
		{
			GroupBox box = (GroupBox) sender;
			Utils.DrawGroupBox(box, e.Graphics, Color.FromArgb(0, 170, 85), Color.FromArgb(0, 170, 85), Color.Black);
		}
	}
}
