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
	public partial class Entry : Form
	{
		public Entry()
		{
			InitializeComponent();
		}

		public string ProjectName { get; private set; }
		public string Status { get; private set; }
		public string Type { get; private set; }
		public bool Todo { get; private set; }

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ProjectName = null;
			Status = null;
			Type = null;
			Projects.acceptData = false;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Projects.acceptData = true;
			Hide();
		}

		private void Entry_Load(object sender, EventArgs e)
		{
			comboStatus.Items.AddRange(Projects.statuses);
			txbName.Focus();
		}

		private void txbName_Validated(object sender, EventArgs e)
		{
			ProjectName = txbName.Text;
		}

		private void comboStatus_Validated(object sender, EventArgs e)
		{
			Status = comboStatus.Text;
		}

		private void txbType_Validated(object sender, EventArgs e)
		{
			Type = txbType.Text;
		}

		private void radioTODOFalse_CheckedChanged(object sender, EventArgs e)
		{
			Todo = radioTODOTrue.Checked;
		}

		private void txbName_Validating(object sender, CancelEventArgs e)
		{
			if (txbName.Text == "")
			{ 
				MessageBox.Show("The Project Name is null or invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txbName.ForeColor = Color.Red;
				txbName.Focus();
			}
			else
			{
				txbName.ForeColor = Color.Green;
			}

		}

		private void comboStatus_Validating(object sender, CancelEventArgs e)
		{
			if (/*(comboStatus.Items.IndexOf(comboStatus.SelectedItem) != -1) &&*/ comboStatus.SelectedIndex != -1)
			{
				comboStatus.ForeColor = Color.Green;
			}
			else
			{
				MessageBox.Show("The Status is null or invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				comboStatus.ForeColor = Color.Red;
				comboStatus.Focus();
			}
		}

		private void txbType_Validating(object sender, CancelEventArgs e)
		{
			if (txbType.Text == "" || txbType.Text.Contains("Prova"))
			{
				MessageBox.Show("The Project Type is null or invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txbType.ForeColor = Color.Red;
				txbType.Focus();
			}
			else
			{
				txbType.ForeColor = Color.Green;
			}
		}



		
	}
}
