using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ehealth_DB
{
    public partial class doctor2 : Form
    {
        public static string[] Dt_date = new string[10];
        public static int count;
        public static int[] equals = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public doctor2()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            count = doctor1.totalCount;
            int[] dateIndex = doctor1.dateIndex;

            string temp2, sqlQuery;
            MySqlDataReader myReader2;
            MySqlCommand readDate;

            // index에 따른 진료일 목록 Dt_date에 저장
            for (int i = 0; i < count; i++)
            {
                sqlQuery = "SELECT day FROM date_table WHERE dateIndex = ";
                sqlQuery += dateIndex[i];

                readDate = new MySqlCommand(sqlQuery, connection);
                myReader2 = readDate.ExecuteReader();

                if (myReader2.Read())
                {
                    temp2 = Convert.ToString(myReader2.GetString(0));
                    Dt_date[i] = temp2;

                    myReader2.Dispose();
                }
            }
            connection.Close();

            // 의사가 진료하는 요일의 글씨체 다르게 하는 코드
            // input 1
            bool find = false;
            string input = input1.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                input1.ForeColor = Color.Red;
                input1.Font = new Font(input1.Font, FontStyle.Bold);
                equals[0] = 1;
            }

            // input 2
            find = false;
            input = input2.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                input2.ForeColor = Color.Red;
                input2.Font = new Font(input2.Font, FontStyle.Bold);
                equals[1] = 1;
            }

            // input 3
            find = false;
            input = input3.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                input3.ForeColor = Color.Red;
                input3.Font = new Font(input3.Font, FontStyle.Bold);
                equals[2] = 1;
            }

            // input 4
            find = false;
            input = input4.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                input4.ForeColor = Color.Red;
                input4.Font = new Font(input4.Font, FontStyle.Bold);
                equals[3] = 1;
            }

            // input 5
            find = false;
            input = input5.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                input5.ForeColor = Color.Red;
                input5.Font = new Font(input5.Font, FontStyle.Bold);
                equals[4] = 1;
            }

            // input 6
            find = false;
            input = input6.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                input6.ForeColor = Color.Red;
                input6.Font = new Font(input6.Font, FontStyle.Bold);
                equals[5] = 1;
            }

            // input 7
            find = false;
            input = input7.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                input7.ForeColor = Color.Red;
                input7.Font = new Font(input7.Font, FontStyle.Bold);
                equals[6] = 1;
            }

            // input 8
            find = false;
            input = input8.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                input8.ForeColor = Color.Red;
                input8.Font = new Font(input8.Font, FontStyle.Bold);
                equals[7] = 1;
            }

            // input 9
            find = false;
            input = input9.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                input9.ForeColor = Color.Red;
                input9.Font = new Font(input9.Font, FontStyle.Bold);
                equals[8] = 1;
            }

            // input 10
            find = false;
            input = input10.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                input10.ForeColor = Color.Red;
                input10.Font = new Font(input10.Font, FontStyle.Bold);
                equals[9] = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctor1 doctor = new doctor1();

            doctor.Tag = this;
            doctor.Show();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctor3 doctor = new doctor3();

            doctor.Tag = this;
            doctor.Show();
            this.Hide();

        }
    }
}
