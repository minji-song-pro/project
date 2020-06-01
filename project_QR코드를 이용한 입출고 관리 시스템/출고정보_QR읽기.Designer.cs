namespace 미니프로젝트_vol3_2_
{
    partial class 출고정보_QR읽기
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.listview_Releasing = new System.Windows.Forms.ListView();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.tb_OUT_DATE = new System.Windows.Forms.TextBox();
			this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Registration = new System.Windows.Forms.Button();
			this.tb_CUS_ID = new System.Windows.Forms.TextBox();
			this.tb_ENT_COUNT = new System.Windows.Forms.TextBox();
			this.tb_P_ID = new System.Windows.Forms.TextBox();
			this.tb_ENT_STORAGE = new System.Windows.Forms.TextBox();
			this.tb_ENT_DATE = new System.Windows.Forms.TextBox();
			this.tb_ENT_NO = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.listview_Releasing);
			this.panel1.Location = new System.Drawing.Point(391, 59);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(751, 654);
			this.panel1.TabIndex = 64;
			// 
			// listview_Releasing
			// 
			this.listview_Releasing.HideSelection = false;
			this.listview_Releasing.Location = new System.Drawing.Point(3, 0);
			this.listview_Releasing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listview_Releasing.Name = "listview_Releasing";
			this.listview_Releasing.Size = new System.Drawing.Size(745, 649);
			this.listview_Releasing.TabIndex = 3;
			this.listview_Releasing.UseCompatibleStateImageBehavior = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(388, 38);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 15);
			this.label8.TabIndex = 1;
			this.label8.Text = "출고리스트";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.tb_OUT_DATE);
			this.groupBox1.Controls.Add(this.pictureBoxIpl1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btn_Registration);
			this.groupBox1.Controls.Add(this.tb_CUS_ID);
			this.groupBox1.Controls.Add(this.tb_ENT_COUNT);
			this.groupBox1.Controls.Add(this.tb_P_ID);
			this.groupBox1.Controls.Add(this.tb_ENT_STORAGE);
			this.groupBox1.Controls.Add(this.tb_ENT_DATE);
			this.groupBox1.Controls.Add(this.tb_ENT_NO);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(17, 46);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(330, 667);
			this.groupBox1.TabIndex = 65;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "출고등록";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(202, 13);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(111, 38);
			this.button3.TabIndex = 50;
			this.button3.Text = "QR코드 읽기";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// tb_OUT_DATE
			// 
			this.tb_OUT_DATE.Location = new System.Drawing.Point(138, 553);
			this.tb_OUT_DATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_OUT_DATE.Name = "tb_OUT_DATE";
			this.tb_OUT_DATE.Size = new System.Drawing.Size(174, 25);
			this.tb_OUT_DATE.TabIndex = 81;
			// 
			// pictureBoxIpl1
			// 
			this.pictureBoxIpl1.BackColor = System.Drawing.Color.White;
			this.pictureBoxIpl1.Location = new System.Drawing.Point(17, 55);
			this.pictureBoxIpl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBoxIpl1.Name = "pictureBoxIpl1";
			this.pictureBoxIpl1.Size = new System.Drawing.Size(295, 252);
			this.pictureBoxIpl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxIpl1.TabIndex = 49;
			this.pictureBoxIpl1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 556);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 80;
			this.label1.Text = "출고일자";
			// 
			// btn_Registration
			// 
			this.btn_Registration.Location = new System.Drawing.Point(122, 601);
			this.btn_Registration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Registration.Name = "btn_Registration";
			this.btn_Registration.Size = new System.Drawing.Size(109, 48);
			this.btn_Registration.TabIndex = 79;
			this.btn_Registration.Text = "출고등록";
			this.btn_Registration.UseVisualStyleBackColor = true;
			this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click_1);
			// 
			// tb_CUS_ID
			// 
			this.tb_CUS_ID.Enabled = false;
			this.tb_CUS_ID.Location = new System.Drawing.Point(138, 516);
			this.tb_CUS_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_CUS_ID.Name = "tb_CUS_ID";
			this.tb_CUS_ID.Size = new System.Drawing.Size(174, 25);
			this.tb_CUS_ID.TabIndex = 76;
			// 
			// tb_ENT_COUNT
			// 
			this.tb_ENT_COUNT.Enabled = false;
			this.tb_ENT_COUNT.Location = new System.Drawing.Point(138, 442);
			this.tb_ENT_COUNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ENT_COUNT.Name = "tb_ENT_COUNT";
			this.tb_ENT_COUNT.Size = new System.Drawing.Size(174, 25);
			this.tb_ENT_COUNT.TabIndex = 77;
			// 
			// tb_P_ID
			// 
			this.tb_P_ID.Enabled = false;
			this.tb_P_ID.Location = new System.Drawing.Point(138, 405);
			this.tb_P_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_P_ID.Name = "tb_P_ID";
			this.tb_P_ID.Size = new System.Drawing.Size(174, 25);
			this.tb_P_ID.TabIndex = 78;
			// 
			// tb_ENT_STORAGE
			// 
			this.tb_ENT_STORAGE.Enabled = false;
			this.tb_ENT_STORAGE.Location = new System.Drawing.Point(138, 479);
			this.tb_ENT_STORAGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ENT_STORAGE.Name = "tb_ENT_STORAGE";
			this.tb_ENT_STORAGE.Size = new System.Drawing.Size(174, 25);
			this.tb_ENT_STORAGE.TabIndex = 75;
			// 
			// tb_ENT_DATE
			// 
			this.tb_ENT_DATE.Enabled = false;
			this.tb_ENT_DATE.Location = new System.Drawing.Point(138, 368);
			this.tb_ENT_DATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ENT_DATE.Name = "tb_ENT_DATE";
			this.tb_ENT_DATE.Size = new System.Drawing.Size(174, 25);
			this.tb_ENT_DATE.TabIndex = 74;
			// 
			// tb_ENT_NO
			// 
			this.tb_ENT_NO.Enabled = false;
			this.tb_ENT_NO.Location = new System.Drawing.Point(138, 332);
			this.tb_ENT_NO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ENT_NO.Name = "tb_ENT_NO";
			this.tb_ENT_NO.Size = new System.Drawing.Size(174, 25);
			this.tb_ENT_NO.TabIndex = 73;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(43, 519);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 15);
			this.label7.TabIndex = 67;
			this.label7.Text = "거래처번호";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(88, 445);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 15);
			this.label6.TabIndex = 68;
			this.label6.Text = "수량";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(58, 408);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 69;
			this.label5.Text = "품목코드";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(88, 482);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 70;
			this.label4.Text = "창고";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(58, 372);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 71;
			this.label3.Text = "입고일자";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 334);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 72;
			this.label2.Text = "입고번호";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 33;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::미니프로젝트_vol3_2_.Properties.Resources.icons8_cancel_30;
			this.pictureBox1.Location = new System.Drawing.Point(1102, 9);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 44);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 84;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// 출고정보_QR읽기
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(144)))));
			this.ClientSize = new System.Drawing.Size(1175, 721);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "출고정보_QR읽기";
			this.Text = "출고정보_Ver.Cam";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.출고정보_QR읽기_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.출고정보_QR읽기_FormClosed);
			this.Load += new System.EventHandler(this.출고정보_QR읽기_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listview_Releasing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_OUT_DATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.TextBox tb_CUS_ID;
        private System.Windows.Forms.TextBox tb_ENT_COUNT;
        private System.Windows.Forms.TextBox tb_P_ID;
        private System.Windows.Forms.TextBox tb_ENT_STORAGE;
        private System.Windows.Forms.TextBox tb_ENT_DATE;
        private System.Windows.Forms.TextBox tb_ENT_NO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}