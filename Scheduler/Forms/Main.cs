﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Scheduler.Properties;
using Scheduler.Utils;

namespace Scheduler
{
	public partial class Main : Form
	{

		public Main()
		{
			InitializeComponent();
            DatabaseHelper.TestConnection();
        }

		public static Color greenTheme = Color.FromArgb(0, 170, 85);
		public static Color redTheme = Color.FromArgb(189, 0, 0);
		public static Color yellowTheme = Color.FromArgb(255, 230, 0);

		private Color activeTheme;


		private void Main_Load(object sender, EventArgs e)
		{
			groupTODO.Paint += groupTODO_Paint;

            switch (TODOlist.Items.Count)
            {
                case 0:
                    setTheme(greenTheme);
                    break;
                case 1:
                    setTheme(greenTheme);
                    break;
                case 2:
                    setTheme(greenTheme);
                    break;
                case 3:
                    setTheme(yellowTheme);
                    break;
                case 4:
                    setTheme(redTheme);
                    break;
                default:
                    setTheme(redTheme);
                    break;
            }
            //Environment
        }

		private void groupTODO_Paint(object sender, PaintEventArgs e)
		{
			GroupBox box = (GroupBox) sender;
            Utils.Utils.DrawGroupBox(box, e.Graphics, ForeColor, ForeColor, Color.Black);
        }

		private void btnProjects_Click(object sender, EventArgs e)
		{
			ProjectsForm projectForm = new ProjectsForm();
			projectForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Settings settingsForm = new Settings();
			settingsForm.ShowDialog();
		}

		private void setTheme(Color color)
		{
			activeTheme = color;
			ForeColor = color;
			TODOlist.ForeColor = color;
			switch (color.R)
			{
				case 0:
					Icon = Resources.schedule_green;
					break;
				case 189:
					Icon = Resources.schedule_red;
					break;
				case 255:
					Icon = Resources.schedule_yellow;
					break;
			}

		}

		public Color getActiveTheme()
		{
			return activeTheme;
		}
	}
}
