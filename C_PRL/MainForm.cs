namespace C_PRL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            //btn_sanpham.BackColor = Color.LightBlue;
            //btn_sanpham.ForeColor = Color.White;
            //btn_sanpham.Font = new Font("Arial", 12, FontStyle.Bold);
            //btn_sanpham.FlatStyle = FlatStyle.Flat;
            //btn_sanpham.FlatAppearance.BorderSize = 1;
            //btn_sanpham.FlatAppearance.BorderColor = Color.DarkBlue;
            //tableLayoutPanel1.Controls.Clear();
            //FormNV formNV = new FormNV();
            //formNV.TopLevel = false;
            //formNV.FormBorderStyle = FormBorderStyle.None;
            //tableLayoutPanel1.RowCount = 1;
            //tableLayoutPanel1.ColumnCount = 1;
            //tableLayoutPanel1.Controls.Add(formNV);
            //formNV.Show();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
