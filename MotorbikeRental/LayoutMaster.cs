using MotorbikeRental.DangNhap_DangKi;
using MotorbikeRental.QuanLyChoThueXe;
using MotorbikeRental.QuanLyKhachHang;
using MotorbikeRental.QuanLyKho;
using MotorbikeRental.QuanLyNhanSu;
using MotorbikeRental.TaiKhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorbikeRental
{
    public partial class LayoutMaster : Form
    {
        public LayoutMaster()
        {
            InitializeComponent();
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            phieuNhapKho tc = new QuanLyChoThueXe.phieuNhapKho();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void LayoutMaster_Load(object sender, EventArgs e)
        {
            lbTaiKhoanDangDangNhap.Text = "Tài khoản: " + Program.tenTK;
            if (Program.maQuyen.Equals(Program.maQuyenBanHang))
            {
                /*ẩn quản lý kho**/
                quảnLýKhoToolStripMenuItem.Visible = false;
                tsmiNhaCungCap.Visible = false;
                tsmiSanPham.Visible = false;
                tsmiLoaiSanPham.Visible = false;
                tsmiAnhSanPham.Visible = false;
                tsmiKho.Visible = false;
                /*ẩn quản lý nhân sự**/
                quảnLýNhânSựToolStripMenuItem.Visible = false;
                tsmiDSNV.Visible = false;
                tsmiQuyen.Visible = false;
            }
            if (Program.maQuyen.Equals(Program.maQuyenQuanLy))
            {
                /*ẩn liên hệ*/
               tsmiLienHe.Visible = false;
            }
            if (Program.maQuyen.Equals(Program.maQuyenKhachHang))
            {
                /*ẩn quản lý kho**/
                quảnLýKhoToolStripMenuItem.Visible = false;
                tsmiNhaCungCap.Visible = false;
                tsmiSanPham.Visible = false;
                tsmiLoaiSanPham.Visible = false;
                tsmiAnhSanPham.Visible = false;
                tsmiKho.Visible = false;
                /*ẩn phiếu nhập/ xuất kho*/
                quảnLýBánHàngToolStripMenuItem.Visible = false;
                tsmiPhieuNhapKho.Visible = false;
                tsmiPhieuXuatKho.Visible = false;
                /*ẩn ql khách hàng*/
                quảnLýKháchHàngToolStripMenuItem.Visible = false;
                tsmiDSKH.Visible = false;
                /*ẩn quản lý nhân sự**/
                quảnLýNhânSựToolStripMenuItem.Visible = false;
                tsmiDSNV.Visible = false;
                tsmiQuyen.Visible = false;
                /**custom another*/
                tsmiDanhGia.Font = new Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point);
                tsmiBanGiao.Font = new Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point);
                tsmiHopDong.Font= new Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            trangChu tc = new trangChu();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            trangChu tc = new trangChu();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            nhaCungCap ncc = new QuanLyKho.nhaCungCap();
            ncc.TopLevel = false;
            panel1.Controls.Add(ncc);
            ncc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ncc.Dock = DockStyle.Fill;
            ncc.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            loaiSanPham tc = new QuanLyKho.loaiSanPham();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            sanPham tc = new QuanLyKho.sanPham();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            anh tc = new QuanLyKho.anh();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hopDong tc = new QuanLyChoThueXe.hopDong();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void bànGiaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            banGiao tc = new QuanLyChoThueXe.banGiao();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            phieuXuatKho tc = new QuanLyChoThueXe.phieuXuatKho();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            phieuNhapKho tc = new QuanLyChoThueXe.phieuNhapKho();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            khachHang tc = new QuanLyKhachHang.khachHang();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void đánhGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            danhGia tc = new QuanLyKhachHang.danhGia();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            nhanVien tc = new QuanLyNhanSu.nhanVien();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void quyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            quyen tc = new QuanLyNhanSu.quyen();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            thongTinTaiKhoan tc = new TaiKhoan.thongTinTaiKhoan();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            doiMatKhau tc = new TaiKhoan.doiMatKhau();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Bạn chắc chắn muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                this.Close();
            Program.maTK = "";
            Program.maQuyen = "";
            Program.tenTK = "";
      
            DangNhap dn = new DangNhap_DangKi.DangNhap();
            dn.Show();
        }

        private void LayoutMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Tạo Form đích và hiển thị nó
                DangNhap dn = new DangNhap_DangKi.DangNhap();
                dn.Show();
            }
        }

        private void tsmiLienHe_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            lienHe tc = new lienHe();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void tsmiKho_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            kho tc = new QuanLyKho.kho();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }
    }
}
