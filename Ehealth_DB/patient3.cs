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
    public partial class patient3 : Form
    {
        public patient3()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            // 의료진명 / 진료일시(yyyy-MM-dd 오전/오후) / 진료과
            string findSql = "SELECT Pt_name FROM patient_table WHERE Pt_id = '";
            findSql += Login.inputId;
            findSql += "'";

            MySqlCommand cmd = new MySqlCommand(findSql, connection);
            string pt_name = Convert.ToString(cmd.ExecuteScalar());


            string findDt = "SELECT Dt_name, date, time, dept FROM reservation_table WHERE Pt_name = '";
            findDt += pt_name; 
            findDt += "'";

            cmd = new MySqlCommand(findDt, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            string[] dept_list = {"내과", "일반 외과", "치과", "안과", "이비인후과" };


            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["Dt_name"].ToString(), 
                                        reader["date"].ToString() + " " + reader["time"].ToString(),
                                        dept_list[Convert.ToInt32(reader["dept"])-1]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient0 patient = new patient0();
            patient.Tag = this;
            patient.Show();
            this.Hide();
        }
    }
}
