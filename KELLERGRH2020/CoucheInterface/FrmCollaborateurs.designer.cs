﻿namespace KELLERGRH2020
{
    partial class FrmCollaborateurs
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvOrganisation = new System.Windows.Forms.TreeView();
            
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvOrganisation);
            // 
            // splitContainer1.Panel2
            // 
            
            this.splitContainer1.Size = new System.Drawing.Size(1173, 507);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvOrganisation
            // 
            this.tvOrganisation.AllowDrop = true;
            this.tvOrganisation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOrganisation.Location = new System.Drawing.Point(0, 0);
            this.tvOrganisation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvOrganisation.Name = "tvOrganisation";
            this.tvOrganisation.Size = new System.Drawing.Size(391, 507);
            this.tvOrganisation.TabIndex = 0;
            this.tvOrganisation.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvOrganisation_BeforeExpand);
            
            // 
            // ucCollaborateurs
            // 
            
            // 
            // FrmCollaborateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 507);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCollaborateurs";
            this.Text = "frmCollaborateurs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvOrganisation;
        
    }
}