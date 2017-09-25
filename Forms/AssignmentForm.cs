using InterpreterBookingSystem.Domain.BusinessClients;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using InterpreterBookingSystem.Business.AssignmentManager;
using InterpreterBookingSystem.Business.BusinessClientManager;
using InterpreterBookingSystem.Business.InterpreterMgr;
using InterpreterBookingSystem.Domain.Assignment;
using InterpreterBookingSystem.Domain.Interpreters;

namespace InterpreterBookingSystem.Forms
{
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();
            RetrieveBusinessClient();
            RetrieveAssignment();
            RetrieveInterpreter();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            RetrieveAssignment();
        }

        private void RetrieveBusinessClient()
        {
            string storageFile = Path.Combine(Environment.CurrentDirectory, "BusinessClient.bin");
            FileInfo storageFileInfo = new FileInfo(storageFile);

            if (storageFileInfo.Exists == true)
            {
                BusinessClient bc = new BusinessClient();
                BusinessClientMgr bcMgr = new BusinessClientMgr();
                bc = bcMgr.RetrieveBusinessClient(bc);

                lblCompany.Text = bc.CompanyName;
                lblPointOfContact.Text = bc.PointOfContact;
                lblAddressOne.Text = bc.Address1;
                lblAddressTwo.Text = bc.Address2;
                lblCity.Text = bc.City;
                lblState.Text = bc.State;
                lblZip.Text = bc.Zip;
                lblPhone.Text = bc.Phone;
                lblEmail.Text = bc.Email;
            }
            else
            {
                lblCompany.Text = "File Not Found. Create A New File.";
            }
        }

        public void UpdateBusinessClientFromBusinessClientForm(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9)
        {
            lblCompany.Text = text1;
            lblPointOfContact.Text = text2;
            lblAddressOne.Text = text3;
            lblAddressTwo.Text = text4;
            lblCity.Text = text5;
            lblState.Text = text6;
            lblZip.Text = text7;
            lblPhone.Text = text8;
            lblEmail.Text = text9;
        }

        private void RetrieveInterpreter()
        {
            string storageFile = Path.Combine(Environment.CurrentDirectory, "Interpreter.bin");
            FileInfo storageFileInfo = new FileInfo(storageFile);

            if (storageFileInfo.Exists == true)
            {
                Interpreter terp = new Interpreter();
                InterpreterMgr terpMgr = new InterpreterMgr();
                terp = terpMgr.RetrieveInterpreter(terp);

                lblInterpreter.Text = terp.Name;
            }
            else
            {
                lblInterpreter.Text = "No Interpreter Found. Create A New Interpreter File.";
            }
        }

        public void UpdateInterpreterFromInterpreterForm(string text1)
        {
            lblInterpreter.Text = text1;
        }

        private void RetrieveAssignment()
        {
            string storageFile = Path.Combine(Environment.CurrentDirectory, "Assignment.bin");
            FileInfo storageFileInfo = new FileInfo(storageFile);

            if (storageFileInfo.Exists == true)
            {
                Assign assign = new Assign();
                AssignmentManager assignMgr = new AssignmentManager();
                assign = assignMgr.RetrieveAsssignment(assign);

                startDatePicker.Text = assign.StartDate;
                endDatePicker.Text = assign.EndDate;
                txtStartTime.Text = assign.StartTime;
                txtEndTime.Text = assign.EndTime;
            }
            else
            {
                MessageBox.Show("No Assignment Created. Please create a new assignment.");
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to close?", "Close Confirm",
                MessageBoxButtons.YesNo);

            if (dlgResult == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Assign assign = new Assign();
            assign.StartDate = startDatePicker.Text;
            assign.EndDate = endDatePicker.Text;
            assign.StartTime = txtStartTime.Text;
            assign.EndTime = txtEndTime.Text;

            AssignmentManager assignMgr = new AssignmentManager();
            assignMgr.StoreNewAssignment(assign);

            AfterTheSave();

            Refresh();
        }

        private void AfterTheSave()
        {
            MessageBox.Show("Assignment Saved", "Saved");

            DateTime today = DateTime.Today;
            startDatePicker.Text = today.ToString();
            endDatePicker.Text = today.ToString();

            txtStartTime.Text = "";
            txtEndTime.Text = "";
        }

        private void businessClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessClientForm bcForm = new BusinessClientForm();
            bcForm.Show(this);
        }

        private void interpreterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterpreterForm iForm = new InterpreterForm();
            iForm.Show(this);
        }

        private void clearFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            startDatePicker.Text = today.ToString();
            endDatePicker.Text = today.ToString();

            txtStartTime.Text = "";
            txtEndTime.Text = "";
        }
    }
}
