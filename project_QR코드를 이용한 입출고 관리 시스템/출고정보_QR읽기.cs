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
using OpenCvSharp;
using ZXing;

namespace 미니프로젝트_vol3_2_
{
    public partial class 출고정보_QR읽기 : Form
    {
        public 출고정보_QR읽기()
        {
            InitializeComponent();
        }

        //전역변수 설정
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=MES_db;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        //카메라
        CvCapture capture;
        IplImage src;
        private void 출고정보_QR읽기_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            //카메라
            try
            {
                capture = CvCapture.FromCamera(CaptureDevice.DShow, 0);
                capture.SetCaptureProperty(CaptureProperty.FrameWidth, 300);
                capture.SetCaptureProperty(CaptureProperty.FrameHeight, 300);
            }
            catch
            {
                timer1.Enabled = false;
            }
            listview();
        }
        private void listview()
        {
            //리스트뷰 설정
            listview_Releasing.Clear();
            listview_Releasing.BeginUpdate(); //리스트뷰 업데이트 시작
            listview_Releasing.View = View.Details;
            listview_Releasing.Columns.Add("입고번호", 70, HorizontalAlignment.Center);
            listview_Releasing.Columns.Add("입고일자", 70, HorizontalAlignment.Center);
            listview_Releasing.Columns.Add("품목코드", 150, HorizontalAlignment.Center);
            listview_Releasing.Columns.Add("개수", 70, HorizontalAlignment.Center);
            listview_Releasing.Columns.Add("창고", 70, HorizontalAlignment.Center);
            listview_Releasing.Columns.Add("거래처코드", 100, HorizontalAlignment.Center);
            listview_Releasing.Columns.Add("출고일자", 100, HorizontalAlignment.Center);

            //데이터 조회 쿼리
            string ent_no, ent_date, p_id, ent_count, ent_storage, cus_id, out_date;
            cmd.CommandText = "SELECT ENT_NO, ENT_DATE, P_ID, ENT_COUNT, ENT_STORAGE, CUS_ID, OUT_DATE FROM RELEASING";
            reader = cmd.ExecuteReader();

            ListViewItem item; //각 행데이터
            while (reader.Read())
            {
                ent_no = (String)reader["ENT_NO"];
                ent_date = (String)reader["ENT_DATE"];
                p_id = (string)reader["P_ID"];
                ent_count = (String)reader["ENT_COUNT"];
                ent_storage = (String)reader["ENT_STORAGE"];
                cus_id = (String)reader["CUS_ID"];
                out_date = (String)reader["OUT_DATE"];

                item = new ListViewItem(ent_no);
                item.SubItems.Add(ent_date);
                item.SubItems.Add(p_id);
                item.SubItems.Add(ent_count);
                item.SubItems.Add(ent_storage);
                item.SubItems.Add(cus_id);
                item.SubItems.Add(out_date);

                listview_Releasing.Items.Add(item);
            }
            reader.Close();

            listview_Releasing.EndUpdate(); //리스트뷰 업데이트 끝
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //QR코드 리더
            pictureBoxIpl1.ImageIpl = src;
            BarcodeReader B_reader = new BarcodeReader();
            Result result = B_reader.Decode((Bitmap)pictureBoxIpl1.Image);
            if (result != null)
            {
                string decoded = result.ToString();
                if (decoded != "")
                {
                    tb_ENT_NO.Text = decoded;

                    //데이터 조회 쿼리
                    String sql = "SELECT ENT_NO, ENT_DATE, P_ID, ENT_COUNT, ENT_STORAGE, CUS_ID ";
					sql += "FROM ENTERING WHERE ENT_NO =" + "'" + tb_ENT_NO.Text + "'";
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    tb_ENT_NO.Text = (String)reader["ENT_NO"];
                    tb_ENT_DATE.Text = (String)reader["ENT_DATE"];
                    tb_P_ID.Text = (String)reader["P_ID"];
                    tb_ENT_COUNT.Text = (String)reader["ENT_COUNT"];
                    tb_ENT_STORAGE.Text = (String)reader["ENT_STORAGE"];
                    tb_CUS_ID.Text = (String)reader["CUS_ID"];
                    tb_OUT_DATE.Text = DateTime.Now.ToString("yyyyMMdd");
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("QR코드를 비추세요!");
                }
            }
        }
        private void btn_Registration_Click_1(object sender, EventArgs e)
        {
            //출고등록
            //데이터 입력 쿼리
            string ent_no, ent_date, p_id, ent_count, ent_storage, cus_id, out_date;
            ent_no = tb_ENT_NO.Text;
            ent_date = tb_ENT_DATE.Text;
            p_id = tb_P_ID.Text;
            ent_count = tb_ENT_COUNT.Text;
            ent_storage = tb_ENT_STORAGE.Text;
            cus_id = tb_CUS_ID.Text;
            out_date = tb_OUT_DATE.Text;

            String sql = "INSERT INTO RELEASING(ENT_NO, ENT_DATE, P_ID, ENT_COUNT, ENT_STORAGE, CUS_ID, OUT_DATE)";
            sql += " VALUES('" + ent_no + "', '" + ent_date + "',";
            sql += " '" + p_id + "',' " + ent_count + "',";
            sql += " '" + ent_storage + "', '" + cus_id + "','" + out_date + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            tb_ENT_NO.Text = "";
            tb_ENT_DATE.Text = "";
            tb_P_ID.Text = "";
            tb_ENT_COUNT.Text = "";
            tb_ENT_STORAGE.Text = "";
            tb_CUS_ID.Text = "";
            tb_OUT_DATE.Text = "";

            listview();
        }
        private void 출고정보_QR읽기_FormClosing(object sender, FormClosingEventArgs e)
        {
            //카메라
            Cv.ReleaseImage(src);
            if (src != null) src.Dispose();
        }
        private void 출고정보_QR읽기_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //카메라
            src = capture.QueryFrame();
            pictureBoxIpl1.ImageIpl = src;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
