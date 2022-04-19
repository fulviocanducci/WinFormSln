using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAO;
using System.Linq;
namespace WinForm.Forms
{
    public partial class FrmBasicGrid : Form
    {
        public SqlConnection Connection { get; private set; }
        public DaoPeople DaoPeople { get; private set; }
        public FrmBasicGrid(SqlConnection connection)
        {
            InitializeComponent();
            Connection = connection;
            DaoPeople = new DaoPeople(connection);
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            using (FrmBasic frm = new FrmBasic(DaoPeople))
            {                
                frm.ShowDialog();
                Load_GripPeople();
            }
        }

        private void FrmBasicGrid_Load(object sender, EventArgs e)
        {
            GridPeople.AutoGenerateColumns = false;
            Load_GripPeople();
        }

        private void Load_GripPeople()
        {
            GridPeople.DataSource = DaoPeople.All().ToList();
            GridPeople.Update();
        }

        private void GridPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 0)
            {
                if (int.TryParse(GridPeople.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id))
                {
                    using (FrmBasic frm = new FrmBasic(DaoPeople, id))
                    {
                        frm.ShowDialog();
                        Load_GripPeople();
                    }
                }
            }
        }
    }
}