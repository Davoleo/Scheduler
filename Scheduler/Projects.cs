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
		private Main mainForm;
		public static bool acceptData = false;
		Entry formEntry = new Entry();

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{ 
			formEntry.ShowDialog();
		}

		public void setTheme(Color color)
		{
			tableLayoutPanel1.ForeColor = color;
			projectList.ForeColor = color;
			statusList.ForeColor = color;
			typeList.ForeColor = color;
			todoList.ForeColor = color;

			for (int i = 0; i < menuStrip1.Items.Count; i++)
			{
				menuStrip1.Items[i].ForeColor = color;
			}
		}

		private void Projects_Load(object sender, EventArgs e)
		{
			mainForm = (Main) Application.OpenForms[0];
			setTheme(mainForm.getActiveTheme());
		}

		private void Projects_Activated(object sender, EventArgs e)
		{
			if (acceptData)
			{
				projectList.Items.Add(formEntry.ProjectName);
				statusList.Items.Add(formEntry.Status);
				typeList.Items.Add(formEntry.Type);
				todoList.Items.Add(formEntry.Todo);
				acceptData = false;
			}
		}

		private void projectList_SelectedIndexChanged(object sender, EventArgs e)
		{
			todoList.SelectedIndex = typeList.SelectedIndex = statusList.SelectedIndex = projectList.SelectedIndex;
		}

		private void statusList_SelectedIndexChanged(object sender, EventArgs e)
		{
			projectList.SelectedIndex = todoList.SelectedIndex = typeList.SelectedIndex = statusList.SelectedIndex;
		}

		private void typeList_SelectedIndexChanged(object sender, EventArgs e)
		{
			statusList.SelectedIndex = projectList.SelectedIndex = todoList.SelectedIndex = typeList.SelectedIndex;
		}

		private void todoList_SelectedIndexChanged(object sender, EventArgs e)
		{
			typeList.SelectedIndex = statusList.SelectedIndex = projectList.SelectedIndex = todoList.SelectedIndex;
		}

		private void removeEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			projectList.Items.RemoveAt(projectList.SelectedIndex);
			statusList.Items.RemoveAt(statusList.SelectedIndex);
			typeList.Items.RemoveAt(typeList.SelectedIndex);
			todoList.Items.RemoveAt(todoList.SelectedIndex);
		}
	}
}
