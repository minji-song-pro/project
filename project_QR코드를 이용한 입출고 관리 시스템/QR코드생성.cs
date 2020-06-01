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
using System.IO;
using System.Drawing.Printing;
using ZXing;

namespace 미니프로젝트_vol3_2_
{
    public partial class QR코드생성 : Form
    {
        public QR코드생성()
        {
            InitializeComponent();
        }
        String strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=MES_db;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        private void 바코드생성_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            //데이터 조회 쿼리
            string ent_no, ent_date, p_id, ent_count, ent_storage, cus_id;
            String sql = "SELECT ENT_NO, ENT_DATE, P_ID, ENT_COUNT, ENT_STORAGE, CUS_ID FROM ENTERING";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            //리스트뷰 설정
            listview_Entering.Clear();
            listview_Entering.BeginUpdate(); //리스트뷰 업데이트 시작
            listview_Entering.View = View.Details;
            listview_Entering.Columns.Add("입고번호", 90, HorizontalAlignment.Center);
            listview_Entering.Columns.Add("입고일자", 90, HorizontalAlignment.Center);
            listview_Entering.Columns.Add("품목코드", 120, HorizontalAlignment.Center);
            listview_Entering.Columns.Add("개수", 60, HorizontalAlignment.Center);
            listview_Entering.Columns.Add("창고", 70, HorizontalAlignment.Center);
            listview_Entering.Columns.Add("거래처코드", 90, HorizontalAlignment.Center);

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
        private void btn_Registration_Click_1(object sender, EventArgs e)
        {
            //QR코드 생성
            ZXing.BarcodeWriter barcodeWriter = new ZXing.BarcodeWriter();
            barcodeWriter.Format = ZXing.BarcodeFormat.QR_CODE;

            barcodeWriter.Options.Width = this.pictureBox_QR.Width;
            barcodeWriter.Options.Height = this.pictureBox_QR.Height;

            string strQRCode = tb_ENT_NO.Text.ToString();
            //strQRCode += tb_Pname.Text.ToString();

            this.pictureBox_QR.Image = barcodeWriter.Write(strQRCode);
            string deskPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            barcodeWriter.Write(strQRCode).Save(deskPath + @"\" + strQRCode + ".jpg");

            //생성된 QR코드 DB에 저장
            MemoryStream ms = new MemoryStream();
            pictureBox_QR.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] img = ms.ToArray();
            cmd.CommandText = " UPDATE ENTERING SET ENT_BARCODE = @img WHERE ENT_NO = '" + tb_ENT_NO.Text + "'";
            cmd.Parameters.Add("@img", MySqlDbType.LongBlob);
            cmd.Parameters["@img"].Value = img;
            cmd.ExecuteNonQuery();
            //System.IO.File.Delete(deskPath + @"\test.jpg");
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            //출력버튼 클릭 시
            PrintDocument tmpDoc = new PrintDocument();
            tmpDoc.PrintPage += new PrintPageEventHandler(Tmpdoc_Print);
            PrintPreviewDialog tmpPpd = new PrintPreviewDialog();
            tmpPpd.Document = tmpDoc;
            tmpPpd.ShowDialog();
        }
        private void Tmpdoc_Print(Object sender, PrintPageEventArgs e)
        {
            //픽쳐박스에 있는 QR코드 출력
            //e.Graphics.DrawImage(pictureBox_QR.Image, 0, 0, 200, 200);
            //글자 입력
            //Font pf = new Font("궁서", 20, FontStyle.Regular);
            //string str = "My name is Dongkyu Lee";
            //e.Graphics.DrawString(str, pf, Brushes.Black, 10, 200);

            //QR코드 읽기
            BarcodeReader B_reader = new BarcodeReader();
            Result result = B_reader.Decode((Bitmap)pictureBox_QR.Image);
            string str = result.Text;

            //기존DB가져오기
            //데이터 조회 쿼리
            string ENT_NO, ENT_DATE, P_ID, ENT_COUNT, ENT_STORAGE, CUS_ID;
            String sql = "SELECT ENT_NO, ENT_DATE, P_ID, ENT_COUNT, ENT_STORAGE, CUS_ID ";
            sql += "FROM ENTERING WHERE ENT_NO =" + "'" + str + "'";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            reader.Read();
            ENT_NO = (String)reader["ENT_NO"];
            ENT_DATE = (String)reader["ENT_DATE"];
            P_ID = (String)reader["P_ID"];
            ENT_COUNT = (String)reader["ENT_COUNT"];
            ENT_STORAGE = (String)reader["ENT_STORAGE"];
            CUS_ID = (String)reader["CUS_ID"];
            reader.Close();

            //표 그리기
            string text1 = "\r\n  입고번호 : " + ENT_NO + "\r\n  입고일자 : " + ENT_DATE + "\r\n  품목코드 : " + P_ID;
            text1 += "\r\n  수량 : " + ENT_COUNT + "\r\n  창고 : " + ENT_STORAGE + "\r\n  거래처번호 : " + CUS_ID;
            using (Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(10, 10, 200, 200);
                e.Graphics.DrawImage(pictureBox_QR.Image, rectF1);
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectF1));

                RectangleF rectF2 = new RectangleF(10, 210, 200, 160);
                e.Graphics.DrawString(text1, font1, Brushes.Black, rectF2);
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectF2));
            }
        }

        //리스트뷰 클릭 시
        private void listview_Entering_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
        private void listview_Entering_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (this.listview_Entering.SelectedIndices.Contains(e.ItemIndex))
            {
                e.SubItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            }
            else
            {
                e.SubItem.BackColor = Color.White;
            }
            e.DrawBackground();
            e.DrawText();
        }
        private void listview_Entering_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_QR.Image = null;
            if (listview_Entering.SelectedItems.Count > 0)
            {
                tb_ENT_NO.Text = listview_Entering.Items[listview_Entering.SelectedItems[0].Index].SubItems[0].Text;
                tb_ENT_DATE.Text = listview_Entering.Items[listview_Entering.SelectedItems[0].Index].SubItems[1].Text;
                tb_P_ID.Text = listview_Entering.Items[listview_Entering.SelectedItems[0].Index].SubItems[2].Text;
                tb_ENT_COUNT.Text = listview_Entering.Items[listview_Entering.SelectedItems[0].Index].SubItems[3].Text;
                tb_ENT_STORAGE.Text = listview_Entering.Items[listview_Entering.SelectedItems[0].Index].SubItems[4].Text;
                tb_CUS_ID.Text = listview_Entering.Items[listview_Entering.SelectedItems[0].Index].SubItems[5].Text;
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
