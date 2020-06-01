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
    public partial class 거래처정보 : Form
    {
        public 거래처정보()
        {
            InitializeComponent();
        }
        String strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=MES_db;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        
        private void 거래처정보_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            listview();
        }

        private void 거래처정보_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
        
        private void btn_Registration_Click_1(object sender, EventArgs e)
        {
            //데이터 입력 쿼리
            string cus_id, cus_class, cus_num, cus_businessname, cus_name, cus_address, cus_phone;
            string cus_type, cus_item, cus_situation;
            cus_id = tb_CUS_ID.Text.ToString();
            cus_class = tb_CUS_CLASS.Text.ToString();
            cus_num = tb_CUS_NUM.Text.ToString();
            cus_businessname = tb_CUS_BUSINESSNAME.Text.ToString();
            cus_name = tb_CUS_NAME.Text.ToString();
            cus_address = tb_CUS_ADDRESS.Text.ToString();
            cus_phone = tb_CUS_PHONE.Text.ToString();
            cus_type = tb_CUS_TYPE.Text.ToString();
            cus_item = tb_CUS_ITEM.Text.ToString();
            cus_situation = tb_CUS_SITUATION.Text.ToString();

            String sql = "INSERT INTO CUSTOMER(CUS_ID, CUS_CLASS, CUS_NUM, CUS_BUSINESSNAME, CUS_NAME, CUS_ADDRESS, ";
            sql += "CUS_PHONE, CUS_TYPE, CUS_ITEM, CUS_SITUATION)";
            sql += " VALUES('" + cus_id + "', '" + cus_class + "', '" + cus_num;
            sql += " ', '" + cus_businessname + "', '" + cus_name + "','" + cus_address;
            sql += " ', '" + cus_phone + "', '" + cus_type + "', '" + cus_item + "', '" + cus_situation + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            tb_CUS_ID.Text = "";
            tb_CUS_CLASS.Text = "";
            tb_CUS_NUM.Text = "";
            tb_CUS_BUSINESSNAME.Text = "";
            tb_CUS_NAME.Text = "";
            tb_CUS_ADDRESS.Text = "";
            tb_CUS_PHONE.Text = "";
            tb_CUS_TYPE.Text = "";
            tb_CUS_ITEM.Text = "";
            tb_CUS_SITUATION.Text = "";

            listview();
        }
        private void listview() //리스트뷰
        {
            //데이터 조회 쿼리
            string cus_id, cus_class, cus_num, cus_businessname, cus_name, cus_address, cus_phone;
            string cus_type, cus_item, cus_situation;
            String sql = "SELECT CUS_ID, CUS_CLASS, CUS_NUM, CUS_BUSINESSNAME, CUS_NAME, CUS_ADDRESS, CUS_PHONE, ";
            sql += "CUS_TYPE, CUS_ITEM, CUS_SITUATION FROM CUSTOMER";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            //리스트뷰 설정
            listview_Customer.Clear();
            listview_Customer.BeginUpdate(); //리스트뷰 업데이트 시작
            listview_Customer.View = View.Details;
            listview_Customer.Columns.Add("No", 40, HorizontalAlignment.Center);
            listview_Customer.Columns.Add("사업자구분", 80, HorizontalAlignment.Center);
            listview_Customer.Columns.Add("등록번호", 100, HorizontalAlignment.Center);
            listview_Customer.Columns.Add("거래처명", 130, HorizontalAlignment.Center);
            listview_Customer.Columns.Add("대표자명", 70, HorizontalAlignment.Center);
            listview_Customer.Columns.Add("주소", 100, HorizontalAlignment.Center);
            listview_Customer.Columns.Add("전화번호", 80, HorizontalAlignment.Center);
            listview_Customer.Columns.Add("업태", 70, HorizontalAlignment.Center);
            listview_Customer.Columns.Add("종목", 90, HorizontalAlignment.Center);
            listview_Customer.Columns.Add("거래처상태", 80, HorizontalAlignment.Center);

            ListViewItem item; //각 행데이터
            while (reader.Read())
            {
                cus_id = (String)reader["CUS_ID"];
                cus_class = (String)reader["CUS_CLASS"];
                cus_num = (string)reader["CUS_NUM"];
                cus_businessname = (String)reader["CUS_BUSINESSNAME"];
                cus_name = (String)reader["CUS_NAME"];
                cus_address = (String)reader["CUS_ADDRESS"];
                cus_phone = (String)reader["CUS_PHONE"];
                cus_type = (String)reader["CUS_TYPE"];
                cus_item = (String)reader["CUS_ITEM"];
                cus_situation = (String)reader["CUS_SITUATION"];

                item = new ListViewItem(cus_id);
                item.SubItems.Add(cus_class);
                item.SubItems.Add(cus_num);
                item.SubItems.Add(cus_businessname);
                item.SubItems.Add(cus_name);
                item.SubItems.Add(cus_address);
                item.SubItems.Add(cus_phone);
                item.SubItems.Add(cus_type);
                item.SubItems.Add(cus_item);
                item.SubItems.Add(cus_situation);

                listview_Customer.Items.Add(item);
            }
            reader.Close();

            listview_Customer.EndUpdate(); //리스트뷰 업데이트 끝
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
