using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_BUS.Services;
using A_DAL.Models;

namespace C_PRL
{
    public partial class FormQLSP : Form
    {
        SanPhamServices _services;
        public FormQLSP()
        {
            _services = new SanPhamServices();
            InitializeComponent();
            ptb_Mota.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string ten = tb_Ten.Text; int gia = Convert.ToInt32(tb_Gia.Text);
            int soluong = Convert.ToInt32(tb_Soluong.Text);
            string mota = ptb_Mota.ImageLocation;
            string thuoctinh = cbb_Trangthai.Text;
            SanPham sp = new SanPham() { GiaNhap = gia, TenSanPham = ten, SoLuong = soluong, MoTa = mota, ThuocTinh = thuoctinh };
            MessageBox.Show(_services.Create(sp));
            LoadDataToGridView();
        }

        public void LoadDataToGridView()
        {
            dtg_AllSP.Rows.Clear();
            var allDatas = _services.GetAll();
            dtg_AllSP.ColumnCount = 6;
            dtg_AllSP.Columns[0].HeaderText = "Id";
            dtg_AllSP.Columns[1].HeaderText = "Tên sản phẩm";
            dtg_AllSP.Columns[2].HeaderText = "Giá";
            dtg_AllSP.Columns[3].HeaderText = "Số lượng";
            dtg_AllSP.Columns[4].HeaderText = "Mô tả - img";
            dtg_AllSP.Columns[5].HeaderText = "Trạng thái";
            foreach (var data in allDatas)
            {
                dtg_AllSP.Rows.Add(data.MaSanPham, data.TenSanPham, data.GiaNhap, data.SoLuong, data.MoTa, data.ThuocTinh);
            }
            dtg_AllSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormQLSP_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }


        private void ptb_Mota_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            string imgURL = dialog.FileName;
            ptb_Mota.Image = Image.FromFile(imgURL);
            ptb_Mota.ImageLocation = imgURL;
        }

        private void dtg_AllSP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_AllSP.Rows[e.RowIndex];
            tb_Ten.Text = row.Cells[1].Value.ToString();
            tb_Soluong.Text = row.Cells[2].Value.ToString();
            tb_Gia.Text = row.Cells[3].Value.ToString();
            cbb_Trangthai.Text = row.Cells[5].Value.ToString();
            ptb_Mota.Image = Image.FromFile(row.Cells[4].Value.ToString());
        }
    }
}
