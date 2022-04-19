
namespace WinForm
{
    partial class FormInitial
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
            this.CrudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeoplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrudToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CrudToolStripMenuItem
            // 
            this.CrudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PeoplesToolStripMenuItem});
            this.CrudToolStripMenuItem.Name = "CrudToolStripMenuItem";
            this.CrudToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.CrudToolStripMenuItem.Text = "Cadastro";
            // 
            // PeoplesToolStripMenuItem
            // 
            this.PeoplesToolStripMenuItem.Name = "PeoplesToolStripMenuItem";
            this.PeoplesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PeoplesToolStripMenuItem.Text = "Pessoas";
            this.PeoplesToolStripMenuItem.Click += new System.EventHandler(this.PeoplesToolStripMenuItem_Click);
            // 
            // FormInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 171);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInitial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Geral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInitial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CrudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PeoplesToolStripMenuItem;
    }
}

