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
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user2 user2 = new user2();
            user2.Tag = this;
            user2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user3 user3 = new user3();
            user3.Tag = this;
            user3.Show();
            this.Hide();
        }
    }
}
