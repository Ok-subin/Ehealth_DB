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
    public partial class manager1 : Form
    {
        public manager1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager2 manager = new manager2();
            manager.Tag = this;
            manager.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manager3 manager = new manager3();
            manager.Tag = this;
            manager.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manager4 manager = new manager4();
            manager.Tag = this;
            manager.Show();
            this.Hide();
        }
    }
}
