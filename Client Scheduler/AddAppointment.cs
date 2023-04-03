using Client_Scheduler.Models;
using System;
using System.Windows.Forms;

namespace Client_Scheduler
{
    public partial class AddAppointment : Form
    {
        MainForm mainForm;
        User loggedUser;
        public AddAppointment(MainForm _mainForm, User _loggedUser)
        {
            mainForm = _mainForm;
            loggedUser = _loggedUser;
            InitializeComponent();
        }

        private void AddAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            comboBoxUserID.DataSource = Service.GetUsersList();
            comboBoxCustomerIdAndName.DataSource = Service.GetCustomerIdAndNameList();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxType.Text) ||
                string.IsNullOrEmpty(comboBoxCustomerIdAndName.Text) ||
                string.IsNullOrEmpty(dateTimePickerStart.Text) ||
                string.IsNullOrEmpty(dateTimePickerEnd.Text))
            {
                //can be moved to ExceptionControl class for error handling messages.
                MessageBox.Show("Please fill in required fields.", "Error");
            }
            else
            {
                if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
                {
                    //can be moved to ExceptionControl class for error handling messages.
                    MessageBox.Show("End time is earlier than start time. Please try again.", "Error");
                    return;
                }
                Appointment appointment = new Appointment();
                appointment.customerId = int.Parse(comboBoxCustomerIdAndName.Text.Substring(3, 2).Trim());
                appointment.type = textBoxType.Text;
                appointment.start = dateTimePickerStart.Value.ToUniversalTime();
                appointment.end = dateTimePickerEnd.Value.ToUniversalTime();
                appointment.userId = int.Parse(comboBoxUserID.Text.Substring(3, 2).Trim());
                appointment.createdBy = loggedUser.userName;
                appointment.lastUpdateBy = loggedUser.userName;

                try
                {
                    //check if there is conflict with existing appointment
                    if (!Service.HasConflictSchedule(appointment.start, appointment.end))
                    {
                        try
                        {
                            if (!Service.IsOutsideOfBusinessHours(appointment.start, appointment.end))
                            {
                                Service.AddAppointment(appointment);
                                mainForm.RefreshMainscreen();
                                Close();
                                mainForm.Show();
                            }
                            else
                                throw new ExceptionControl();
                        }
                        catch(ExceptionControl ex)
                        {
                            ex.OutOfBusinessHours();
                        }

                    }
                    else
                    {
                        throw new ExceptionControl();
                    }
                }
                catch(ExceptionControl ex)
                {
                    ex.OverlapAppointment();
                }
            }
        }
    }
}
