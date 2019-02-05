namespace Scheduler
{
	partial class Projects
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editìToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label5 = new System.Windows.Forms.Label();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.projectList = new System.Windows.Forms.ListBox();
			this.statusList = new System.Windows.Forms.ListBox();
			this.typeList = new System.Windows.Forms.ListBox();
			this.todoList = new System.Windows.Forms.ListBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.projectList, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.statusList, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.typeList, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.todoList, 3, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 345);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(610, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "TODO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(206, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Status";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Project";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Black;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editìToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(812, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// editìToolStripMenuItem
			// 
			this.editìToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntryToolStripMenuItem,
            this.removeEntryToolStripMenuItem});
			this.editìToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.editìToolStripMenuItem.Name = "editìToolStripMenuItem";
			this.editìToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editìToolStripMenuItem.Text = "Edit";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(408, 1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Type";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// addEntryToolStripMenuItem
			// 
			this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
			this.addEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addEntryToolStripMenuItem.Text = "Add Entry";
			this.addEntryToolStripMenuItem.ToolTipText = "Add a new project entry after the selected entry";
			this.addEntryToolStripMenuItem.Click += new System.EventHandler(this.addEntryToolStripMenuItem_Click);
			// 
			// removeEntryToolStripMenuItem
			// 
			this.removeEntryToolStripMenuItem.Name = "removeEntryToolStripMenuItem";
			this.removeEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.removeEntryToolStripMenuItem.Text = "Remove Entry";
			this.removeEntryToolStripMenuItem.ToolTipText = "Remove the selected project";
			// 
			// projectList
			// 
			this.projectList.BackColor = System.Drawing.Color.Black;
			this.projectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.projectList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.projectList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.projectList.FormattingEnabled = true;
			this.projectList.Location = new System.Drawing.Point(4, 25);
			this.projectList.Name = "projectList";
			this.projectList.Size = new System.Drawing.Size(195, 316);
			this.projectList.TabIndex = 5;
			// 
			// statusList
			// 
			this.statusList.BackColor = System.Drawing.Color.Black;
			this.statusList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.statusList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statusList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.statusList.FormattingEnabled = true;
			this.statusList.Location = new System.Drawing.Point(206, 25);
			this.statusList.Name = "statusList";
			this.statusList.Size = new System.Drawing.Size(195, 316);
			this.statusList.TabIndex = 6;
			// 
			// typeList
			// 
			this.typeList.BackColor = System.Drawing.Color.Black;
			this.typeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.typeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.typeList.FormattingEnabled = true;
			this.typeList.Location = new System.Drawing.Point(408, 25);
			this.typeList.Name = "typeList";
			this.typeList.Size = new System.Drawing.Size(195, 312);
			this.typeList.TabIndex = 7;
			// 
			// todoList
			// 
			this.todoList.BackColor = System.Drawing.Color.Black;
			this.todoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.todoList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.todoList.FormattingEnabled = true;
			this.todoList.Location = new System.Drawing.Point(610, 25);
			this.todoList.Name = "todoList";
			this.todoList.Size = new System.Drawing.Size(195, 312);
			this.todoList.TabIndex = 8;
			// 
			// Projects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 369);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Projects";
			this.Text = "Projects";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editìToolStripMenuItem;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeEntryToolStripMenuItem;
		public System.Windows.Forms.ListBox projectList;
		public System.Windows.Forms.ListBox statusList;
		public System.Windows.Forms.ListBox typeList;
		public System.Windows.Forms.ListBox todoList;
	}
}