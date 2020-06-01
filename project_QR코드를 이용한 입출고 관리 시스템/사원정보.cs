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
    public partial class 사원정보 : Form
    {
        public 사원정보()
        {
            InitializeComponent();
        }
        String strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=MES_db;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        private void 사원현황_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            listview();
        }
        private void listview() //리스트뷰
        {
            //데이터 조회 쿼리
            string emp_id, emp_name, emp_rrn, emp_department, emp_position, emp_phone;
            String sql = "SELECT EMP_ID, EMP_NAME, EMP_RRN, EMP_DEPARTMENT, EMP_POSITION, EMP_PHONE FROM EMPLOYEE";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            //리스트뷰 설정
            listview_Employee.Clear();
            listview_Employee.BeginUpdate(); //리스트뷰 업데이트 시작
            listview_Employee.View = View.Details;
            listview_Employee.Columns.Add("사원번호", 70, HorizontalAlignment.Center);
            listview_Employee.Columns.Add("성명", 70, HorizontalAlignment.Center);
            listview_Employee.Columns.Add("주민번호", 130, HorizontalAlignment.Center);
            listview_Employee.Columns.Add("부서", 70, HorizontalAlignment.Center);
            listview_Employee.Columns.Add("직급", 70, HorizontalAlignment.Center);
            listview_Employee.Columns.Add("연락처", 100, HorizontalAlignment.Center);

            ListViewItem item; //각 행데이터
            while (reader.Read())
            {
                emp_id = (String)reader["EMP_ID"];
                emp_name = (String)reader["EMP_NAME"];
                emp_rrn = (string)reader["EMP_RRN"];
                emp_department = (String)reader["EMP_DEPARTMENT"];
                emp_position = (String)reader["EMP_POSITION"];
                emp_phone = (String)reader["EMP_PHONE"];

                item = new ListViewItem(emp_id);
                item.SubItems.Add(emp_name);
                item.SubItems.Add(emp_rrn);
                item.SubItems.Add(emp_department);
                item.SubItems.Add(emp_position);
                item.SubItems.Add(emp_phone);

                listview_Employee.Items.Add(item);
            }
            reader.Close();

            listview_Employee.EndUpdate(); //리스트뷰 업데이트 끝
        }
        private void 사원현황_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
        private void btn_Registration_Click(object sender, EventArgs e)
        {
            //데이터 입력 쿼리
            string emp_id, emp_name, emp_rrn, emp_department, emp_position, emp_phone;
            emp_id = tb_EMP_ID.Text.ToString();
            emp_name = tb_EMP_NAME.Text.ToString();
            emp_rrn = tb_EMP_RRN.Text.ToString();
            emp_department = tb_EMP_DEPARTMENT.Text.ToString();
            emp_position = tb_EMP_POSITION.Text.ToString();
            emp_phone = tb_EMP_PHONE.Text.ToString();

            String sql = "INSERT INTO EMPLOYEE(EMP_ID, EMP_NAME, EMP_RRN, EMP_DEPARTMENT, EMP_POSITION, EMP_PHONE)";
            sql += " VALUES('" + emp_id + "', '" + emp_name + "',";
            sql += " '" + emp_rrn + "', '" + emp_department + "',";
            sql += " '" + emp_position + "', '" + emp_phone + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            tb_EMP_ID.Text = "";
            tb_EMP_NAME.Text = "";
            tb_EMP_RRN.Text = "";
            tb_EMP_DEPARTMENT.Text = "";
            tb_EMP_POSITION.Text = "";
            tb_EMP_PHONE.Text = "";

            listview();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
