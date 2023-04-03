using Client_Scheduler.Models;
using System;
using System.Windows.Forms;

namespace Client_Scheduler
{
    public partial class AddCustomer : Form
    {
        private MainForm mainForm;
        private User loggedInUser;
        public AddCustomer(MainForm _mainForm, User _loggedInUser)
        {
            mainForm = _mainForm;
            loggedInUser = _loggedInUser;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxPhone.Text) ||
                string.IsNullOrEmpty(textBoxAddress.Text) ||
                string.IsNullOrEmpty(textBoxCity.Text) ||
                string.IsNullOrEmpty(textBoxZip.Text) ||
                string.IsNullOrEmpty(textBoxCountry.Text) ||
                (radioButtonActiveYes.Checked == false && radioButtonActiveNo.Checked == false))
            {
                //can be moved to ExceptionControl class for error handling messages.
                MessageBox.Show("Please fill in required fields.");
            }
            else
            {
                //using property navigation to save data for the dependent entities.
                Customer customer = new Customer()
                {
                    customerName = textBoxName.Text,
                    createdBy = loggedInUser.userName,
                    lastUpdateBy = loggedInUser.userName,
                    active = radioButtonActiveYes.Checked ? true : false,
                    address = new Address()
                    {
                        address = textBoxAddress.Text,
                        postalCode = textBoxZip.Text,
                        phone = textBoxPhone.Text,
                        createdBy = loggedInUser.userName,
                        lastUpdateBy = loggedInUser.userName,
                        city = new City()
                        {
                            city = textBoxCity.Text,
                            createdBy = loggedInUser.userName,
                            lastUpdateBy = loggedInUser.userName,
                            country = new Country()
                            {
                                country = textBoxCountry.Text,
                                createdBy = loggedInUser.userName,
                                lastUpdateBy = loggedInUser.userName
                            }

                        }
                    }
                };
                //save to database
                Service.AddCustomer(customer);
            }

            mainForm.RefreshMainscreen();
            Close();
            mainForm.Show();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
