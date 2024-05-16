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
    public partial class doctor4 : Form
    {
        public doctor4()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            string findSql = "SELECT Dt_name FROM doctor_table WHERE Dt_id = '";
            findSql += Login.inputId;
            findSql += "'";

            MySqlCommand cmd = new MySqlCommand(findSql, connection);
            string dt_name = Convert.ToString(cmd.ExecuteScalar());


            // 환자명 / 주민등록번호 / 진료일시 (yyyy-MM-dd 오전/오후)
            string findDt = "SELECT Pt_name, date, time FROM reservation_table WHERE Dt_name = '";
            findDt += dt_name;
            findDt += "'";

            cmd.Dispose();

            cmd = new MySqlCommand(findDt, connection);
            MySqlDataReader reader = cmd.ExecuteReader();


            List<string> name_list = new List<string>();
            List<string> date_list = new List<string>();
            List<string> time_list = new List<string>();

            while (reader.Read())
            {
                name_list.Add(reader["Pt_name"].ToString());
                date_list.Add(reader["date"].ToString());
                time_list.Add(reader["time"].ToString());
                //pt_name = reader["Pt_name"].ToString();
                //findDt = "SELECT Pt_number FROM patient_table WHERE Pt_name = '";
                //findDt += pt_name;
                //findDt += "'";

                //cmd = new MySqlCommand(findDt, connection);
                //pt_number = Convert.ToInt32(cmd.ExecuteScalar());

                //dataGridView1.Rows.Add(pt_name, pt_number.ToString(), reader["date"].ToString() + " " + reader["time"].ToString());
            }           
            reader.Close();

            int pt_number;
            for (int i = 0; i < name_list.Count; i++)
            {
                findDt = "SELECT Pt_number FROM patient_table WHERE Pt_name = '";
                findDt += name_list[i];
                findDt += "'";

                cmd = new MySqlCommand(findDt, connection);
                pt_number = Convert.ToInt32(cmd.ExecuteScalar());

                dataGridView1.Rows.Add(name_list[i], pt_number.ToString(), date_list[i] + " " + time_list[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctor1 Dt_day = new doctor1();

            if (Dt_day != null)
            {
                Dt_day.Tag = this;
                Dt_day.Show();
                this.Hide();
            }
        }
    }
} 
