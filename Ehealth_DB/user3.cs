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
    public partial class user3 : Form
    {
        public user3()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            string findSql;
            MySqlCommand cmd;
            List<int> count_list = new List<int>();

            // 월(1) ~ 금(5)
            for (int i = 0; i < 5; i++)
            {
                findSql = "SELECT count(*) FROM reservation_table WHERE week = ";
                findSql += (i + 1);
                cmd = new MySqlCommand(findSql, connection);
                count_list.Add(Convert.ToInt32(cmd.ExecuteScalar()));
            }

            // label 3~7
            label3.Text = count_list[0].ToString();
            label4.Text = count_list[1].ToString();
            label5.Text = count_list[2].ToString();
            label6.Text = count_list[3].ToString();
            label7.Text = count_list[4].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            user1 user = new user1();
            user.Tag = this;
            user.Show();
            this.Hide();
        }
    }
}
