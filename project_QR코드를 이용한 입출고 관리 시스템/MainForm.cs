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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            사원정보 form_employee = new 사원정보();
            form_employee.Show();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            거래처정보 form_customer = new 거래처정보();
            form_customer.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            품목정보 form_item = new 품목정보();
            form_item.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            입고정보 form_entering = new 입고정보();
            form_entering.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            QR코드생성 form_QR_Create = new QR코드생성();
            form_QR_Create.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            출고정보_QR읽기 form_releasing = new 출고정보_QR읽기();
            form_releasing.Show();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
