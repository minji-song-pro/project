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

namespace 미니프로젝트_vol3_2_
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        //전역변수 선언
        String strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=MES_db;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                sql = "SELECT RIGHT(EMP_RRN,7) FROM EMPLOYEE WHERE EMP_ID=" + tb_ID.Text;
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();
                reader.Read();

                if (tb_Password.Text == reader[0].ToString())
                {
                    reader.Close();
                    //로그인 시 LogInForm 닫고, MainForm 열기
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("로그인 정보가 틀렸습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reader.Close();
                tb_ID.Text = "";
                tb_Password.Text = "";
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void tb_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_LogIn_Click(sender, e);
            }
        }
    }
}
