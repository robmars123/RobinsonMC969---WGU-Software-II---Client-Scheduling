using Client_Scheduler.Models;
using Client_Scheduler.ViewModels;
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
    public partial class AppointmentStatusReport : Form
    {
        private MainForm mainForm;
        private User loggedInUser;
        public AppointmentStatusReport(MainForm _mainForm, User _loggedInUser)
        {
            mainForm = _mainForm;
            loggedInUser = _loggedInUser;
            InitializeComponent();
        }

        private void AppointmentStatusReport_Load(object sender, EventArgs e)
        {
            var statusReportList = GetAppointmentStatusReports(Service.GetAppointments(loggedInUser).Result.ToList());
            dataGridViewStatusReport.DataSource = statusReportList;
            foreach (DataGridViewRow row in dataGridViewStatusReport.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            //Lambda expression is used to search records having "Complete" status and count them.
            labelCompletedTotal.Text = statusReportList.Where(appt => appt.Status == "Complete").Count().ToString();
            //Lambda expression is used to search records having "Scheduled" status and count them.
            labelUpcomingTotal.Text = statusReportList.Where(appt => appt.Status == "Scheduled").Count().ToString();
        }

        private List<AppointmentStatusListReport> GetAppointmentStatusReports(List<Appointment> appointments)
        {
            List<AppointmentStatusListReport> statusReports = new List<AppointmentStatusListReport>();
            foreach (var appt in appointments)
            {
                statusReports.Add(new AppointmentStatusListReport
                {
                    CustomerName = appt.GetCustomerName(),
                    Start = DateTime.Parse(Service.ConvertToTimeZone(appt.start.ToString())),
                    Status = (DateTime.Parse(Service.ConvertToTimeZone(appt.start.ToString())) < DateTime.Now) ? "Complete" : "Scheduled"
                });
            }
            return statusReports;
        }
    }
}
