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
    public partial class manager2 : Form
    {
        public manager2()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            // 일반 사용자 (user)
            // 사용자명 / 주민등록번호 / 아이디
            string findSql = "SELECT user_name, user_number, user_id FROM user_table";
            MySqlCommand cmd = new MySqlCommand(findSql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["user_name"].ToString(),
                                        reader["user_number"].ToString(),
                                        reader["user_id"].ToString());
            }

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager1 manager = new manager1();
            manager.Tag = this;
            manager.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
