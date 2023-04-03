using Client_Scheduler.Models;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Client_Scheduler
{
    public partial class Login : Form
    {
        private CultureInfo ci = CultureInfo.CurrentCulture;
        private User loggedInUser;
        public Login()
        {
            loggedInUser = new User();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            GetUserMachineLanguage();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            //this will be null of no user returned
            loggedInUser = Service.GetUser(userName, password);

            try
            {
                if (loggedInUser == null || loggedInUser.userId == 0)
                {
                    var msg = (ci.TwoLetterISOLanguageName == "es") ? "El nombre de usuario y la contraseña no coincidían." : "The username and password did not match.";

                    MessageBox.Show(msg, "Error");
                    labelErrorMessage.ForeColor = Color.Red;
                    labelErrorMessage.Text = "";
                }
                else
                {
                    labelErrorMessage.Text = (ci.TwoLetterISOLanguageName == "es") ? "Iniciado sesión con éxito." : "Logged in successfully.";
                    labelErrorMessage.ForeColor = Color.Green;

                    //Log the user activity everytime user logs in.
                    Logs.LogInActivity(loggedInUser);
                    MainForm mainForm = new MainForm(loggedInUser);
                    mainForm.loginForm = this;
                    this.Hide();
                    mainForm.Show();
                }
            }catch(Exception ex)
            {

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetUserMachineLanguage()
        {
            if (ci.TwoLetterISOLanguageName == "es")
            {
                this.Text = "Acceso";
                labelLogin.Text = "Acceso";
                labelUsername.Text = "Nombre de usuario";
                labelPassword.Text = "Contraseña";
                buttonLogin.Text = "Acceso";
                buttonCancel.Text = "Cancelar";
            }
        }

        private void labelErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
