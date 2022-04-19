using System;
using System.Windows.Forms;
using DAO;
namespace WinForm.Forms
{
    public partial class FrmBasic : Form
    {
        public int Id { get; private set; }
        public DaoPeople DaoPeople { get; private set; }
        public FrmBasic(DaoPeople daoPeople)
        {
            InitializeComponent();
            DaoPeople = daoPeople;
        }

        public FrmBasic(DaoPeople daoPeople, int id)
        {
            InitializeComponent();
            DaoPeople = daoPeople;
            Id = id;
        }

        private void FrmBasic_Load(object sender, EventArgs e)
        {           
            if (Id > 0)
            {
                CrudControl.SetModel(DaoPeople.Find(Id));
            }
            CrudControl.OnButtonEndEvent += CrudControl_OnButtonEndEvent;
            CrudControl.OnButtonActionEvent += CrudControl_OnButtonActionEvent;
        }

        private void CrudControl_OnButtonActionEvent(Models.People people)
        {
            if (people.Id  == 0)
            {
                DaoPeople.Insert(people);
            }
            else if (people.Id > 0)
            {
                DaoPeople.Update(people);
            }
            Close();
        }

        private void CrudControl_OnButtonEndEvent()
        {
            Close();
        }
    }
}
