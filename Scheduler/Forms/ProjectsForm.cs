using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Scheduler.Utils;

namespace Scheduler
{
	public partial class ProjectsForm  : Form
    {

        public static String[] statuses = {"Active", "Idle", "Inactive", "Complete"};
        private Main mainForm;
        Entry formEntry = new Entry();

        private DataTable projectsTable;
        private bool saved = false;

        public ProjectsForm()
		{
			InitializeComponent();
            projectsTable = DatabaseHelper.GetAllProjects();
            dataGridViewProjects.DataSource = projectsTable;
        }

        private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{ 
			formEntry.ShowDialog();
		}

		public void SetTheme(Color color)
		{
            for (int i = 0; i < menuStrip1.Items.Count; i++)
			{
				menuStrip1.Items[i].ForeColor = color;
			}
		}

		private void Projects_Load(object sender, EventArgs e)
		{
			mainForm = (Main) Application.OpenForms[0];
			SetTheme(mainForm.getActiveTheme());
		}
    }
}
