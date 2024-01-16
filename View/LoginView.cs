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
    public partial class LoginView : Form
    {
        MainController MainController = new MainController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = MainController.GetAllUsers();
        }
    }
}
