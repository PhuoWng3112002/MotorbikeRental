using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorbikeRental
{
    static class Program
    {
        public static string constr = "Data Source=DESKTOP-R3EHFK4/PNG;Initial Catalog=db_QuanLyChoThuePhuongTien;Integrated Security=True";
        public static string maQuyenQuanLy = "1";
        public static string maQuyenBanHang = "2";
        public static string maQuyenKhachHang = "3";

        public static string maTK, maQuyen, tenTK;
        public static void setSession(string maTK, string maQuyen, string tenTK)
        {
            Program.maTK = maTK;
            Program.maQuyen = maQuyen;
            Program.tenTK = tenTK;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QuanLyChoThueXe.phieuNhapKho());
            //Application.Run(new QuanLyKho.sanPham());
            Application.Run(new DangNhap_DangKi.DangNhap());
          /*  Application.Run(new QuanLyChoThueXe.hopDong());*/
        }
    }
}
