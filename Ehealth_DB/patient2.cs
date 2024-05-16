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
    public partial class patient2 : Form
    {
        int dept = patient1.dept;
        public static string dt_name, dt_date, dt_time;
        List<string> date_list = patient1.date_list; // yyyy-MM-dd       

        public patient2()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            MySqlDataReader reader;
            MySqlCommand cmd;
            string findDt;

            // 진료 가능한 요일 찾기
            string temp;
            int temp_;

            // real list 생성
            List<string> real_date_list = new List<string>(); // yyyy-mm-dd
            // 하루만 선택
            if (date_list.Count == 1)
            {
                real_date_list.Add(date_list[0]);
            }
            // start, end가 주어진 경우
            else
            {
                string[] temp_list_1 = date_list[0].Split('-');
                string[] temp_list_2 = date_list[1].Split('-');

                var start = new DateTime(Convert.ToInt32(temp_list_1[0]), Convert.ToInt32(temp_list_1[1]),
                                                     Convert.ToInt32(temp_list_1[2]));
                var end = new DateTime(Convert.ToInt32(temp_list_2[0]), Convert.ToInt32(temp_list_2[1]),
                                                     Convert.ToInt32(temp_list_2[2]));                

                while (DateTime.Compare(start, end) != 1)
                {
                    //MessageBox.Show(DateTime.Compare(start, end).ToString());
                    //MessageBox.Show(start.ToString());

                    real_date_list.Add(start.ToString("yyyy-MM-dd"));
                    start = start.AddDays(1);
                }
            }

            // 각 날짜마다 list 생성 -> 의사명 / 진료일시(yyyy-mm-dd) / 진료시간(오전/오후)
            for (int i = 0; i < real_date_list.Count; i++)
            {
                temp = real_date_list[i];
                string[] temp_list = temp.Split('-');

                DateTime dateValue = new DateTime(Convert.ToInt32(temp_list[0]), Convert.ToInt32(temp_list[1]),
                                                     Convert.ToInt32(temp_list[2]));    // 일(0) ~ 토(6)
                temp_ = (int)dateValue.DayOfWeek;
                // 1 -> 1, 2  /  2 -> 3, 4  /  3 -> 5, 6  /  4 -> 7, 8  /  5 -> 9, 10
                // 이에 따른 의사 리스트

                // MessageBox.Show(i.ToString() + temp_.ToString());

                switch (temp_)
                {
                    case 1: // 월요일

                        // 월요일 오전
                        findDt = "SELECT Dt_name FROM doctor_table WHERE Dt_department = ";
                        findDt += dept;
                        findDt += " AND Dt_date = ";
                        findDt += 1;

                        cmd = new MySqlCommand(findDt, connection);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Dt_name"].ToString(), temp, "오전");
                            MessageBox.Show(reader["Dt_name"].ToString());
                        }

                        // 월요일 오후
                        findDt = "SELECT Dt_name FROM doctor_table WHERE Dt_department = ";
                        findDt += dept;
                        findDt += " AND Dt_date = ";
                        findDt += 2;

                        reader.Close();

                        cmd = new MySqlCommand(findDt, connection);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Dt_name"].ToString(), temp, "오후");
                        }

                        reader.Close();

                        break;

                    case 2: // 화요일
                            // 화요일 오전
                        findDt = "SELECT Dt_name FROM doctor_table WHERE Dt_department = ";
                        findDt += dept;
                        findDt += " AND Dt_date = ";
                        findDt += 3;

                        cmd = new MySqlCommand(findDt, connection);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Dt_name"].ToString(), temp, "오전");
                        }

                        reader.Close();

                        // 화요일 오후
                        findDt = "SELECT Dt_name FROM doctor_table WHERE Dt_department = ";
                        findDt += dept;
                        findDt += " AND Dt_date = ";
                        findDt += 4;

                        cmd = new MySqlCommand(findDt, connection);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Dt_name"].ToString(), temp, "오후");
                        }

                        reader.Close();

                        break;

                    case 3: // 수요일
                            // 수요일 오전
                        findDt = "SELECT Dt_name FROM doctor_table WHERE Dt_department = ";
                        findDt += dept;
                        findDt += " AND Dt_date = ";
                        findDt += 5;

                        cmd = new MySqlCommand(findDt, connection);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Dt_name"].ToString(), temp, "오전");
                        }

                        reader.Close();

                        // 수요일 오후
                        findDt = "SELECT Dt_name FROM doctor_table WHERE Dt_department = ";
                        findDt += dept;
                        findDt += " AND Dt_date = ";
                        findDt += 6;

                        cmd = new MySqlCommand(findDt, connection);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Dt_name"].ToString(), temp, "오후");
                        }

                        reader.Close();

                        break;

                    case 4: // 목요일
                            // 목요일 오전
                        findDt = "SELECT Dt_name FROM doctor_table WHERE Dt_department = ";
                        findDt += dept;
                        findDt += " AND Dt_date = ";
                        findDt += 7;

                        cmd = new MySqlCommand(findDt, connection);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Dt_name"].ToString(), temp, "오전");
                        }

                        reader.Close();

                        // 목요일 오후
                        findDt = "SELECT Dt_name FROM doctor_table WHERE Dt_department = ";
                        findDt += dept;
                        findDt += " AND Dt_date = ";
                        findDt += 8;

                        cmd = new MySqlCommand(findDt, connection);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Dt_name"].ToString(), temp, "오후");
                        }

                        reader.Close();

                        break;

                    case 5: // 금요일
                            // 금요일 오전
                        findDt = "SELECT Dt_name FROM doctor_table WHERE Dt_department = ";
                        findDt += dept;
                        findDt += " AND Dt_date = ";
                        findDt += 9;

                        cmd = new MySqlCommand(findDt, connection);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Dt_name"].ToString(), temp, "오전");
                        }

                        reader.Close();

                        //금요일 오후
                        findDt = "SELECT Dt_name FROM doctor_table WHERE Dt_department = ";
                        findDt += dept;
                        findDt += " AND Dt_date = ";
                        findDt += 10;

                        cmd = new MySqlCommand(findDt, connection);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["Dt_name"].ToString(), temp, "오후");
                        }

                        reader.Close();

                        break;

                    default:
                        break;
                }

                //date_list.Add((int)dateValue.DayOfWeek);
            }

            connection.Close();
        }


        private void button3_Click(object sender, EventArgs e)  
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0]; //선택된 Row 값 가져옴.
            dt_name = row.Cells[0].Value.ToString();    // 의료진명
            dt_date = row.Cells[1].Value.ToString();    // YYYY-MM-DD
            dt_time = row.Cells[2].Value.ToString();    // 오전/오후

            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            string findSql = "SELECT Pt_name FROM patient_table WHERE Pt_id = '";
            findSql += Login.inputId;
            findSql += "'";

            //MessageBox.Show(findSql);

            MySqlCommand cmd = new MySqlCommand(findSql, connection);
            string pt_name = Convert.ToString(cmd.ExecuteScalar());

            string[] temp_list = dt_date.Split('-');

            DateTime dateValue = new DateTime(Convert.ToInt32(temp_list[0]), Convert.ToInt32(temp_list[1]),
                                                 Convert.ToInt32(temp_list[2]));    // 일(0) ~ 토(6)
            int week = (int)dateValue.DayOfWeek;

            findSql = "INSERT INTO reservation_table (Dt_name, Pt_name, date, time, dept, week) VALUES ('";
            findSql += dt_name;
            findSql += "', '";
            findSql += pt_name;
            findSql += "', '";
            findSql += dt_date;
            findSql += "', '";
            findSql += dt_time;
            findSql += "', '";
            findSql += dept;
            findSql += "', '";
            findSql += week;
            findSql += "')";

            cmd = new MySqlCommand(findSql, connection);
            int n = cmd.ExecuteNonQuery();

            connection.Close();

            patient3 patient = new patient3();
            patient.Tag = this;
            patient.Show();
            this.Hide();
        }
    }
}
