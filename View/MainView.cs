using PhoneSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSystem.View
{
    public partial class MainView : Form
    {
        MainController mainController = new MainController();

        public MainView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var Username = UsernameTextBox.Text;
            var Password = PasswordTextBox.Text;
            var IsRegistered = mainController.CheckIsRegistered(Username, Password);
            if (IsRegistered)
            {
                LoginView loginView = new LoginView();
                loginView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterView ViewInstance = new RegisterView();
            ViewInstance.Show();
            this.Hide();
        }
    }
}
