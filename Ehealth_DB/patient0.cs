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
    public partial class patient0 : Form
    {
        public patient0()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient1 patient = new patient1();
            patient.Tag = this;
            patient.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patient3 patient = new patient3();
            patient.Tag = this;
            patient.Show();
            this.Hide();
        }
    }
}
