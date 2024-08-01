namespace C_PRL
{
    partial class FormSanPham
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
            btn_ShowSP = new Button();
            btn_QLSP = new Button();
            tlp_SanPham = new TableLayoutPanel();
            lb_back = new Label();
            lb_page = new Label();
            lb_next = new Label();
            SuspendLayout();
            // 
            // btn_ShowSP
            // 
            btn_ShowSP.Location = new Point(18, 12);
            btn_ShowSP.Name = "btn_ShowSP";
            btn_ShowSP.Size = new Size(117, 23);
            btn_ShowSP.TabIndex = 0;
            btn_ShowSP.Text = "Hiển thị SP";
            btn_ShowSP.UseVisualStyleBackColor = true;
            btn_ShowSP.Click += btn_ShowSP_Click;
            // 
            // btn_QLSP
            // 
            btn_QLSP.Location = new Point(168, 12);
            btn_QLSP.Name = "btn_QLSP";
            btn_QLSP.Size = new Size(115, 23);
            btn_QLSP.TabIndex = 1;
            btn_QLSP.Text = "Quản lý SP";
            btn_QLSP.UseVisualStyleBackColor = true;
            btn_QLSP.Click += btn_QLSP_Click;
            // 
            // tlp_SanPham
            // 
            tlp_SanPham.ColumnCount = 2;
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.Location = new Point(18, 44);
            tlp_SanPham.Name = "tlp_SanPham";
            tlp_SanPham.RowCount = 2;
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.Size = new Size(835, 467);
            tlp_SanPham.TabIndex = 2;
            // 
            // lb_back
            // 
            lb_back.AutoSize = true;
            lb_back.Location = new Point(326, 526);
            lb_back.Name = "lb_back";
            lb_back.Size = new Size(31, 15);
            lb_back.TabIndex = 3;
            lb_back.Text = "<<<";
            lb_back.Click += lb_back_Click;
            // 
            // lb_page
            // 
            lb_page.AutoSize = true;
            lb_page.Location = new Point(429, 526);
            lb_page.Name = "lb_page";
            lb_page.Size = new Size(13, 15);
            lb_page.TabIndex = 4;
            lb_page.Text = "1";
            // 
            // lb_next
            // 
            lb_next.AutoSize = true;
            lb_next.Location = new Point(516, 526);
            lb_next.Name = "lb_next";
            lb_next.Size = new Size(31, 15);
            lb_next.TabIndex = 5;
            lb_next.Text = ">>>";
            lb_next.Click += lb_next_Click;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 561);
            Controls.Add(lb_next);
            Controls.Add(lb_page);
            Controls.Add(lb_back);
            Controls.Add(tlp_SanPham);
            Controls.Add(btn_QLSP);
            Controls.Add(btn_ShowSP);
            Name = "FormSanPham";
            Text = "FormSanPham";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ShowSP;
        private Button btn_QLSP;
        private TableLayoutPanel tlp_SanPham;
        private Label lb_back;
        private Label lb_page;
        private Label lb_next;
    }
}