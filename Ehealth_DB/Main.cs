using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ehealth_DB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Tag = this;
            login.Show();
            this.Hide();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Tag = this;
            signup.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
