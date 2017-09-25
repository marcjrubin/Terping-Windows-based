using System;
using System.Windows.Forms;
using InterpreterBookingSystem.Business.InterpreterMgr;
using InterpreterBookingSystem.Domain.Interpreters;

namespace InterpreterBookingSystem.Forms
{
    public partial class InterpreterForm : Form
    {
        public InterpreterForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Interpreter terp = new Interpreter();
            terp.Name = txtName.Text;
            terp.Address1 = txtAddressOne.Text;
            terp.Address2 = txtAddressTwo.Text;
            terp.City = txtCity.Text;
            terp.State = txtState.Text;
            terp.Zip = txtZip.Text;
            terp.Phone = txtPhone.Text;
            terp.Email = txtEmail.Text;
            terp.HighestLevelCertification = txtCertification.Text;

            int i = 0;
            bool isNumeric = int.TryParse(txtYears.Text, out i);

            if (isNumeric == true)
            {
                terp.YearsOfExperience = Int32.Parse(txtYears.Text);
            }
            else
            {
                MessageBox.Show("You have entered non-numerical character in Years of Experience textbox. Enter numeric character.");
                txtYears.Text = "";
                return;
            }

            InterpreterMgr terpMgr = new InterpreterMgr();
            terpMgr.StoreNewInterpreter(terp);

            AssignmentForm assign = (AssignmentForm) Owner;
            assign.UpdateInterpreterFromInterpreterForm(txtName.Text);

            AfterTheSave();

            Close();
        }

        private void AfterTheSave()
        {
            MessageBox.Show("Interpreter Information Saved");

            txtName.Text = "";
            txtAddressOne.Text = "";
            txtAddressTwo.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtYears.Text = "";
            txtCertification.Text = "";
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            Interpreter terp = new Interpreter();
            InterpreterMgr terpMgr = new InterpreterMgr();
            terp = terpMgr.RetrieveInterpreter(terp);

            txtName.Text = terp.Name;
            txtAddressOne.Text = terp.Address1;
            txtAddressTwo.Text = terp.Address2;
            txtCity.Text = terp.City;
            txtState.Text = terp.State;
            txtZip.Text = terp.Zip;
            txtPhone.Text = terp.Phone;
            txtEmail.Text = terp.Email;
            txtYears.Text = terp.YearsOfExperience.ToString();
            txtCertification.Text = terp.HighestLevelCertification;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
