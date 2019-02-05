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

		private String projectName;
		private String status;
		private String type;
		private bool TODO;

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			
		}

		private void Entry_Load(object sender, EventArgs e)
		{
			comboStatus.Items.AddRange(Projects.statuses);
		}

		private void txbName_Validated(object sender, EventArgs e)
		{
			projectName = txbName.Text;
		}

		private void comboStatus_Validated(object sender, EventArgs e)
		{
			status = comboStatus.Text;
		}

		private void txbType_Validated(object sender, EventArgs e)
		{
			type = txbType.Text;
		}

		private void radioTODOFalse_CheckedChanged(object sender, EventArgs e)
		{
			TODO = radioTODOTrue.Checked;
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
