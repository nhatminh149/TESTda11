using A_DAL.Models;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL
{
    public partial class FormNV : Form
    {
        NhanVienServices _services = new NhanVienServices();
        public FormNV()
        {
            _services = new NhanVienServices();
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_ma.Text = row.Cells[1].Value.ToString(); // Mã NV
                txt_ten.Text = row.Cells[2].Value.ToString(); // Tên NV
                txt_sdt.Text = row.Cells[3].Value.ToString(); // Số điện thoại
                txt_email.Text = row.Cells[4].Value.ToString(); // Email
                string gioitinh = row.Cells[5].Value.ToString(); // Giới tính
                if (gioitinh == "Nữ")
                {
                    radioButton2.Checked = true;
                }
                else if (gioitinh == "Nam")
                {
                    radioButton1.Checked = true;
                }
                txt_vitri.Text = row.Cells[6].Value.ToString(); // Vị trí
            }
        }

        public void ShowData()
        {
            dataGridView1.Rows.Clear();
            int stt = 1;
            var allData = _services.CNShow();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[1].HeaderText = "Mã NV";
            dataGridView1.Columns[2].HeaderText = "Tên NV";
            dataGridView1.Columns[3].HeaderText = "Số điện thoại";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Giới tính";
            dataGridView1.Columns[6].HeaderText = "Password";
            dataGridView1.Columns[7].HeaderText = "Vị trí";

            foreach (var item in allData)
            {
                dataGridView1.Rows.Add(stt++, item.MaNhanVien, item.HoTenNhanVien, item.SoDienThoai, item.Email, item.GioiTinh, item.Password, item.ViTri);
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txt_ma.Text);
            string ten = txt_ten.Text;
            string sdt = txt_sdt.Text;
            string email = txt_email.Text;
            string vitri = txt_vitri.Text;
            string gioitinh = radioButton1.Checked ? "Nam" : "Nữ";
            string pass = txt_pass.Text;

            MessageBox.Show(_services.CNThem(ma, ten, sdt, email, vitri, pass, gioitinh));
            ShowData();
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ma.Text, out int ma))
            {
                string ten = txt_ten.Text;
                string sdt = txt_sdt.Text;
                string email = txt_email.Text;
                string vitri = txt_vitri.Text;
                string gioitinh = radioButton1.Checked ? "Nam" : "Nữ";
                string pass = txt_pass.Text;

                MessageBox.Show(_services.CNSua(ma, ten, sdt, email, vitri, pass, gioitinh));
                ShowData();
            }
            else
            {
                MessageBox.Show("Mã NV không hợp lệ.");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ma.Text, out int ma))
            {
                MessageBox.Show(_services.CNXoa(ma));
                ShowData();
            }
            else
            {
                MessageBox.Show("Mã NV không hợp lệ.");
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Cập nhật thành công!");
                ShowData();
            }
        }
    }
}
