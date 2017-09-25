using System;
using System.Windows.Forms;
using InterpreterBookingSystem.Domain.BusinessClients;
using InterpreterBookingSystem.Business.BusinessClientManager;

namespace InterpreterBookingSystem.Forms
{
    public partial class BusinessClientForm : Form
    {
        public BusinessClientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BusinessClient bc = new BusinessClient();
            bc.CompanyName = txtCompanyName.Text;
            bc.PointOfContact = txtPointOfContact.Text;
            bc.Address1 = txtAddressOne.Text;
            bc.Address2 = txtAddressTwo.Text;
            bc.City = txtCity.Text;
            bc.State = cbxState.Text;
            bc.Zip = txtZip.Text;
            bc.Phone = txtPhone.Text;
            bc.Email = txtEmail.Text;

            BusinessClientMgr bcMgr = new BusinessClientMgr();
            bcMgr.StoreNewBusinessClient(bc);

            AssignmentForm assignForm = (AssignmentForm) Owner;
            assignForm.UpdateBusinessClientFromBusinessClientForm(txtCompanyName.Text, txtPointOfContact.Text, txtAddressOne.Text,txtAddressTwo.Text,txtCity.Text,cbxState.Text, txtZip.Text, txtPhone.Text, txtEmail.Text);

            AfterTheSave();
            
            Close();
        }

        private void AfterTheSave()
        {
            MessageBox.Show("Business Client Saved.");
            
            txtCompanyName.Text = "";
            txtPointOfContact.Text = "";
            txtAddressOne.Text = "";
            txtAddressTwo.Text = "";
            txtCity.Text = "";
            cbxState.Text = "";
            txtZip.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            BusinessClient bc = new BusinessClient();
            BusinessClientMgr bcMgr = new BusinessClientMgr();
            bc = bcMgr.RetrieveBusinessClient(bc);

            txtCompanyName.Text = bc.CompanyName;
            txtPointOfContact.Text = bc.PointOfContact;
            txtAddressOne.Text = bc.Address1;
            txtAddressTwo.Text = bc.Address2;
            txtCity.Text = bc.City;
            cbxState.Text = bc.State;
            txtZip.Text = bc.Zip;
            txtPhone.Text = bc.Phone;
            txtEmail.Text = bc.Email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
