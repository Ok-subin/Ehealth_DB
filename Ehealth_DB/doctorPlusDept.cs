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
    public partial class doctorPlusDept : Form
    {
        public static int dt_Dept;
        public doctorPlusDept()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                dt_Dept = 1;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                dt_Dept = 2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                dt_Dept = 3;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                dt_Dept = 4;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                dt_Dept = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctorPlusDate main = new doctorPlusDate();
            main.Tag = this;
            main.Show();
            this.Hide();
        }
    }
}
