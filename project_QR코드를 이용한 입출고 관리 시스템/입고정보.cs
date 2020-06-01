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
    public partial class 입고정보 : Form
    {
        public 입고정보()
        {
            InitializeComponent();
        }
        String strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=MES_db;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        private void listview() //리스트뷰
        {
            //데이터 조회 쿼리
            string ent_no, ent_date, p_id, ent_count, ent_storage, cus_id;
            String sql = "SELECT ENT_NO, ENT_DATE, P_ID, ENT_COUNT, ENT_STORAGE, CUS_ID FROM ENTERING";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            //리스트뷰 설정
            listview_Entering.Clear();
            listview_Entering.BeginUpdate(); //리스트뷰 업데이트 시작
            listview_Entering.View = View.Details;
            listview_Entering.Columns.Add("입고번호", 70, HorizontalAlignment.Center);
            listview_Entering.Columns.Add("입고일자", 70, HorizontalAlignment.Center);
            listview_Entering.Columns.Add("품목코드", 150, HorizontalAlignment.Center);
            listview_Entering.Columns.Add("개수", 70, HorizontalAlignment.Center);
            listview_Entering.Columns.Add("창고", 70, HorizontalAlignment.Center);
            listview_Entering.Columns.Add("거래처코드", 100, HorizontalAlignment.Center);

            ListViewItem item; //각 행데이터
            while (reader.Read())
            {
                ent_no = (String)reader["ENT_NO"];
                ent_date = (String)reader["ENT_DATE"];
                p_id = (string)reader["P_ID"];
                ent_count = (String)reader["ENT_COUNT"];
                ent_storage = (String)reader["ENT_STORAGE"];
                cus_id = (String)reader["CUS_ID"];

                item = new ListViewItem(ent_no);
                item.SubItems.Add(ent_date);
                item.SubItems.Add(p_id);
                item.SubItems.Add(ent_count.ToString());
                item.SubItems.Add(ent_storage);
                item.SubItems.Add(cus_id);

                listview_Entering.Items.Add(item);
            }
            reader.Close();

            listview_Entering.EndUpdate(); //리스트뷰 업데이트 끝
        }

        private void 입고정보_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            listview();
            
            //콤보박스에 채우기(P_ID)
            string[] PIDNames = { };
            string sql = "SELECT P_ID FROM product";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string pid = (string)reader["P_ID"];
                Array.Resize(ref PIDNames, PIDNames.Length + 1);
                PIDNames[PIDNames.Length - 1] = pid;
            }
            reader.Close();
            cb_P_ID.Items.AddRange(PIDNames);

            //콤보박스에 채우기(CUS_ID)
            string[] CUSIDNames = { };
            sql = "SELECT CUS_ID FROM CUSTOMER";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string cusid = (string)reader["CUS_ID"];
                Array.Resize(ref CUSIDNames, CUSIDNames.Length + 1);
                CUSIDNames[CUSIDNames.Length - 1] = cusid;
            }
            reader.Close();
            cb_CUS_ID.Items.AddRange(CUSIDNames);
        }

        private void 입고정보_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
        
        private void btn_Registration_Click_1(object sender, EventArgs e)
        {
            //데이터 입력 쿼리
            string ent_no, ent_date, p_id, ent_count, ent_storage, cus_id;
            ent_no = tb_ENT_NO.Text.ToString();
            ent_date = tb_ENT_DATE.Text.ToString();
            p_id = cb_P_ID.Text.ToString();
            ent_count = tb_ENT_COUNT.Text.ToString();
            ent_storage = tb_ENT_STORAGE.Text.ToString();
            cus_id = cb_CUS_ID.Text.ToString();

            String sql = "INSERT INTO ENTERING(ENT_NO, ENT_DATE, P_ID, ENT_COUNT, ENT_STORAGE, CUS_ID)";
            sql += " VALUES('" + ent_no + "', '" + ent_date + "',";
            sql += " '" + p_id + "', " + ent_count + ",";
            sql += " '" + ent_storage + "', '" + cus_id + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            tb_ENT_NO.Text = "";
            tb_ENT_DATE.Text = "";
            cb_P_ID.Text = "";
            tb_ENT_COUNT.Text = "";
            tb_ENT_STORAGE.Text = "";
            cb_CUS_ID.Text = "";

            listview();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
