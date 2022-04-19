using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WinForm.Forms
{
    public partial class FrmBasicGrid : Form
    {
        public SqlConnection Connection { get; private set; }
        public FrmBasicGrid(SqlConnection connection)
        {
            InitializeComponent();
            Connection = connection;
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            using (FrmBasic frm = new FrmBasic())
            {                
                frm.ShowDialog();
            }
        }
    }
}