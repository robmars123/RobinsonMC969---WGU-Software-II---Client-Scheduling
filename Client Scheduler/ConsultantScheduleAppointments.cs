using Client_Scheduler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Scheduler
{
    public partial class ConsultantScheduleAppointments : Form
    {
        private MainForm mainForm;
        private User loggedInUser;
        public ConsultantScheduleAppointments(MainForm _mainForm, User _loggedInUser)
        {
            mainForm = _mainForm;
            loggedInUser = _loggedInUser;
            InitializeComponent();
        }

        private void ConsultantScheduleAppointments_Load(object sender, EventArgs e)
        {
            var appointmentList = Service.AppointmentsCalendarList(Service.GetAppointments(loggedInUser).Result.ToList());
            dataGridViewConsultantSchedules.DataSource = appointmentList;
            foreach (DataGridViewRow row in dataGridViewConsultantSchedules.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            labelTotalUserAppointments.Text = appointmentList.Count().ToString();
            //This Lambda expression selects DISTINCT list of CustomerID and then Count before converting to string. Display total.
            labelTotalCustomersScheduled.Text = appointmentList.Select(cust=>cust.CustomerId).Distinct().ToList().Count().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalCustomersScheduled_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalUserAppointments_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
