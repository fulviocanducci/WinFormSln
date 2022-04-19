using System;
using System.Windows.Forms;

namespace WinForm.Forms
{
    public partial class FrmBasic : Form
    {
        public FrmBasic()
        {
            InitializeComponent();
        }

        private void FrmBasic_Load(object sender, EventArgs e)
        {
            CrudControl.OnButtonEndEvent += CrudControl_OnButtonEndEvent;
            CrudControl.OnButtonActionEvent += CrudControl_OnButtonActionEvent;
        }

        private void CrudControl_OnButtonActionEvent(Models.People people)
        {
            Close();
        }

        private void CrudControl_OnButtonEndEvent()
        {
            Close();
        }
    }
}
