using System;
using System.Windows.Forms;
using WinForm.Forms;
using System.Data.SqlClient;
namespace WinForm
{
    public partial class FormInitial : Form
    {
        public SqlConnection Connection { get; private set; }
        public FormInitial()
        {
            InitializeComponent();
            Connection = new SqlConnection(Utils.Services.GetConnectionString());
        }

        private void PeoplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmBasicGrid grid = new FrmBasicGrid(Connection))
            {
                grid.ShowDialog();
            }
        }

        private void FormInitial_Load(object sender, EventArgs e)
        {

        }
    }
}
