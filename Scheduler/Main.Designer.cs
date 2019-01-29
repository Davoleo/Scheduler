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
			this.groupTODO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupTODO.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupTODO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
			this.groupTODO.Location = new System.Drawing.Point(17, 57);
			this.groupTODO.Name = "groupTODO";
			this.groupTODO.Size = new System.Drawing.Size(269, 375);
			this.groupTODO.TabIndex = 1;
			this.groupTODO.TabStop = false;
			this.groupTODO.Text = "TODO";
			this.groupTODO.Paint += new System.Windows.Forms.PaintEventHandler(this.groupTODO_Paint);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(692, 444);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox groupTODO;
	}
}

