﻿using System;
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
    public partial class doctor1 : Form
    {
        public static int[] dateIndex = new int[10];
        public static int totalCount;
        public doctor1()
        {            
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            // 로그인한 의사의 현재 진료일 확인
            string query = "SELECT Dt_date FROM doctor_table WHERE Dt_id = '";
            query += Login.inputId;
            query += "'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader myReader = cmd.ExecuteReader();


            // row의 모든 date index 값을 dateIndex 배열에 저장
            int temp;
            int count = 0;
            while (myReader.Read())
            {
                temp = myReader.GetInt32(0); //Convert.ToInt32(myReader.GetString(0));

                //MessageBox.Show(temp.ToString());

                dateIndex[count] = temp;
                count++;
            }

            totalCount = count;
            myReader.Close();
            connection.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctor2 Dt_day = new doctor2();

            if (Dt_day != null)
            {
                Dt_day.Tag = this;
                Dt_day.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctor4 doctor4 = new doctor4();

            doctor4.Tag = this;
            doctor4.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
