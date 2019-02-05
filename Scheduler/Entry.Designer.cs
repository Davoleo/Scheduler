namespace Scheduler
{
	partial class Entry
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txbType = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboStatus = new System.Windows.Forms.ComboBox();
			this.radioTODOFalse = new System.Windows.Forms.RadioButton();
			this.radioTODOTrue = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Location = new System.Drawing.Point(170, 147);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(89, 147);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txbName
			// 
			this.txbName.BackColor = System.Drawing.Color.Black;
			this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.txbName.Location = new System.Drawing.Point(89, 12);
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(156, 20);
			this.txbName.TabIndex = 2;
			this.txbName.Validating += new System.ComponentModel.CancelEventHandler(this.txbName_Validating);
			this.txbName.Validated += new System.EventHandler(this.txbName_Validated);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Project Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Project Status:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Project Type:";
			// 
			// txbType
			// 
			this.txbType.BackColor = System.Drawing.Color.Black;
			this.txbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.txbType.Location = new System.Drawing.Point(89, 64);
			this.txbType.Name = "txbType";
			this.txbType.Size = new System.Drawing.Size(156, 20);
			this.txbType.TabIndex = 6;
			this.txbType.Validating += new System.ComponentModel.CancelEventHandler(this.txbType_Validating);
			this.txbType.Validated += new System.EventHandler(this.txbType_Validated);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "TODO:";
			// 
			// comboStatus
			// 
			this.comboStatus.BackColor = System.Drawing.Color.Black;
			this.comboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.comboStatus.FormattingEnabled = true;
			this.comboStatus.Location = new System.Drawing.Point(89, 37);
			this.comboStatus.Name = "comboStatus";
			this.comboStatus.Size = new System.Drawing.Size(156, 21);
			this.comboStatus.TabIndex = 10;
			this.comboStatus.Validating += new System.ComponentModel.CancelEventHandler(this.comboStatus_Validating);
			this.comboStatus.Validated += new System.EventHandler(this.comboStatus_Validated);
			// 
			// radioTODOFalse
			// 
			this.radioTODOFalse.AutoSize = true;
			this.radioTODOFalse.Location = new System.Drawing.Point(89, 91);
			this.radioTODOFalse.Name = "radioTODOFalse";
			this.radioTODOFalse.Size = new System.Drawing.Size(47, 17);
			this.radioTODOFalse.TabIndex = 11;
			this.radioTODOFalse.Text = "True";
			this.radioTODOFalse.UseVisualStyleBackColor = true;
			this.radioTODOFalse.CheckedChanged += new System.EventHandler(this.radioTODOFalse_CheckedChanged);
			// 
			// radioTODOTrue
			// 
			this.radioTODOTrue.AutoSize = true;
			this.radioTODOTrue.Checked = true;
			this.radioTODOTrue.Location = new System.Drawing.Point(195, 93);
			this.radioTODOTrue.Name = "radioTODOTrue";
			this.radioTODOTrue.Size = new System.Drawing.Size(50, 17);
			this.radioTODOTrue.TabIndex = 12;
			this.radioTODOTrue.TabStop = true;
			this.radioTODOTrue.Text = "False";
			this.radioTODOTrue.UseVisualStyleBackColor = true;
			// 
			// Entry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(255, 177);
			this.Controls.Add(this.radioTODOTrue);
			this.Controls.Add(this.radioTODOFalse);
			this.Controls.Add(this.comboStatus);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txbType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txbName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Entry";
			this.ShowIcon = false;
			this.Text = "Add/Edit Entry";
			this.Load += new System.EventHandler(this.Entry_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txbType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboStatus;
		private System.Windows.Forms.RadioButton radioTODOFalse;
		private System.Windows.Forms.RadioButton radioTODOTrue;
	}
}