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
    public partial class AppointmentsByMonthReport : Form
    {
        private MainForm mainForm;
        private User loggedInUser;
        public AppointmentsByMonthReport(MainForm _mainForm, User _loggedInUser)
        {
            mainForm = _mainForm;
            loggedInUser = _loggedInUser;
            InitializeComponent();
        }

        private void AppointmentsByMonthReport_Load(object sender, EventArgs e)
        {
            dataGridViewTypesByMonthReport.DataSource = Service.GetTypesByMonthReport(loggedInUser);
        }

        private void AppointmentsByMonthReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
