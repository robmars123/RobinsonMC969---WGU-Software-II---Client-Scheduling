using Client_Scheduler.Models;
using Client_Scheduler.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Scheduler
{
    public partial class MainForm : Form
    {
        public Login loginForm;
        public AddCustomer addCustomer;
        private static User loggedInUser;
        public MainForm(User _loggedInUser)
        {
            loggedInUser = _loggedInUser;
            InitializeComponent();
            labelLoggedInUser.Text = loggedInUser.userName + "!";
            //display Appointments with selected Columns and alias
            dataGridViewAppointments.DataSource = Service.AppointmentsCalendarList(GetAppointmentListAsync().Result.ToList());

            //notify user
            FiftenMinuteReminderNotification(dataGridViewAppointments);
            //display Customer List
            dataGridViewCustomers.DataSource = GetCustomersAsync().Result.ToList();
        }
        static public void FiftenMinuteReminderNotification(DataGridView appointments)
        {
            foreach (DataGridViewRow row in appointments.Rows)
            {
                var rowColumnStart = row.DataBoundItem as AppointmentsCalendar;

                var now = DateTime.UtcNow;
                var start = DateTime.Parse(rowColumnStart.StartDate).ToUniversalTime();
                var nowBeforeApptStart = now - start;
                if (nowBeforeApptStart.TotalMinutes >= -15 && nowBeforeApptStart.TotalMinutes < 1)
                {
                    MessageBox.Show($"Reminder: You have an incoming meeting with {rowColumnStart.User} at {rowColumnStart.StartDate}.");
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private static async Task<List<Appointment>> GetAppointmentListAsync()
        {
            return await Service.GetAppointments(loggedInUser);
        }

        private static async Task<List<Customer>> GetCustomersAsync()
        {
            return await Service.GetCustomers();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            addCustomer = new AddCustomer(this, loggedInUser);
            addCustomer.Show();
        }

        public void RefreshMainscreen()
        {
            dataGridViewAppointments.DataSource = null;
            dataGridViewCustomers.DataSource = null;

            dataGridViewAppointments.DataSource = Service.AppointmentsCalendarList(GetAppointmentListAsync().Result.ToList());
            dataGridViewCustomers.DataSource = GetCustomersAsync().Result.ToList();

            dataGridViewAppointments.ClearSelection();
            dataGridViewCustomers.ClearSelection();
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = new Customer();
            foreach (DataGridViewRow item in this.dataGridViewCustomers.SelectedRows)
            {
                if (item.Selected)
                {
                    selectedCustomer = item.DataBoundItem as Customer;

                    selectedCustomer.address = Service.GetAddressQuery((int)selectedCustomer.addressId);
                    selectedCustomer.address.city = Service.GetCity((int)selectedCustomer.address.cityId);
                    selectedCustomer.address.city.country = Service.GetCountry((int)selectedCustomer.address.city.countryId);
                }
            }

            if (selectedCustomer.customerId <= 0)
            {
                string message = "Please select something to modify.";
                MessageBox.Show(message);
                return;
            }
            else
            {
                UpdateCustomer updateCustomer = new UpdateCustomer(this, selectedCustomer);
                updateCustomer.Show();
            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = new Customer();
            foreach (DataGridViewRow item in this.dataGridViewCustomers.SelectedRows)
            {
                if (item.Selected)
                    selectedCustomer = item.DataBoundItem as Customer;

                selectedCustomer.address = Service.GetAddressQuery((int)selectedCustomer.addressId);
                selectedCustomer.address.city = Service.GetCity((int)selectedCustomer.address.cityId);
                selectedCustomer.address.city.country = Service.GetCountry((int)selectedCustomer.address.city.countryId);
            }

            if (selectedCustomer.customerId > 0)
                Service.DeleteCustomer(selectedCustomer);
            else
                MessageBox.Show("Please select a customer to delete.");

            RefreshMainscreen();
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm = new AddAppointment(this, loggedInUser);
            addAppointmentForm.Show();
        }

        private void buttonUpdateAppointment_Click(object sender, EventArgs e)
        {
            AppointmentsCalendar selectedAppointment = new AppointmentsCalendar();
            foreach (DataGridViewRow item in this.dataGridViewAppointments.SelectedRows)
            {
                if (item.Selected)
                    selectedAppointment = item.DataBoundItem as AppointmentsCalendar;
            }

            if (selectedAppointment.AppointmentId > 0)
            {
                UpdateAppointment updateAppointmentForm = new UpdateAppointment(this, selectedAppointment.appointment, loggedInUser);
                updateAppointmentForm.Show();
                radioButtonAllAppointments.Checked = true;
            }
            else
                MessageBox.Show("Please select an appointment to update.");

            RefreshMainscreen();
        }

        private void buttonDeleteAppointment_Click(object sender, EventArgs e)
        {
            AppointmentsCalendar selectedAppointment = new AppointmentsCalendar();
            foreach (DataGridViewRow item in this.dataGridViewAppointments.SelectedRows)
            {
                if (item.Selected)
                    selectedAppointment = item.DataBoundItem as AppointmentsCalendar;
            }

            if (selectedAppointment.AppointmentId > 0)
            {
                Service.DeleteAppointment(selectedAppointment.appointment);
            }
            else
                MessageBox.Show("Please select an appointment to delete.");

            RefreshMainscreen();
        }

        private void radioButtonCurrentMonth_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewAppointments.DataSource = Service.AppointmentsCalendarList(Service.GetAppointments(loggedInUser).Result.Where(apps => apps.start.Month == DateTime.Now.Month).ToList());
        }

        private void radioButtonCurrentWeek_CheckedChanged(object sender, EventArgs e)
        {
            var firstDateInWeek = FirstDateInWeek(DateTime.Now).AddDays(1);
            var lastDateInWeek = firstDateInWeek.AddDays(5);
            var list = Service.GetAppointments(loggedInUser).Result.Where(apps => apps.start > firstDateInWeek && apps.end < lastDateInWeek).ToList(); ;
            dataGridViewAppointments.DataSource = Service.AppointmentsCalendarList(list);
        }
        public static DateTime FirstDateInWeek(DateTime dt)
        {
            while (dt.DayOfWeek != System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
                dt = dt.AddDays(-1);
            return dt;
        }

        private void radioButtonAllAppointments_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewAppointments.DataSource = Service.AppointmentsCalendarList(Service.GetAppointments(loggedInUser).Result.ToList());
        }

        private void buttonApptByMonth_Click(object sender, EventArgs e)
        {
            AppointmentsByMonthReport typesByMonth = new AppointmentsByMonthReport(this, loggedInUser);
            typesByMonth.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultantScheduleAppointments consultantScheduleAppointments = new ConsultantScheduleAppointments(this, loggedInUser);
            consultantScheduleAppointments.Show();
        }

        private void buttonApptStatusReport_Click(object sender, EventArgs e)
        {
            AppointmentStatusReport appointmentStatusReport = new AppointmentStatusReport(this, loggedInUser);
            appointmentStatusReport.Show();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                this.Visible = false;
                login.Show();
                Logs.LogOutActivity(loggedInUser);
            }
        }
    }
}
