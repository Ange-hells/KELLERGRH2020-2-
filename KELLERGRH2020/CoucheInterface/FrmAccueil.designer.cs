﻿namespace KELLERGRH2020
{
	partial class FrmAccueil
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.gestionDesCollaborateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.gestionDesCollaborateursToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// gestionDesCollaborateursToolStripMenuItem
			// 
			this.gestionDesCollaborateursToolStripMenuItem.Name = "gestionDesCollaborateursToolStripMenuItem";
			this.gestionDesCollaborateursToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
			this.gestionDesCollaborateursToolStripMenuItem.Text = "Gestion des collaborateurs";
			this.gestionDesCollaborateursToolStripMenuItem.Click += new System.EventHandler(this.gestionDesCollaborateursToolStripMenuItem_Click);
			// 
			// FrmAccueil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1029, 502);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmAccueil";
			this.Text = "KELLER";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem gestionDesCollaborateursToolStripMenuItem;
	}
}