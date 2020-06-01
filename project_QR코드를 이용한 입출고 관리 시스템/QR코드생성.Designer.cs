namespace 미니프로젝트_vol3_2_
{
    partial class QR코드생성
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.listview_Entering = new System.Windows.Forms.ListView();
			this.label8 = new System.Windows.Forms.Label();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox_QR = new System.Windows.Forms.PictureBox();
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.listview_Entering);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Location = new System.Drawing.Point(11, 39);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(617, 645);
			this.panel1.TabIndex = 45;
			// 
			// listview_Entering
			// 
			this.listview_Entering.FullRowSelect = true;
			this.listview_Entering.HideSelection = false;
			this.listview_Entering.Location = new System.Drawing.Point(3, 35);
			this.listview_Entering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listview_Entering.Name = "listview_Entering";
			this.listview_Entering.OwnerDraw = true;
			this.listview_Entering.Size = new System.Drawing.Size(603, 610);
			this.listview_Entering.TabIndex = 3;
			this.listview_Entering.UseCompatibleStateImageBehavior = false;
			this.listview_Entering.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listview_Entering_DrawColumnHeader);
			this.listview_Entering.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listview_Entering_DrawSubItem);
			this.listview_Entering.SelectedIndexChanged += new System.EventHandler(this.listview_Entering_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 15);
			this.label8.TabIndex = 1;
			this.label8.Text = "입고리스트";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.pictureBox_QR);
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
			this.groupBox1.Location = new System.Drawing.Point(635, 65);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(306, 620);
			this.groupBox1.TabIndex = 46;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "QR코드생성";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(157, 269);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 48);
			this.button1.TabIndex = 62;
			this.button1.Text = "출력";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_2);
			// 
			// pictureBox_QR
			// 
			this.pictureBox_QR.BackColor = System.Drawing.Color.White;
			this.pictureBox_QR.Location = new System.Drawing.Point(18, 332);
			this.pictureBox_QR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox_QR.Name = "pictureBox_QR";
			this.pictureBox_QR.Size = new System.Drawing.Size(270, 270);
			this.pictureBox_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_QR.TabIndex = 61;
			this.pictureBox_QR.TabStop = false;
			// 
			// btn_Registration
			// 
			this.btn_Registration.Location = new System.Drawing.Point(42, 269);
			this.btn_Registration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Registration.Name = "btn_Registration";
			this.btn_Registration.Size = new System.Drawing.Size(109, 48);
			this.btn_Registration.TabIndex = 60;
			this.btn_Registration.Text = "QR코드생성";
			this.btn_Registration.UseVisualStyleBackColor = true;
			this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click_1);
			// 
			// tb_CUS_ID
			// 
			this.tb_CUS_ID.Location = new System.Drawing.Point(113, 222);
			this.tb_CUS_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_CUS_ID.Name = "tb_CUS_ID";
			this.tb_CUS_ID.Size = new System.Drawing.Size(174, 25);
			this.tb_CUS_ID.TabIndex = 57;
			// 
			// tb_ENT_COUNT
			// 
			this.tb_ENT_COUNT.Location = new System.Drawing.Point(113, 148);
			this.tb_ENT_COUNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ENT_COUNT.Name = "tb_ENT_COUNT";
			this.tb_ENT_COUNT.Size = new System.Drawing.Size(174, 25);
			this.tb_ENT_COUNT.TabIndex = 58;
			// 
			// tb_P_ID
			// 
			this.tb_P_ID.Location = new System.Drawing.Point(113, 111);
			this.tb_P_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_P_ID.Name = "tb_P_ID";
			this.tb_P_ID.Size = new System.Drawing.Size(174, 25);
			this.tb_P_ID.TabIndex = 59;
			// 
			// tb_ENT_STORAGE
			// 
			this.tb_ENT_STORAGE.Location = new System.Drawing.Point(113, 185);
			this.tb_ENT_STORAGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ENT_STORAGE.Name = "tb_ENT_STORAGE";
			this.tb_ENT_STORAGE.Size = new System.Drawing.Size(174, 25);
			this.tb_ENT_STORAGE.TabIndex = 56;
			// 
			// tb_ENT_DATE
			// 
			this.tb_ENT_DATE.Location = new System.Drawing.Point(113, 74);
			this.tb_ENT_DATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ENT_DATE.Name = "tb_ENT_DATE";
			this.tb_ENT_DATE.Size = new System.Drawing.Size(174, 25);
			this.tb_ENT_DATE.TabIndex = 55;
			// 
			// tb_ENT_NO
			// 
			this.tb_ENT_NO.Location = new System.Drawing.Point(113, 38);
			this.tb_ENT_NO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ENT_NO.Name = "tb_ENT_NO";
			this.tb_ENT_NO.Size = new System.Drawing.Size(174, 25);
			this.tb_ENT_NO.TabIndex = 54;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 15);
			this.label7.TabIndex = 48;
			this.label7.Text = "거래처번호";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(63, 151);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 15);
			this.label6.TabIndex = 49;
			this.label6.Text = "수량";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 50;
			this.label5.Text = "품목코드";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(63, 188);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 51;
			this.label4.Text = "창고";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 52;
			this.label3.Text = "입고일자";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 53;
			this.label2.Text = "입고번호";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::미니프로젝트_vol3_2_.Properties.Resources.icons8_cancel_30;
			this.pictureBox1.Location = new System.Drawing.Point(905, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 44);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 47;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// QR코드생성
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(144)))));
			this.ClientSize = new System.Drawing.Size(953, 698);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "QR코드생성";
			this.Text = "QR코드생성";
			this.Load += new System.EventHandler(this.바코드생성_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listview_Entering;
        private System.Windows.Forms.Label label8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox_QR;
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}