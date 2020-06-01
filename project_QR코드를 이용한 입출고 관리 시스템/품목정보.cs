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

namespace 미니프로젝트_vol3_2_
{
    public partial class 품목정보 : Form
    {
        public 품목정보()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Uid=root;Pwd=1234;Database=MES_db;CHARSET=UTF8");
        MySqlCommand cmd;
        MySqlDataAdapter da;

        private void 품목정보_Load(object sender, EventArgs e)
        {
            string sql = "SELECT P_ID, P_NAME, P_STANDARD, P_UNIT, P_PRICE, P_IMAGE FROM PRODUCT";
            cmd = new MySqlCommand(sql, conn);
            da = new MySqlDataAdapter(cmd);
            //그리드뷰에 DB뿌리기
            //DataTable table = new DataTable();
            //da.Fill(table);
            //dataGridView1.DataSource = table;

            //그리드뷰에 사이즈 조정하여 DB뿌리기
            DataSet ds = new DataSet();
            da.Fill(ds, "PRODUCT");
            DataGridViewImageColumn photoColumn = new DataGridViewImageColumn();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            photoColumn.DataPropertyName = "P_IMAGE";
            photoColumn.Width = 200;
            photoColumn.HeaderText = "P_IMAGE";
            photoColumn.ReadOnly = true;
            photoColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns.Insert(5, photoColumn);
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[6].Visible = false;
        }
        private void 품목정보_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
        private void button1_Click_1(object sender, EventArgs e) 
        {
            //품목이미지 열기
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "";
            ofd.Filter = "Color File(*.png;*.jpg;*.bmp;*.tif) | *.png;*.jpg;*.bmp;*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picturebox_P_IMAGE.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_Registration_Click_1(object sender, EventArgs e)
        {
            //품목 등록
            MemoryStream ms = new MemoryStream();
            picturebox_P_IMAGE.Image.Save(ms, picturebox_P_IMAGE.Image.RawFormat);
            byte[] img = ms.ToArray();

            string sql = "INSERT INTO PRODUCT(P_ID, P_NAME, P_STANDARD, P_UNIT, P_PRICE, P_IMAGE) ";
            sql += "Values (@P_ID, @P_NAME, @P_STANDARD, @P_UNIT, @P_PRICE, @P_IMAGE)";
            conn.Open();
            cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.Add("@P_ID", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("@P_NAME", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("@P_STANDARD", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("@P_UNIT", MySqlDbType.VarChar, 5);
            cmd.Parameters.Add("@P_PRICE", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("@P_IMAGE", MySqlDbType.LongBlob);

            cmd.Parameters["@P_ID"].Value = tb_P_ID.Text;
            cmd.Parameters["@P_NAME"].Value = tb_P_NAME.Text;
            cmd.Parameters["@P_STANDARD"].Value = tb_P_STANDARD.Text;
            cmd.Parameters["@P_UNIT"].Value = tb_P_UNIT.Text;
            cmd.Parameters["@P_PRICE"].Value = tb_P_PRICE.Text;
            cmd.Parameters["@P_IMAGE"].Value = img;

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("등록되었습니다.");
            }
            conn.Close();

            btn_Inquiry.PerformClick();

            tb_P_ID.Text = "";
            tb_P_NAME.Text = "";
            tb_P_STANDARD.Text = "";
            tb_P_UNIT.Text = "";
            tb_P_PRICE.Text = "";
            picturebox_P_IMAGE.Image = null;
        }
        private void btn_Inquiry_Click(object sender, EventArgs e)
        {
            //데이터그리드뷰 조회
            string sql = "SELECT P_ID, P_NAME, P_STANDARD, P_UNIT, P_PRICE, P_IMAGE FROM PRODUCT";
            cmd = new MySqlCommand(sql, conn);
            da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
