using Client_Scheduler.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Client_Scheduler
{
    public partial class UpdateAppointment : Form
    {
        MainForm mainForm;
        Appointment selectedAppointment;
        User loggedInUser;
        public UpdateAppointment(MainForm _mainForm, Appointment _selectedAppointment, User _loggedInUser)
        {
            mainForm = _mainForm;
            selectedAppointment = _selectedAppointment;
            loggedInUser = _loggedInUser;
            InitializeComponent();
        }

        private void UpdateAppointment_Load(object sender, EventArgs e)
        {
            comboBoxUserID.DataSource = Service.GetUsersList();
            comboBoxCustomerIdAndName.DataSource = Service.GetCustomerIdAndNameList();
            //get selected customer from _selectedAppointment object reference using customerId and grab first or default record.
            var selectedCustomer = Service.GetCustomers().Result.Where(cust => cust.customerId == selectedAppointment.customerId).FirstOrDefault();
            comboBoxCustomerIdAndName.Text = "ID: " + selectedCustomer.customerId + " - " + selectedCustomer.customerName;

            //get selected user for this appointment
            var selectedUser = Service.GetUsersList().Where(u => u.Contains(selectedAppointment.userId.ToString())).FirstOrDefault();
            comboBoxUserID.Text = selectedUser;
            dateTimePickerStart.Value = selectedAppointment.start;
            dateTimePickerEnd.Value = selectedAppointment.end;
            textBoxType.Text = selectedAppointment.type;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
            {
                //can be moved to ExceptionControl class for error handling messages.
                MessageBox.Show("End time is earlier than start time. Please try again.", "Error");
                return;
            }

            selectedAppointment.customerId = int.Parse(comboBoxCustomerIdAndName.Text.Substring(3, 2).Trim());
            selectedAppointment.type = textBoxType.Text;
            selectedAppointment.start = DateTime.Parse(dateTimePickerStart.Value.ToUniversalTime().ToString("u"));
            selectedAppointment.end = DateTime.Parse(dateTimePickerEnd.Value.ToUniversalTime().ToString("u"));
            selectedAppointment.userId = int.Parse(comboBoxUserID.Text.Substring(3, 2).Trim());
            selectedAppointment.lastUpdateBy = loggedInUser.userName;

            try
            {
                if (!Service.IsOutsideOfBusinessHours(selectedAppointment.start, selectedAppointment.end))
                {
                    Service.UpdateAppointment(selectedAppointment);
                    mainForm.RefreshMainscreen();
                    Close();
                    mainForm.Show();
                }
                else
                    throw new ExceptionControl();
            }
            catch (ExceptionControl ex)
            {
                ex.OutOfBusinessHours();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
