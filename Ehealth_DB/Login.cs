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
    public partial class Login : Form
    {
        public static string inputId, inputPw;
        public Login()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ID_textbox_TextChanged(object sender, EventArgs e)
        {
            inputId = ID_textbox.Text;
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            inputPw = password_textbox.Text;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // Server=서버아이피;Port=포트;Database=데이터베이스명;Uid=접속계정아이디;Pwd=패스워드;
            MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=ehealth;Uid=root;Pwd=Suyuyebin0623");
            connection.Open();

            string countSql = "SELECT COUNT(*) FROM totaluser_table WHERE client_id = '";
            countSql += inputId;
            countSql += "'";

            MySqlCommand cmd = new MySqlCommand(countSql, connection);
            //MySqlDataReader table = cmd.ExecuteReader();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)   // 존재하지 않는 ID
            {
                MessageBox.Show("존재하지 않는 ID입니다.");
            }

            else    // ID가 존재하면
            {
                // 사용자의 모드 검색
                string findpw = "";
                string findModeSql = "SELECT client_mode FROM totaluser_table WHERE client_id = '";
                findModeSql += inputId;
                findModeSql += "'";

                cmd = new MySqlCommand(findModeSql, connection);
                int modeNum = Convert.ToInt32(cmd.ExecuteScalar());

                //string tm = "cmd : " + findModeSql + " , modeNum : " + modeNum.ToString();
                //MessageBox.Show(tm);

                //if (cmd.ExecuteNonQuery() == 1)
                //{
                //    MessageBox.Show("모드 검색 성공");
                //}
                //else
                //{
                //    MessageBox.Show("모드 검색 실패");
                //    MessageBox.Show(findModeSql);
                //}

                // 사용자 모드에 따라서 패스워드 찾기
                switch (modeNum)
                {
                    case 1:  // 일반 사용자
                        string findPwSql = "SELECT user_pw FROM user_table WHERE user_id = '";
                        findPwSql += inputId;
                        findPwSql += "'";

                        cmd = new MySqlCommand(findPwSql, connection);
                        findpw = Convert.ToString(cmd.ExecuteScalar());

                        if (findpw == inputPw) // 로그인한 사용자 모드에 따라 사용자 창으로 이동하기
                        {
                            MessageBox.Show("로그인에 성공하였습니다!");

                            user1 user01 = new user1();
                            user01.Tag = this;
                            user01.Show();
                            this.Hide();
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("비밀번호가 일치하지 않습니다.");
                        }

                        break;

                    case 2: // 환자
                        findPwSql = "SELECT Pt_pw FROM patient_table WHERE Pt_id = '";
                        findPwSql += inputId;
                        findPwSql += "'";

                        cmd = new MySqlCommand(findPwSql, connection);
                        findpw = Convert.ToString(cmd.ExecuteScalar());

                        if (findpw == inputPw) // 로그인한 사용자 모드에 따라 사용자 창으로 이동하기
                        {
                            MessageBox.Show("로그인에 성공하였습니다!");

                            //string historySql = "INSERT INTO history_table(Pt_id) VALUES(";
                            //countSql += inputId;
                            //countSql += "'";

                            //MySqlCommand cmdHistory = new MySqlCommand(historySql, connection);

                            patient0 patient0 = new patient0();
                            patient0.Tag = this;
                            patient0.Show();
                            this.Hide();
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("비밀번호가 일치하지 않습니다.");
                        }

                        break;

                    case 3: // 의료진
                       // MessageBox.Show("의료진 mode");
                        findPwSql = "SELECT Dt_pw FROM doctor_table WHERE Dt_id = '";
                        findPwSql += inputId;
                        findPwSql += "'";


                        cmd = new MySqlCommand(findPwSql, connection);
                        findpw = Convert.ToString(cmd.ExecuteScalar());
                        
                        //cmd.ExecuteNonQuery();

                        //if (cmd.ExecuteNonQuery() == 1)
                        //{
                        //    MessageBox.Show("pw 찾기 성공");
                        //}
                        //else
                        //{
                        //    MessageBox.Show(findPwSql);
                        //}                                          

                        if (findpw == inputPw) // 로그인한 사용자 모드에 따라 사용자 창으로 이동하기
                        {
                            MessageBox.Show("(의료진) 로그인에 성공하였습니다!");

                            doctor1 doctor1 = new doctor1();
                            doctor1.Tag = this;
                            doctor1.Show();
                            this.Hide();

                            //MessageBox.Show("??");

                            //connection.Dispose();
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("비밀번호가 일치하지 않습니다.");
                        }

                        break;

                    case 4: // 관리자
                        findPwSql = "SELECT Mg_pw FROM manager_table WHERE Mg_id = '";
                        findPwSql += inputId;
                        findPwSql += "'";

                        cmd = new MySqlCommand(findPwSql, connection);
                        findpw = Convert.ToString(cmd.ExecuteScalar());

                        if (findpw == inputPw) // 로그인한 사용자 모드에 따라 사용자 창으로 이동하기
                        {
                            MessageBox.Show("로그인에 성공하였습니다!");

                            manager1 manager01 = new manager1();
                            manager01.Tag = this;
                            manager01.Show();
                            this.Hide();
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("비밀번호가 일치하지 않습니다.");
                        }

                        break;

                    default:
                        break;
                }
            }
        }
    }
}
