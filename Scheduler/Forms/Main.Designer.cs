namespace Scheduler
{
	partial class Main
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupTODO = new System.Windows.Forms.GroupBox();
            this.TODOlist = new System.Windows.Forms.ListBox();
            this.btnProjects = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupTODO.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Scheduler";
            // 
            // groupTODO
            // 
            this.groupTODO.BackColor = System.Drawing.Color.Transparent;
            this.groupTODO.Controls.Add(this.TODOlist);
            this.groupTODO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupTODO.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTODO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.groupTODO.Location = new System.Drawing.Point(17, 57);
            this.groupTODO.Name = "groupTODO";
            this.groupTODO.Size = new System.Drawing.Size(269, 207);
            this.groupTODO.TabIndex = 1;
            this.groupTODO.TabStop = false;
            this.groupTODO.Text = "TODO";
            this.groupTODO.Paint += new System.Windows.Forms.PaintEventHandler(this.groupTODO_Paint);
            // 
            // TODOlist
            // 
            this.TODOlist.BackColor = System.Drawing.Color.Black;
            this.TODOlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TODOlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODOlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.TODOlist.FormattingEnabled = true;
            this.TODOlist.ItemHeight = 16;
            this.TODOlist.Items.AddRange(new object[] {
            "ciao",
            "ciao",
            "ciao"});
            this.TODOlist.Location = new System.Drawing.Point(3, 20);
            this.TODOlist.Name = "TODOlist";
            this.TODOlist.Size = new System.Drawing.Size(263, 184);
            this.TODOlist.TabIndex = 0;
            // 
            // btnProjects
            // 
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.Location = new System.Drawing.Point(562, 12);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(118, 32);
            this.btnProjects.TabIndex = 5;
            this.btnProjects.Text = "Manage Projects...";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(485, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Settings...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(692, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.groupTODO);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupTODO.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox groupTODO;
		private System.Windows.Forms.ListBox TODOlist;
		private System.Windows.Forms.Button btnProjects;
		private System.Windows.Forms.Button button1;
	}
}

