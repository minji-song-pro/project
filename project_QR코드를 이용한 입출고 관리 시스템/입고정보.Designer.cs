namespace 미니프로젝트_vol3_2_
{
    partial class 입고정보
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_CUS_ID = new System.Windows.Forms.ComboBox();
            this.cb_P_ID = new System.Windows.Forms.ComboBox();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.tb_ENT_COUNT = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listview_Entering);
            this.panel1.Location = new System.Drawing.Point(11, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 342);
            this.panel1.TabIndex = 31;
            // 
            // listview_Entering
            // 
            this.listview_Entering.HideSelection = false;
            this.listview_Entering.Location = new System.Drawing.Point(0, 2);
            this.listview_Entering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview_Entering.Name = "listview_Entering";
            this.listview_Entering.Size = new System.Drawing.Size(614, 338);
            this.listview_Entering.TabIndex = 9;
            this.listview_Entering.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "입고리스트";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_CUS_ID);
            this.groupBox1.Controls.Add(this.cb_P_ID);
            this.groupBox1.Controls.Add(this.btn_Registration);
            this.groupBox1.Controls.Add(this.tb_ENT_COUNT);
            this.groupBox1.Controls.Add(this.tb_ENT_STORAGE);
            this.groupBox1.Controls.Add(this.tb_ENT_DATE);
            this.groupBox1.Controls.Add(this.tb_ENT_NO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(642, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(301, 352);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입고등록";
            // 
            // cb_CUS_ID
            // 
            this.cb_CUS_ID.FormattingEnabled = true;
            this.cb_CUS_ID.Location = new System.Drawing.Point(101, 225);
            this.cb_CUS_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_CUS_ID.Name = "cb_CUS_ID";
            this.cb_CUS_ID.Size = new System.Drawing.Size(174, 23);
            this.cb_CUS_ID.TabIndex = 30;
            // 
            // cb_P_ID
            // 
            this.cb_P_ID.FormattingEnabled = true;
            this.cb_P_ID.Location = new System.Drawing.Point(101, 116);
            this.cb_P_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_P_ID.Name = "cb_P_ID";
            this.cb_P_ID.Size = new System.Drawing.Size(174, 23);
            this.cb_P_ID.TabIndex = 27;
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(96, 275);
            this.btn_Registration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(109, 48);
            this.btn_Registration.TabIndex = 31;
            this.btn_Registration.Text = "등록";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click_1);
            // 
            // tb_ENT_COUNT
            // 
            this.tb_ENT_COUNT.Location = new System.Drawing.Point(101, 151);
            this.tb_ENT_COUNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ENT_COUNT.Name = "tb_ENT_COUNT";
            this.tb_ENT_COUNT.Size = new System.Drawing.Size(174, 25);
            this.tb_ENT_COUNT.TabIndex = 28;
            // 
            // tb_ENT_STORAGE
            // 
            this.tb_ENT_STORAGE.Location = new System.Drawing.Point(101, 188);
            this.tb_ENT_STORAGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ENT_STORAGE.Name = "tb_ENT_STORAGE";
            this.tb_ENT_STORAGE.Size = new System.Drawing.Size(174, 25);
            this.tb_ENT_STORAGE.TabIndex = 29;
            // 
            // tb_ENT_DATE
            // 
            this.tb_ENT_DATE.Location = new System.Drawing.Point(101, 79);
            this.tb_ENT_DATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ENT_DATE.Name = "tb_ENT_DATE";
            this.tb_ENT_DATE.Size = new System.Drawing.Size(174, 25);
            this.tb_ENT_DATE.TabIndex = 26;
            // 
            // tb_ENT_NO
            // 
            this.tb_ENT_NO.Location = new System.Drawing.Point(101, 42);
            this.tb_ENT_NO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ENT_NO.Name = "tb_ENT_NO";
            this.tb_ENT_NO.Size = new System.Drawing.Size(174, 25);
            this.tb_ENT_NO.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "거래처번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "수량";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "품목코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "창고";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "입고일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "입고번호";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::미니프로젝트_vol3_2_.Properties.Resources.icons8_cancel_30;
            this.pictureBox1.Location = new System.Drawing.Point(909, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // 입고정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(949, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "입고정보";
            this.Text = "입고정보";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.입고정보_FormClosed);
            this.Load += new System.EventHandler(this.입고정보_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listview_Entering;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_CUS_ID;
        private System.Windows.Forms.ComboBox cb_P_ID;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.TextBox tb_ENT_COUNT;
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