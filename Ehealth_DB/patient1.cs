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
    public partial class patient1 : Form
    {
        public static int dept;
        public static List<string> date_list = new List<string>();

        public patient1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dept = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dept = 2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dept = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dept = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dept = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {            
            if (monthCalendar1.SelectionRange.Start == monthCalendar1.SelectionRange.End)
            {
                date_list.Add(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));

                //MessageBox.Show(monthCalendar1.SelectionRange.Start.ToString());
                // "2024-05-15 오전 12:00:00" 형태

                //date_temp = monthCalendar1.SelectionRange.Start.ToString();                            

                //DateTime dateValue = new DateTime(2008, 6, 11);
                //date_list.Add((int)dateValue.DayOfWeek);
                //Console.WriteLine();
            }

            //textBox1.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            else
            {
                date_list.Add(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                date_list.Add(monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd"));

                /*
                 textBox1.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "~"
                    + monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd");
                 */
            }

            patient2 patient = new patient2();
            patient.Tag = this;
            patient.Show();
            this.Hide();
        }
    }
}
