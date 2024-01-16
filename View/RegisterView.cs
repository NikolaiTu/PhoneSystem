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
    public partial class RegisterView : Form
    {

        MainController MainController = new MainController();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void CancelRegisterButton_Click(object sender, EventArgs e)
        {
            MainView MainViewInstance = new MainView();
            MainViewInstance.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var username = UsernameTextBox.Text;
            var password = PasswordTextBox.Text;

            if (username == null || password == null)
            {
                MessageBox.Show("username or password cant be empty");
            }
            else
            {
                MessageBox.Show("guten, now login");
                MainController.RegisterUser(username, password);
                MainView bob = new MainView();
                bob.Show();
                this.Hide();
            }
        }
    }
}
