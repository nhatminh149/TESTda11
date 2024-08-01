namespace C_PRL
{
    partial class FormNV
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
            pictureBox1 = new PictureBox();
            txt_ma = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_email = new TextBox();
            txt_vitri = new TextBox();
            txt_pass = new TextBox();
            txt_search = new TextBox();
            txt_ten = new TextBox();
            txt_sdt = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label8 = new Label();
            label7 = new Label();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_capnhat = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(614, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 235);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_ma
            // 
            txt_ma.Cursor = Cursors.IBeam;
            txt_ma.ForeColor = SystemColors.WindowText;
            txt_ma.Location = new Point(106, 4);
            txt_ma.Margin = new Padding(3, 4, 3, 4);
            txt_ma.Multiline = true;
            txt_ma.Name = "txt_ma";
            txt_ma.PlaceholderText = "Nhập mã nhân viên";
            txt_ma.Size = new Size(370, 30);
            txt_ma.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 2;
            label1.Text = "Mã NV :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 108);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 2;
            label3.Text = "SDT :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 153);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 2;
            label4.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 279);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 2;
            label5.Text = "Vị Trí :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 194);
            label6.Name = "label6";
            label6.Size = new Size(90, 19);
            label6.TabIndex = 2;
            label6.Text = "Password :";
            // 
            // txt_email
            // 
            txt_email.ForeColor = SystemColors.WindowText;
            txt_email.Location = new Point(106, 142);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Nhập địa chỉ email";
            txt_email.Size = new Size(370, 30);
            txt_email.TabIndex = 3;
            // 
            // txt_vitri
            // 
            txt_vitri.ForeColor = SystemColors.WindowText;
            txt_vitri.Location = new Point(106, 279);
            txt_vitri.Multiline = true;
            txt_vitri.Name = "txt_vitri";
            txt_vitri.PlaceholderText = "Vị trí hiện tại";
            txt_vitri.Size = new Size(370, 121);
            txt_vitri.TabIndex = 4;
            // 
            // txt_pass
            // 
            txt_pass.ForeColor = SystemColors.WindowText;
            txt_pass.Location = new Point(106, 183);
            txt_pass.Multiline = true;
            txt_pass.Name = "txt_pass";
            txt_pass.PlaceholderText = "Nhập password";
            txt_pass.Size = new Size(370, 30);
            txt_pass.TabIndex = 5;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(84, 421);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(441, 27);
            txt_search.TabIndex = 6;
            // 
            // txt_ten
            // 
            txt_ten.ForeColor = SystemColors.WindowText;
            txt_ten.Location = new Point(106, 51);
            txt_ten.Multiline = true;
            txt_ten.Name = "txt_ten";
            txt_ten.PlaceholderText = "Nhập họ tên nhân viên";
            txt_ten.Size = new Size(370, 30);
            txt_ten.TabIndex = 7;
            // 
            // txt_sdt
            // 
            txt_sdt.ForeColor = SystemColors.WindowText;
            txt_sdt.Location = new Point(106, 97);
            txt_sdt.Multiline = true;
            txt_sdt.Name = "txt_sdt";
            txt_sdt.PlaceholderText = "Nhận số điện thoại";
            txt_sdt.Size = new Size(370, 30);
            txt_sdt.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 454);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1077, 217);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_sdt);
            panel1.Controls.Add(txt_pass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_vitri);
            panel1.Controls.Add(txt_ten);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_ma);
            panel1.Location = new Point(32, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 403);
            panel1.TabIndex = 10;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(240, 236);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(125, 234);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 239);
            label8.Name = "label8";
            label8.Size = new Size(82, 19);
            label8.TabIndex = 2;
            label8.Text = "Giới tính :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 429);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 2;
            label7.Text = "Search";
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_them.Location = new Point(571, 266);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(158, 63);
            btn_them.TabIndex = 11;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sua.Location = new Point(756, 266);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(149, 63);
            btn_sua.TabIndex = 12;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoa.Location = new Point(571, 352);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(158, 71);
            btn_xoa.TabIndex = 13;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_capnhat
            // 
            btn_capnhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_capnhat.Location = new Point(756, 352);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(149, 71);
            btn_capnhat.TabIndex = 14;
            btn_capnhat.Text = "Cập nhật";
            btn_capnhat.UseVisualStyleBackColor = true;
            btn_capnhat.Click += btn_capnhat_Click;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // FormNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 673);
            Controls.Add(btn_capnhat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(txt_search);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Name = "FormNV";
            Text = "Quản lý nhân viên";
            Load += FormNV_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_ma;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_email;
        private TextBox txt_vitri;
        private TextBox txt_pass;
        private TextBox txt_search;
        private TextBox txt_ten;
        private TextBox txt_sdt;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label7;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_capnhat;
        private Label label8;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}