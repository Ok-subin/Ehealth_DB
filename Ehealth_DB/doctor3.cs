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
    public partial class doctor3 : Form
    {
        string[] Dt_date = doctor2.Dt_date;
        int count = doctor2.count;
        int[] equals = doctor2.equals;
        string dt_id = Login.inputId, dt_pw = Login.inputPw;
        string dt_name, dt_department, dt_number;
        int dt_idx;

        private void doctor3_Load(object sender, EventArgs e)
        {

        }

        public doctor3()
        {
            InitializeComponent();

            // 의사가 진료하는 요일의 글씨체 다르게 하는 코드
            // input 1
            bool find = false;
            string input = checkBox1.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                    break;
                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                checkBox1.ForeColor = Color.Red;
                checkBox1.Font = new Font(checkBox1.Font, FontStyle.Bold);
                equals[0] = 1;
            }

            // input 2
            find = false;
            input = checkBox2.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                    break;

                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                checkBox2.ForeColor = Color.Red;
                checkBox2.Font = new Font(checkBox2.Font, FontStyle.Bold);
                equals[1] = 1;
            }

            // input 3
            find = false;
            input = checkBox3.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                    break;

                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                checkBox3.ForeColor = Color.Red;
                checkBox3.Font = new Font(checkBox3.Font, FontStyle.Bold);
                equals[2] = 1;
            }

            // input 4
            find = false;
            input = checkBox4.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                    break;

                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                checkBox4.ForeColor = Color.Red;
                checkBox4.Font = new Font(checkBox4.Font, FontStyle.Bold);
                equals[3] = 1;
            }

            // input 5
            find = false;
            input = checkBox5.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                    break;

                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                checkBox5.ForeColor = Color.Red;
                checkBox5.Font = new Font(checkBox5.Font, FontStyle.Bold);
                equals[4] = 1;
            }

            // input 6
            find = false;
            input = checkBox6.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                    break;

                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                checkBox6.ForeColor = Color.Red;
                checkBox6.Font = new Font(checkBox6.Font, FontStyle.Bold);
                equals[5] = 1;
            }

            // input 7
            find = false;
            input = checkBox7.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                    break;

                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                checkBox7.ForeColor = Color.Red;
                checkBox7.Font = new Font(checkBox7.Font, FontStyle.Bold);
                equals[6] = 1;
            }

            // input 8
            find = false;
            input = checkBox8.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                    break;

                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                checkBox8.ForeColor = Color.Red;
                checkBox8.Font = new Font(checkBox8.Font, FontStyle.Bold);
                equals[7] = 1;
            }

            // input 9
            find = false;
            input = checkBox9.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                    break;

                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                checkBox9.ForeColor = Color.Red;
                checkBox9.Font = new Font(checkBox9.Font, FontStyle.Bold);
                equals[8] = 1;
            }

            // input 10
            find = false;
            input = checkBox10.Text;
            for (int i = 0; i < count; i++)
            {
                if (Dt_date[i].Equals(input))
                {
                    find = true;
                    break;

                }
            }
            // 만약 해당값이 의사의 진료일이 맞으면 굵은 글씨 및 붉은 글씨
            if (find == true)
            {
                checkBox10.ForeColor = Color.Red;
                checkBox10.Font = new Font(checkBox10.Font, FontStyle.Bold);
                equals[9] = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 체크된 요일을 date에 추가해주기
            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            // doctor table에 추가하기 위해서 doctor 정보 가져오기
            // 의사 이름
            string findDt = "SELECT client_name FROM totaluser_table WHERE client_id = '";
            findDt += dt_id;
            findDt += "'";

            MySqlCommand cmd = new MySqlCommand(findDt, connection);
            dt_name = Convert.ToString(cmd.ExecuteScalar());
            
            //MessageBox.Show("이름 : " + dt_name);
            cmd.Dispose();

            // 의사 주민번호
            findDt = "SELECT client_number FROM totaluser_table WHERE client_id = '";
            findDt += dt_id;
            findDt += "'";

            cmd = new MySqlCommand(findDt, connection);
            dt_number = Convert.ToString(cmd.ExecuteScalar());
            cmd.Dispose();

            // 의사 진료과
            findDt = "SELECT Dt_department FROM doctor_table WHERE Dt_id = '";
            findDt += dt_id;
            findDt += "'";

            cmd = new MySqlCommand(findDt, connection);
            dt_department = Convert.ToString(cmd.ExecuteScalar());
            cmd.Dispose();

            // 의사 index
            findDt = "SELECT Dt_index FROM doctor_table WHERE Dt_id = '";
            findDt += dt_id;
            findDt += "'";

            cmd = new MySqlCommand(findDt, connection);
            dt_idx = Convert.ToInt16(Convert.ToString(cmd.ExecuteScalar()));
            cmd.Dispose();


            // 정보 업데이트
            // checked True?  (1) find가 T (즉, 등록된 상태) -> DB에서 제거  ,  (2) find가 F (즉, 등록되지 않은 상태) -> DB에 추가
            bool find = false;
            string input, com;
            if (checkBox1.Checked == true)
            {
                find = false;
                input = checkBox1.Text;
                for (int i = 0; i < count; i++)
                {
                    if (Dt_date[i].Equals(input))
                    {
                        find = true;
                        break;
                    }
                }

                if (find == true)
                {
                    //com = "SELECT client_name FROM totaluser_table WHERE client_id = '";
                    com = "DELETE FROM doctor_table WHERE doctor_id = ";
                    com += dt_id;
                    com += " AND Dt_date = ";
                    com += 1;
                    com += "'";

                    cmd = new MySqlCommand(findDt, connection);
                    cmd.Dispose();
                }
                else
                {
                    string sql = "INSERT INTO doctor_table(Dt_id, Dt_pw, Dt_name, Dt_number, Dt_date, Dt_department, Dt_index) VALUES(";
                    sql += "'";
                    sql += dt_id;
                    sql += "' , '";
                    sql += dt_pw;
                    sql += "', '";
                    sql += dt_name;
                    sql += "' , '";
                    sql += dt_number;
                    sql += "' , ";
                    sql += 1;
                    sql += " , ";
                    sql += dt_department;
                    sql += " , ";
                    sql += dt_idx;
                    sql += ")";
                }
            }

            if (checkBox2.Checked == true)
            {
                find = false;
                input = checkBox2.Text;
                for (int i = 0; i < count; i++)
                {
                    if (Dt_date[i].Equals(input))
                    {
                        find = true;
                        break;
                    }
                }

                if (find == true)
                {
                    //com = "SELECT client_name FROM totaluser_table WHERE client_id = '";
                    com = "DELETE FROM doctor_table WHERE doctor_id = ";
                    com += dt_id;
                    com += " AND Dt_date = ";
                    com += 2;
                    com += "'";

                    cmd = new MySqlCommand(findDt, connection);
                    cmd.Dispose();
                }
                else
                {
                    string sql = "INSERT INTO doctor_table(Dt_id, Dt_pw, Dt_name, Dt_number, Dt_date, Dt_department, Dt_index) VALUES(";
                    sql += "'";
                    sql += dt_id;
                    sql += "' , '";
                    sql += dt_pw;
                    sql += "', '";
                    sql += dt_name;
                    sql += "' , '";
                    sql += dt_number;
                    sql += "' , ";
                    sql += 2;
                    sql += " , ";
                    sql += dt_department;
                    sql += " , ";
                    sql += dt_idx;
                    sql += ")";
                }
            }

            if (checkBox3.Checked == true)
            {
                find = false;
                input = checkBox3.Text;
                for (int i = 0; i < count; i++)
                {
                    if (Dt_date[i].Equals(input))
                    {
                        find = true;
                        break;
                    }
                }

                if (find == true)
                {
                    //com = "SELECT client_name FROM totaluser_table WHERE client_id = '";
                    com = "DELETE FROM doctor_table WHERE doctor_id = ";
                    com += dt_id;
                    com += " AND Dt_date = ";
                    com += 3;
                    com += "'";

                    cmd = new MySqlCommand(findDt, connection);
                    cmd.Dispose();
                }
                else
                {
                    string sql = "INSERT INTO doctor_table(Dt_id, Dt_pw, Dt_name, Dt_number, Dt_date, Dt_department, Dt_index) VALUES(";
                    sql += "'";
                    sql += dt_id;
                    sql += "' , '";
                    sql += dt_pw;
                    sql += "', '";
                    sql += dt_name;
                    sql += "' , '";
                    sql += dt_number;
                    sql += "' , ";
                    sql += 3;
                    sql += " , ";
                    sql += dt_department;
                    sql += " , ";
                    sql += dt_idx;
                    sql += ")";
                }
            }

            if (checkBox4.Checked == true)
            {
                find = false;
                input = checkBox4.Text;
                for (int i = 0; i < count; i++)
                {
                    if (Dt_date[i].Equals(input))
                    {
                        find = true;
                        break;
                    }
                }

                if (find == true)
                {
                    //com = "SELECT client_name FROM totaluser_table WHERE client_id = '";
                    com = "DELETE FROM doctor_table WHERE doctor_id = ";
                    com += dt_id;
                    com += " AND Dt_date = ";
                    com += 4;
                    com += "'";

                    cmd = new MySqlCommand(findDt, connection);
                    cmd.Dispose();
                }
                else
                {
                    string sql = "INSERT INTO doctor_table(Dt_id, Dt_pw, Dt_name, Dt_number, Dt_date, Dt_department, Dt_index) VALUES(";
                    sql += "'";
                    sql += dt_id;
                    sql += "' , '";
                    sql += dt_pw;
                    sql += "', '";
                    sql += dt_name;
                    sql += "' , '";
                    sql += dt_number;
                    sql += "' , ";
                    sql += 4;
                    sql += " , ";
                    sql += dt_department;
                    sql += " , ";
                    sql += dt_idx;
                    sql += ")";
                }
            }

            if (checkBox5.Checked == true)
            {
                find = false;
                input = checkBox5.Text;
                for (int i = 0; i < count; i++)
                {
                    if (Dt_date[i].Equals(input))
                    {
                        find = true;
                        break;
                    }
                }

                if (find == true)
                {
                    //com = "SELECT client_name FROM totaluser_table WHERE client_id = '";
                    com = "DELETE FROM doctor_table WHERE doctor_id = ";
                    com += dt_id;
                    com += " AND Dt_date = ";
                    com += 5;
                    com += "'";

                    cmd = new MySqlCommand(findDt, connection);
                    cmd.Dispose();
                }
                else
                {
                    string sql = "INSERT INTO doctor_table(Dt_id, Dt_pw, Dt_name, Dt_number, Dt_date, Dt_department, Dt_index) VALUES(";
                    sql += "'";
                    sql += dt_id;
                    sql += "' , '";
                    sql += dt_pw;
                    sql += "', '";
                    sql += dt_name;
                    sql += "' , '";
                    sql += dt_number;
                    sql += "' , ";
                    sql += 5;
                    sql += " , ";
                    sql += dt_department;
                    sql += " , ";
                    sql += dt_idx;
                    sql += ")";
                }
            }

            if (checkBox6.Checked == true)
            {
                find = false;
                input = checkBox6.Text;
                for (int i = 0; i < count; i++)
                {
                    if (Dt_date[i].Equals(input))
                    {
                        find = true;
                        break;
                    }
                }

                if (find == true)
                {
                    //com = "SELECT client_name FROM totaluser_table WHERE client_id = '";
                    com = "DELETE FROM doctor_table WHERE doctor_id = ";
                    com += dt_id;
                    com += " AND Dt_date = ";
                    com += 6;
                    com += "'";

                    cmd = new MySqlCommand(findDt, connection);
                    cmd.Dispose();
                }
                else
                {
                    string sql = "INSERT INTO doctor_table(Dt_id, Dt_pw, Dt_name, Dt_number, Dt_date, Dt_department, Dt_index) VALUES(";
                    sql += "'";
                    sql += dt_id;
                    sql += "' , '";
                    sql += dt_pw;
                    sql += "', '";
                    sql += dt_name;
                    sql += "' , '";
                    sql += dt_number;
                    sql += "' , ";
                    sql += 6;
                    sql += " , ";
                    sql += dt_department;
                    sql += " , ";
                    sql += dt_idx;
                    sql += ")";
                }
            }

            if (checkBox7.Checked == true)
            {
                find = false;
                input = checkBox7.Text;
                for (int i = 0; i < count; i++)
                {
                    if (Dt_date[i].Equals(input))
                    {
                        find = true;
                        break;
                    }
                }

                if (find == true)
                {
                    //com = "SELECT client_name FROM totaluser_table WHERE client_id = '";
                    com = "DELETE FROM doctor_table WHERE doctor_id = ";
                    com += dt_id;
                    com += " AND Dt_date = ";
                    com += 7;
                    com += "'";

                    cmd = new MySqlCommand(findDt, connection);
                    cmd.Dispose();
                }
                else
                {
                    string sql = "INSERT INTO doctor_table(Dt_id, Dt_pw, Dt_name, Dt_number, Dt_date, Dt_department, Dt_index) VALUES(";
                    sql += "'";
                    sql += dt_id;
                    sql += "' , '";
                    sql += dt_pw;
                    sql += "', '";
                    sql += dt_name;
                    sql += "' , '";
                    sql += dt_number;
                    sql += "' , ";
                    sql += 7;
                    sql += " , ";
                    sql += dt_department;
                    sql += " , ";
                    sql += dt_idx;
                    sql += ")";
                }
            }

            if (checkBox8.Checked == true)
            {
                find = false;
                input = checkBox8.Text;
                for (int i = 0; i < count; i++)
                {
                    if (Dt_date[i].Equals(input))
                    {
                        find = true;
                        break;
                    }
                }

                if (find == true)
                {
                    //com = "SELECT client_name FROM totaluser_table WHERE client_id = '";
                    com = "DELETE FROM doctor_table WHERE doctor_id = ";
                    com += dt_id;
                    com += " AND Dt_date = ";
                    com += 8;
                    com += "'";

                    cmd = new MySqlCommand(findDt, connection);
                    cmd.Dispose();
                }
                else
                {
                    string sql = "INSERT INTO doctor_table(Dt_id, Dt_pw, Dt_name, Dt_number, Dt_date, Dt_department, Dt_index) VALUES(";
                    sql += "'";
                    sql += dt_id;
                    sql += "' , '";
                    sql += dt_pw;
                    sql += "', '";
                    sql += dt_name;
                    sql += "' , '";
                    sql += dt_number;
                    sql += "' , ";
                    sql += 8;
                    sql += " , ";
                    sql += dt_department;
                    sql += " , ";
                    sql += dt_idx;
                    sql += ")";
                }
            }

            if (checkBox9.Checked == true)
            {
                find = false;
                input = checkBox9.Text;
                for (int i = 0; i < count; i++)
                {
                    if (Dt_date[i].Equals(input))
                    {
                        find = true;
                        break;
                    }
                }

                if (find == true)
                {
                    //com = "SELECT client_name FROM totaluser_table WHERE client_id = '";
                    com = "DELETE FROM doctor_table WHERE doctor_id = ";
                    com += dt_id;
                    com += " AND Dt_date = ";
                    com += 9;
                    com += "'";

                    cmd = new MySqlCommand(findDt, connection);
                    cmd.Dispose();
                }
                else
                {
                    string sql = "INSERT INTO doctor_table(Dt_id, Dt_pw, Dt_name, Dt_number, Dt_date, Dt_department, Dt_index) VALUES(";
                    sql += "'";
                    sql += dt_id;
                    sql += "' , '";
                    sql += dt_pw;
                    sql += "', '";
                    sql += dt_name;
                    sql += "' , '";
                    sql += dt_number;
                    sql += "' , ";
                    sql += 9;
                    sql += " , ";
                    sql += dt_department;
                    sql += " , ";
                    sql += dt_idx;
                    sql += ")";
                }
            }

            if (checkBox10.Checked == true)
            {
                find = false;
                input = checkBox10.Text;
                for (int i = 0; i < count; i++)
                {
                    if (Dt_date[i].Equals(input))
                    {
                        find = true;
                        break;
                    }
                }

                if (find == true)
                {
                    //com = "SELECT client_name FROM totaluser_table WHERE client_id = '";
                    com = "DELETE FROM doctor_table WHERE doctor_id = ";
                    com += dt_id;
                    com += " AND Dt_date = ";
                    com += 10;
                    com += "'";

                    cmd = new MySqlCommand(findDt, connection);
                    cmd.Dispose();
                }
                else
                {
                    string sql = "INSERT INTO doctor_table(Dt_id, Dt_pw, Dt_name, Dt_number, Dt_date, Dt_department, Dt_index) VALUES(";
                    sql += "'";
                    sql += dt_id;
                    sql += "' , '";
                    sql += dt_pw;
                    sql += "', '";
                    sql += dt_name;
                    sql += "' , '";
                    sql += dt_number;
                    sql += "' , ";
                    sql += 10;
                    sql += " , ";
                    sql += dt_department;
                    sql += " , ";
                    sql += dt_idx;
                    sql += ")";
                }
            }


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
    }
}
