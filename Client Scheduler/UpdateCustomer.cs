using Client_Scheduler.Models;
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Client_Scheduler
{
    public partial class UpdateCustomer : Form
    {
        private MainForm mainForm;
        private Customer customer = new Customer();
        public UpdateCustomer()
        {
            InitializeComponent();
        }
        public UpdateCustomer(MainForm _mainForm, Customer _selectedCustomer)
        {
            mainForm = _mainForm;
            customer = _selectedCustomer;
            InitializeComponent();
        }
        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            textBoxName.Text = customer.customerName;
            textBoxAddress.Text = customer.address.address;
            textBoxPhone.Text = customer.address.phone;
            textBoxZip.Text = customer.address.postalCode;
            textBoxCity.Text = customer.address.city.city;
            textBoxCountry.Text = customer.address.city.country.country;
            if (customer.active)
                radioButtonActiveYes.Checked = true;
            else
                radioButtonActiveNo.Checked = true;
        }

        private void UpdateCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                 string.IsNullOrEmpty(textBoxAddress.Text) ||
            string.IsNullOrEmpty(textBoxPhone.Text) ||
            string.IsNullOrEmpty(textBoxCity.Text) ||
            string.IsNullOrEmpty(textBoxZip.Text) ||
            string.IsNullOrEmpty(textBoxCountry.Text))
                //can be moved to ExceptionControl class for error handling messages.
                MessageBox.Show("Please fill in required fields.", "Error");
            else
            {
                customer.customerName = textBoxName.Text;
                customer.address.address = textBoxAddress.Text;
                customer.address.phone = textBoxPhone.Text;
                customer.address.city.city = textBoxCity.Text;
                customer.address.postalCode = textBoxZip.Text;
                customer.address.city.country.country = textBoxCountry.Text;

                if (radioButtonActiveYes.Checked)
                    customer.active = true;
                else
                    customer.active = false;

                Service.UpdateCustomer(customer);
            }
            Close();
            mainForm.RefreshMainscreen();
        }
    }
}
