namespace C_PRL
{
    partial class FormQLSP
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
            label1 = new Label();
            ptb_Mota = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_Ten = new TextBox();
            tb_Soluong = new TextBox();
            tb_Gia = new TextBox();
            cbb_Trangthai = new ComboBox();
            tbt_Timkiem = new TextBox();
            dtg_AllSP = new DataGridView();
            btn_Them = new Button();
            btn_Xoa = new Button();
            Btn_Sua = new Button();
            ((System.ComponentModel.ISupportInitialize)ptb_Mota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_AllSP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 21);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sản phẩm";
            // 
            // ptb_Mota
            // 
            ptb_Mota.BackColor = SystemColors.AppWorkspace;
            ptb_Mota.Location = new Point(22, 63);
            ptb_Mota.Name = "ptb_Mota";
            ptb_Mota.Size = new Size(208, 180);
            ptb_Mota.TabIndex = 1;
            ptb_Mota.TabStop = false;
            ptb_Mota.Click += ptb_Mota_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 63);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 116);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 173);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 4;
            label4.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 228);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 5;
            label5.Text = "Trạng thái";
            // 
            // tb_Ten
            // 
            tb_Ten.Location = new Point(357, 63);
            tb_Ten.Name = "tb_Ten";
            tb_Ten.PlaceholderText = "Nhập tên";
            tb_Ten.Size = new Size(359, 23);
            tb_Ten.TabIndex = 6;
            // 
            // tb_Soluong
            // 
            tb_Soluong.Location = new Point(357, 113);
            tb_Soluong.Name = "tb_Soluong";
            tb_Soluong.PlaceholderText = "Nhập số lượng";
            tb_Soluong.Size = new Size(359, 23);
            tb_Soluong.TabIndex = 7;
            // 
            // tb_Gia
            // 
            tb_Gia.Location = new Point(357, 170);
            tb_Gia.Name = "tb_Gia";
            tb_Gia.PlaceholderText = "Nhập giá";
            tb_Gia.Size = new Size(359, 23);
            tb_Gia.TabIndex = 8;
            // 
            // cbb_Trangthai
            // 
            cbb_Trangthai.FormattingEnabled = true;
            cbb_Trangthai.Location = new Point(357, 225);
            cbb_Trangthai.Name = "cbb_Trangthai";
            cbb_Trangthai.Size = new Size(359, 23);
            cbb_Trangthai.TabIndex = 9;
            cbb_Trangthai.Text = "Chọn trạng thái";
            // 
            // tbt_Timkiem
            // 
            tbt_Timkiem.Location = new Point(22, 312);
            tbt_Timkiem.Name = "tbt_Timkiem";
            tbt_Timkiem.PlaceholderText = "Nhập vào để tìm kiếm";
            tbt_Timkiem.Size = new Size(694, 23);
            tbt_Timkiem.TabIndex = 10;
            // 
            // dtg_AllSP
            // 
            dtg_AllSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_AllSP.Location = new Point(22, 354);
            dtg_AllSP.Name = "dtg_AllSP";
            dtg_AllSP.RowTemplate.Height = 25;
            dtg_AllSP.Size = new Size(694, 162);
            dtg_AllSP.TabIndex = 11;
            dtg_AllSP.CellClick += dtg_AllSP_CellClick_1;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(357, 269);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 23);
            btn_Them.TabIndex = 12;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(641, 269);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 23);
            btn_Xoa.TabIndex = 14;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // Btn_Sua
            // 
            Btn_Sua.Location = new Point(497, 268);
            Btn_Sua.Name = "Btn_Sua";
            Btn_Sua.Size = new Size(75, 23);
            Btn_Sua.TabIndex = 15;
            Btn_Sua.Text = "Sửa";
            Btn_Sua.UseVisualStyleBackColor = true;
            // 
            // FormQLSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 528);
            Controls.Add(Btn_Sua);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(dtg_AllSP);
            Controls.Add(tbt_Timkiem);
            Controls.Add(cbb_Trangthai);
            Controls.Add(tb_Gia);
            Controls.Add(tb_Soluong);
            Controls.Add(tb_Ten);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ptb_Mota);
            Controls.Add(label1);
            Name = "FormQLSP";
            Text = "FormQLSP";
            ((System.ComponentModel.ISupportInitialize)ptb_Mota).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_AllSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox ptb_Mota;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_Ten;
        private TextBox tb_Soluong;
        private TextBox tb_Gia;
        private ComboBox cbb_Trangthai;
        private TextBox tbt_Timkiem;
        private DataGridView dtg_AllSP;
        private Button btn_Them;
        private Button btn_Xoa;
        private Button Btn_Sua;
    }
}