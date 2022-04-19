
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridPeople = new System.Windows.Forms.DataGridView();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.TUpdate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPeople
            // 
            this.GridPeople.AllowUserToAddRows = false;
            this.GridPeople.AllowUserToDeleteRows = false;
            this.GridPeople.AllowUserToResizeColumns = false;
            this.GridPeople.AllowUserToResizeRows = false;
            this.GridPeople.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GridPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TUpdate,
            this.TName});
            this.GridPeople.Location = new System.Drawing.Point(8, 55);
            this.GridPeople.Name = "GridPeople";
            this.GridPeople.ReadOnly = true;
            this.GridPeople.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPeople.Size = new System.Drawing.Size(716, 380);
            this.GridPeople.TabIndex = 0;
            this.GridPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPeople_CellClick);
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
            // TUpdate
            // 
            this.TUpdate.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "0000000000";
            this.TUpdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.TUpdate.HeaderText = "...";
            this.TUpdate.Name = "TUpdate";
            this.TUpdate.ReadOnly = true;
            this.TUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TName
            // 
            this.TName.DataPropertyName = "Name";
            this.TName.HeaderText = "Name";
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            this.TName.Width = 550;
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
            this.Controls.Add(this.GridPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBasicGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Grid";
            this.Load += new System.EventHandler(this.FrmBasicGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridPeople;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.DataGridViewLinkColumn TUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
    }
}