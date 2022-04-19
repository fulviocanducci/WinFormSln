using FluentValidation.Results;
using Models;
using Models.Extensions;
using Models.Validations;
using System;
using System.Windows.Forms;
namespace WinForm.Components
{
    public partial class CrudControl : UserControl
    {
        public delegate void OnButtonAction(People people);
        public event OnButtonAction OnButtonActionEvent;

        public delegate void OnButtonEnd();
        public event OnButtonEnd OnButtonEndEvent;

        public People People { get; private set; }
        public PeopleValidator PeopleValidator { get; private set; }

        public CrudControl()
        {
            InitializeComponent();
            People = new People();
            PeopleValidator = new PeopleValidator();
            InitialValues(People);
        }

        public void SetModel(People people)
        {
            People = people;
            InitialValues(People);
        }

        private void InitialValues(People people)
        {
            TxtId.Text = "0";
            TxtId.ReadOnly = true;
            TxtName.Text = "";
            TxtSalary.Text = "0,00";
            MskCreatedAt.Text = "";
            ChkActive.Checked = true;
            BtnAction.Text = "Inserir";
            if (people.Id > 0)
            {
                TxtId.Text = people.Id.ToString();
                TxtName.Text = people.Name;
                TxtSalary.Text = people.Salary.ToString("N2");
                if (people.CreatedAt.HasValue)
                {
                    MskCreatedAt.Text = people.CreatedAt.Value.ToString("dd/MM/yyyy");
                }
                ChkActive.Checked = people.Active;
                BtnAction.Text = "Salvar";
            }
        }

        private void BtnAction_Click(object sender, System.EventArgs e)
        {
            People = new People
            {
                Id = int.Parse(TxtId.Text),
                Name = TxtName.Text,
                Salary = 0
            };
            if (decimal.TryParse(TxtSalary.Text, out decimal resultSalary))
            {
                People.Salary = resultSalary;
            }
            People.CreatedAt = null;
            if (DateTime.TryParse(MskCreatedAt.Text, out DateTime resultCreatedAt))
            {
                People.CreatedAt = resultCreatedAt;
            }
            People.Active = ChkActive.Checked;
            ValidationResult result = PeopleValidator.Validate(People);
            if (result.IsValid)
            {
                OnButtonActionEvent(People);
            }
            else
            {
                MessageBox.Show(result.Errors.ErrorsToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEnd_Click(object sender, System.EventArgs e)
        {
            OnButtonEndEvent();
        }
    }
}
