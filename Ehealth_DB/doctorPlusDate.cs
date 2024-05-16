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
    public partial class doctorPlusDate : Form
    {
        string dt_id = Signup.id, dt_pw = Signup.pw;
        string dt_name;
        int dt_Dept = doctorPlusDept.dt_Dept;

        public static int[] dtDateList = new int[10];

        public doctorPlusDate()
        {
            InitializeComponent();

            // 진료일 list를 0으로 초기화해놓기
            for (int i = 0; i < 10; i++)
            {
                dtDateList[i] = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 체크된 요일 list에서 1로 변경
            if (checkBox1.Checked == true)
                dtDateList[0] = 1;
            if (checkBox2.Checked == true)
                dtDateList[1] = 1;
            if (checkBox3.Checked == true)
                dtDateList[2] = 1;
            if (checkBox4.Checked == true)
                dtDateList[3] = 1;
            if (checkBox5.Checked == true)
                dtDateList[4] = 1;
            if (checkBox6.Checked == true)
                dtDateList[5] = 1;
            if (checkBox7.Checked == true)
                dtDateList[6] = 1;
            if (checkBox8.Checked == true)
                dtDateList[7] = 1;
            if (checkBox9.Checked == true)
                dtDateList[8] = 1;
            if (checkBox10.Checked == true)
                dtDateList[9] = 1;

            // 체크된 요일을 date에 추가해주기
            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            dt_name = Signup.name;
            string dt_id = Signup.id;
            string dt_pw = Signup.pw;
            int dt_idx = Signup.dtIndex;

            // doctor table에 추가하기 위해서 doctor 정보 가져오기
            // 의사 이름
            //string findDt = "SELECT client_name FROM totaluser_table WHERE client_id = '";
            //findDt += dt_id;
            //findDt += "'";

            //MySqlCommand cmd = new MySqlCommand(findDt, connection);
            //dt_name = Convert.ToString(cmd.ExecuteScalar());

            //MessageBox.Show("이름 : " + dt_name);
            //cmd.Dispose();

            //// 의사 주민번호
            //string finddt = "select client_number from totaluser_table where client_id = '";
            //finddt += dt_id;
            //finddt += "'";

            //MySqlCommand cmd = new MySqlCommand(finddt, connection);
            //string dt_number = Convert.ToString(cmd.ExecuteScalar());
            //cmd.Dispose();
            string dt_number = Signup.dt_num;

            //MessageBox.Show(dtDateList.ToString());

            // doctor table에 추가하기
            bool flag = false;
            MySqlCommand command;


            string mgInsert = "INSERT INTO totaluser_table(client_mode, client_name, client_number, client_id) VALUES(";
            string inputMgdata = "3 , '" + dt_name + "' , " + dt_number + " , '" + dt_id + "')";
            mgInsert += inputMgdata;
            command = new MySqlCommand(mgInsert, connection);

            if (command.ExecuteNonQuery() == 1)
            {
                
            }

            for (int i = 0; i < 10; i++)
            {
                if (dtDateList[i] == 1)
                {
                    string inputData = "'" + dt_name + "' , " + dt_number + " , '" + dt_id + "' , '" + dt_pw + "', " 
                        + dt_idx.ToString() + ", " + (i+1).ToString() + ", " + dt_Dept + ")";
                    string insert = "INSERT INTO doctor_table(Dt_name, Dt_number, Dt_id, Dt_pw, Dt_index, Dt_date, Dt_department) VALUES(";
                    insert += inputData;
                    command = new MySqlCommand(insert, connection);

                    //MessageBox.Show(insert);

                    if (command.ExecuteNonQuery()==1)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                    command.Dispose();
                }
            }

            if (flag == true)
            {
                MessageBox.Show("가입 완료!\n회원가입을 축하드립니다.");
            }
            else
            {
                MessageBox.Show("???");
            }

            connection.Close();

            Main main = new Main();
            main.Tag = this;
            main.Show();
            this.Hide();

            connection.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
