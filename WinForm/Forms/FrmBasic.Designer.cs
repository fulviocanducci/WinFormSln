
namespace WinForm.Forms
{
    partial class FrmBasic
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
            this.CrudControl = new WinForm.Components.CrudControl();
            this.SuspendLayout();
            // 
            // CrudControl
            // 
            this.CrudControl.Location = new System.Drawing.Point(0, 4);
            this.CrudControl.Name = "CrudControl";
            this.CrudControl.Size = new System.Drawing.Size(563, 189);
            this.CrudControl.TabIndex = 0;
            // 
            // FrmBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 193);
            this.Controls.Add(this.CrudControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBasic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBasic";
            this.Load += new System.EventHandler(this.FrmBasic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CrudControl CrudControl;
    }
}