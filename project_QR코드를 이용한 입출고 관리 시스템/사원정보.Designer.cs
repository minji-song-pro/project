namespace 미니프로젝트_vol3_2_
{
    partial class 사원정보
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
            this.label7 = new System.Windows.Forms.Label();
            this.listview_Employee = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.tb_EMP_PHONE = new System.Windows.Forms.TextBox();
            this.tb_EMP_POSITION = new System.Windows.Forms.TextBox();
            this.tb_EMP_DEPARTMENT = new System.Windows.Forms.TextBox();
            this.tb_EMP_RRN = new System.Windows.Forms.TextBox();
            this.tb_EMP_NAME = new System.Windows.Forms.TextBox();
            this.tb_EMP_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.listview_Employee);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 431);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "사원리스트";
            // 
            // listview_Employee
            // 
            this.listview_Employee.HideSelection = false;
            this.listview_Employee.Location = new System.Drawing.Point(2, 68);
            this.listview_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview_Employee.Name = "listview_Employee";
            this.listview_Employee.Size = new System.Drawing.Size(603, 363);
            this.listview_Employee.TabIndex = 0;
            this.listview_Employee.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Registration);
            this.groupBox1.Controls.Add(this.tb_EMP_PHONE);
            this.groupBox1.Controls.Add(this.tb_EMP_POSITION);
            this.groupBox1.Controls.Add(this.tb_EMP_DEPARTMENT);
            this.groupBox1.Controls.Add(this.tb_EMP_RRN);
            this.groupBox1.Controls.Add(this.tb_EMP_NAME);
            this.groupBox1.Controls.Add(this.tb_EMP_ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(640, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(277, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사원등록";
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(82, 301);
            this.btn_Registration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(109, 48);
            this.btn_Registration.TabIndex = 20;
            this.btn_Registration.Text = "등록";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // tb_EMP_PHONE
            // 
            this.tb_EMP_PHONE.Location = new System.Drawing.Point(91, 238);
            this.tb_EMP_PHONE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EMP_PHONE.Name = "tb_EMP_PHONE";
            this.tb_EMP_PHONE.Size = new System.Drawing.Size(174, 25);
            this.tb_EMP_PHONE.TabIndex = 19;
            // 
            // tb_EMP_POSITION
            // 
            this.tb_EMP_POSITION.Location = new System.Drawing.Point(91, 198);
            this.tb_EMP_POSITION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EMP_POSITION.Name = "tb_EMP_POSITION";
            this.tb_EMP_POSITION.Size = new System.Drawing.Size(174, 25);
            this.tb_EMP_POSITION.TabIndex = 18;
            // 
            // tb_EMP_DEPARTMENT
            // 
            this.tb_EMP_DEPARTMENT.Location = new System.Drawing.Point(91, 158);
            this.tb_EMP_DEPARTMENT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EMP_DEPARTMENT.Name = "tb_EMP_DEPARTMENT";
            this.tb_EMP_DEPARTMENT.Size = new System.Drawing.Size(174, 25);
            this.tb_EMP_DEPARTMENT.TabIndex = 17;
            // 
            // tb_EMP_RRN
            // 
            this.tb_EMP_RRN.Location = new System.Drawing.Point(91, 118);
            this.tb_EMP_RRN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EMP_RRN.Name = "tb_EMP_RRN";
            this.tb_EMP_RRN.Size = new System.Drawing.Size(174, 25);
            this.tb_EMP_RRN.TabIndex = 16;
            // 
            // tb_EMP_NAME
            // 
            this.tb_EMP_NAME.Location = new System.Drawing.Point(91, 78);
            this.tb_EMP_NAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EMP_NAME.Name = "tb_EMP_NAME";
            this.tb_EMP_NAME.Size = new System.Drawing.Size(174, 25);
            this.tb_EMP_NAME.TabIndex = 15;
            // 
            // tb_EMP_ID
            // 
            this.tb_EMP_ID.Location = new System.Drawing.Point(91, 38);
            this.tb_EMP_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EMP_ID.Name = "tb_EMP_ID";
            this.tb_EMP_ID.Size = new System.Drawing.Size(174, 25);
            this.tb_EMP_ID.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "연락처";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "직급";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "부서";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "주민번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "성명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "사원번호";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::미니프로젝트_vol3_2_.Properties.Resources.icons8_cancel_30;
            this.pictureBox1.Location = new System.Drawing.Point(878, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // 사원정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(928, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "사원정보";
            this.Text = "사원현황";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.사원현황_FormClosed);
            this.Load += new System.EventHandler(this.사원현황_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listview_Employee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.TextBox tb_EMP_PHONE;
        private System.Windows.Forms.TextBox tb_EMP_POSITION;
        private System.Windows.Forms.TextBox tb_EMP_DEPARTMENT;
        private System.Windows.Forms.TextBox tb_EMP_RRN;
        private System.Windows.Forms.TextBox tb_EMP_NAME;
        private System.Windows.Forms.TextBox tb_EMP_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}