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
    public partial class FormSanPham : Form
    {
        List<SanPham> sanphamss;
        SanPhamServices _servicess;
        public FormSanPham()
        {
            _servicess = new SanPhamServices();
            sanphamss = _servicess.GetAll();
            InitializeComponent();
        }

        public void LoadSPToPanel(int page)
        {
            tlp_SanPham.Controls.Clear();
            int numberOfPage = (int)Math.Ceiling((decimal)sanphamss.Count / 4);
            if (page < 1 || page > numberOfPage) return;
            else
            {
                if (page * 4 - 4 < sanphamss.Count)
                {
                    Panel s1 = CreatePanelSP(sanphamss[page * 4 - 4]);
                    tlp_SanPham.Controls.Add(s1, 0, 0);
                }
                if (page * 4 - 3 < sanphamss.Count)
                {
                    Panel s2 = CreatePanelSP(sanphamss[page * 4 - 3]);
                    tlp_SanPham.Controls.Add(s2, 0, 1);
                }
                if (page * 4 - 2 < sanphamss.Count)
                {
                    Panel s3 = CreatePanelSP(sanphamss[page * 4 - 2]);
                    tlp_SanPham.Controls.Add(s3, 1, 0);
                }
                if (page * 4 - 1 < sanphamss.Count)
                {
                    Panel s4 = CreatePanelSP(sanphamss[page * 4 - 1]);
                    tlp_SanPham.Controls.Add(s4, 1, 1);
                }
            }
        }

        private void btn_ShowSP_Click(object sender, EventArgs e)
        {
            tlp_SanPham.Controls.Clear();
            tlp_SanPham.ColumnCount = 2;
            tlp_SanPham.RowCount = 2;
            LoadSPToPanel(Convert.ToInt32(lb_page.Text));
        }

        public Panel CreatePanelSP(SanPham sp)
        {
            Panel p = new Panel(); p.Size = new Size(555, 360);
            p.Name = sp.MaSanPham.ToString();
            PictureBox ptb = new PictureBox(); ptb.Size = new Size(297, 287);
            ptb.Image = Image.FromFile(sp.MoTa);
            ptb.Location = new Point(14, 12);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            Label lbTen = new Label(); lbTen.Text = "Tên sản phẩm";
            lbTen.Location = new Point(331, 14);
            Label lbTenValue = new Label(); lbTenValue.Text = sp.TenSanPham;
            lbTenValue.Location = new Point(332, 47);
            Label lbGia = new Label(); lbGia.Text = "Gia sản phẩm";
            lbGia.Location = new Point(331, 87);
            Label lbGiaValue = new Label(); lbGiaValue.Text = sp.GiaNhap + "";
            lbGiaValue.Location = new Point(332, 123);
            Label lbSL = new Label(); lbSL.Text = "Số lượng sản phẩm";
            lbSL.Location = new Point(332, 165);
            Label lbSLValue = new Label(); lbSLValue.Text = sp.SoLuong + "";
            lbSLValue.Name = "Soluong";
            lbSLValue.Location = new Point(332, 198);
            Label lbMua = new Label(); lbMua.Text = "Số lượng mua";
            lbMua.Location = new Point(332, 232);
            Button btnMua = new Button();
            btnMua.Location = new Point(442, 263);
            btnMua.Size = new Size(83, 39); btnMua.Text = "MUA";
            btnMua.MouseClick += BtnMua_MouseClick;
            TextBox tbSoLuong = new TextBox(); tbSoLuong.PlaceholderText = "Nhập";
            tbSoLuong.Location = new Point(332, 268); tbSoLuong.Size = new Size(83, 34);
            tbSoLuong.Name = "tbSoLuong";
            p.Controls.Add(ptb); p.Controls.Add(lbTen); p.Controls.Add(lbTenValue); p.Controls.Add(lbGia);
            p.Controls.Add(lbGiaValue); p.Controls.Add(lbSL); p.Controls.Add(lbSLValue); p.Controls.Add(lbMua);
            p.Controls.Add(btnMua); p.Controls.Add(tbSoLuong);
            return p;
        }

        private void BtnMua_MouseClick(object? sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            Panel p = (Panel)b.Parent;
            TextBox t = p.Controls["tbSoLuong"] as TextBox;
            int soluongmua = Convert.ToInt32(t.Text);
            Label soluong = p.Controls["Soluong"] as Label;
            int soluongcon = Convert.ToInt32(soluong.Text);
            if (soluongmua > soluongcon) MessageBox.Show($"Không thể mua {soluongmua} vì quá {soluongcon} sản phẩm");
            else MessageBox.Show("Bạn vừa chọn mua sản phẩm có id là " + p.Name + "Với số lượng là: " + t.Text);
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_page.Text) > 1)
            {
                lb_page.Text = Convert.ToInt32(lb_page.Text) - 1 + "";
                LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            }
        }

        private void lb_next_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_page.Text) < (int)Math.Ceiling((decimal)sanphamss.Count / 4))
            {
                lb_page.Text = Convert.ToInt32(lb_page.Text) + 1 + "";
                LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            }
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            tlp_SanPham.Controls.Clear();
            FormQLSP qlsp = new FormQLSP();
            qlsp.TopLevel = false;
            tlp_SanPham.ColumnCount = 1;
            tlp_SanPham.RowCount = 1;
            tlp_SanPham.Controls.Add(qlsp);
            qlsp.Show();
            qlsp.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
