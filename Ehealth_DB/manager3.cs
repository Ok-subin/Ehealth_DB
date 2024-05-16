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
    public partial class manager3 : Form
    {
        public manager3()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            // 환자 (patient)
            // 사용자명 / 주민등록번호 / 아이디
            string findSql = "SELECT Pt_name, Pt_number, Pt_id FROM patient_table";
            MySqlCommand cmd = new MySqlCommand(findSql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["Pt_name"].ToString(),
                                        reader["Pt_number"].ToString(),
                                        reader["Pt_id"].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager1 manager = new manager1();
            manager.Tag = this;
            manager.Show();
            this.Hide();
        }
    }
}
