
namespace WinForm.Forms
{
    partial class FrmBasicGrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TId,
            this.TName});
            this.dataGridView1.Location = new System.Drawing.Point(8, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(716, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // TId
            // 
            this.TId.DataPropertyName = "Id";
            this.TId.HeaderText = "Id";
            this.TId.Name = "TId";
            this.TId.ReadOnly = true;
            // 
            // TName
            // 
            this.TName.DataPropertyName = "Name";
            this.TName.HeaderText = "Name";
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            this.TName.Width = 550;
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(83, 16);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(561, 20);
            this.TxtFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o nome:";
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(651, 13);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(75, 23);
            this.BtnFilter.TabIndex = 3;
            this.BtnFilter.Text = "Filtrar";
            this.BtnFilter.UseVisualStyleBackColor = true;
            // 
            // BtnEnd
            // 
            this.BtnEnd.Location = new System.Drawing.Point(649, 441);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(75, 23);
            this.BtnEnd.TabIndex = 4;
            this.BtnEnd.Text = "Fechar";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(8, 441);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 5;
            this.BtnNew.Text = "Novo";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // FrmBasicGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 472);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBasicGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Grid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Button BtnNew;
    }
}