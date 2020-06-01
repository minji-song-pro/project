namespace 미니프로젝트_vol3_2_
{
    partial class 품목정보
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
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_Inquiry = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Open = new System.Windows.Forms.Button();
			this.picturebox_P_IMAGE = new System.Windows.Forms.PictureBox();
			this.btn_Registration = new System.Windows.Forms.Button();
			this.tb_P_PRICE = new System.Windows.Forms.TextBox();
			this.tb_P_UNIT = new System.Windows.Forms.TextBox();
			this.tb_P_STANDARD = new System.Windows.Forms.TextBox();
			this.tb_P_NAME = new System.Windows.Forms.TextBox();
			this.tb_P_ID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturebox_P_IMAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(789, 342);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 15);
			this.label6.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.btn_Inquiry);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Location = new System.Drawing.Point(11, 15);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(770, 571);
			this.panel1.TabIndex = 8;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 58);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 70;
			this.dataGridView1.Size = new System.Drawing.Size(763, 511);
			this.dataGridView1.TabIndex = 9;
			// 
			// btn_Inquiry
			// 
			this.btn_Inquiry.Location = new System.Drawing.Point(680, 6);
			this.btn_Inquiry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Inquiry.Name = "btn_Inquiry";
			this.btn_Inquiry.Size = new System.Drawing.Size(87, 45);
			this.btn_Inquiry.TabIndex = 8;
			this.btn_Inquiry.Text = "조회";
			this.btn_Inquiry.UseVisualStyleBackColor = true;
			this.btn_Inquiry.Click += new System.EventHandler(this.btn_Inquiry_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 15);
			this.label7.TabIndex = 1;
			this.label7.Text = "품목리스트";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_Open);
			this.groupBox1.Controls.Add(this.picturebox_P_IMAGE);
			this.groupBox1.Controls.Add(this.btn_Registration);
			this.groupBox1.Controls.Add(this.tb_P_PRICE);
			this.groupBox1.Controls.Add(this.tb_P_UNIT);
			this.groupBox1.Controls.Add(this.tb_P_STANDARD);
			this.groupBox1.Controls.Add(this.tb_P_NAME);
			this.groupBox1.Controls.Add(this.tb_P_ID);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(791, 64);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(279, 522);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "품목등록";
			// 
			// btn_Open
			// 
			this.btn_Open.Location = new System.Drawing.Point(199, 238);
			this.btn_Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Open.Name = "btn_Open";
			this.btn_Open.Size = new System.Drawing.Size(75, 28);
			this.btn_Open.TabIndex = 28;
			this.btn_Open.Text = "열기";
			this.btn_Open.UseVisualStyleBackColor = true;
			this.btn_Open.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// picturebox_P_IMAGE
			// 
			this.picturebox_P_IMAGE.BackColor = System.Drawing.Color.White;
			this.picturebox_P_IMAGE.ErrorImage = null;
			this.picturebox_P_IMAGE.Location = new System.Drawing.Point(7, 266);
			this.picturebox_P_IMAGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.picturebox_P_IMAGE.Name = "picturebox_P_IMAGE";
			this.picturebox_P_IMAGE.Size = new System.Drawing.Size(266, 184);
			this.picturebox_P_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturebox_P_IMAGE.TabIndex = 35;
			this.picturebox_P_IMAGE.TabStop = false;
			// 
			// btn_Registration
			// 
			this.btn_Registration.Location = new System.Drawing.Point(89, 462);
			this.btn_Registration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Registration.Name = "btn_Registration";
			this.btn_Registration.Size = new System.Drawing.Size(109, 36);
			this.btn_Registration.TabIndex = 29;
			this.btn_Registration.Text = "등록";
			this.btn_Registration.UseVisualStyleBackColor = true;
			this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click_1);
			// 
			// tb_P_PRICE
			// 
			this.tb_P_PRICE.Location = new System.Drawing.Point(91, 194);
			this.tb_P_PRICE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_P_PRICE.Name = "tb_P_PRICE";
			this.tb_P_PRICE.Size = new System.Drawing.Size(174, 25);
			this.tb_P_PRICE.TabIndex = 27;
			// 
			// tb_P_UNIT
			// 
			this.tb_P_UNIT.Location = new System.Drawing.Point(91, 152);
			this.tb_P_UNIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_P_UNIT.Name = "tb_P_UNIT";
			this.tb_P_UNIT.Size = new System.Drawing.Size(174, 25);
			this.tb_P_UNIT.TabIndex = 26;
			// 
			// tb_P_STANDARD
			// 
			this.tb_P_STANDARD.Location = new System.Drawing.Point(91, 112);
			this.tb_P_STANDARD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_P_STANDARD.Name = "tb_P_STANDARD";
			this.tb_P_STANDARD.Size = new System.Drawing.Size(174, 25);
			this.tb_P_STANDARD.TabIndex = 25;
			// 
			// tb_P_NAME
			// 
			this.tb_P_NAME.Location = new System.Drawing.Point(91, 71);
			this.tb_P_NAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_P_NAME.Name = "tb_P_NAME";
			this.tb_P_NAME.Size = new System.Drawing.Size(174, 25);
			this.tb_P_NAME.TabIndex = 24;
			// 
			// tb_P_ID
			// 
			this.tb_P_ID.Location = new System.Drawing.Point(91, 30);
			this.tb_P_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_P_ID.Name = "tb_P_ID";
			this.tb_P_ID.Size = new System.Drawing.Size(174, 25);
			this.tb_P_ID.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(42, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 15);
			this.label5.TabIndex = 30;
			this.label5.Text = "단가";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 31;
			this.label4.Text = "단위";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 15);
			this.label3.TabIndex = 32;
			this.label3.Text = "규격";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 33;
			this.label2.Text = "품목명";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 34;
			this.label1.Text = "품목코드";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::미니프로젝트_vol3_2_.Properties.Resources.icons8_cancel_30;
			this.pictureBox1.Location = new System.Drawing.Point(1033, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 44);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// 품목정보
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(144)))));
			this.ClientSize = new System.Drawing.Size(1082, 600);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "품목정보";
			this.Text = "품목정보";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.품목정보_FormClosed);
			this.Load += new System.EventHandler(this.품목정보_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturebox_P_IMAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.PictureBox picturebox_P_IMAGE;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.TextBox tb_P_PRICE;
        private System.Windows.Forms.TextBox tb_P_UNIT;
        private System.Windows.Forms.TextBox tb_P_STANDARD;
        private System.Windows.Forms.TextBox tb_P_NAME;
        private System.Windows.Forms.TextBox tb_P_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Inquiry;
    }
}