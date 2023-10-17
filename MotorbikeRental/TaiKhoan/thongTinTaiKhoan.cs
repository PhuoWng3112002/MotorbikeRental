using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorbikeRental.TaiKhoan
{
    public partial class thongTinTaiKhoan : Form
    {
        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public thongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void lbCMCD_Click(object sender, EventArgs e)
        {

        }

        private void tbCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void thongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from vv_CTTaiKhoan_Chucvu where sTK='" + Program.tenTK + "'", cnn))
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string loaitk = (string)dr["sChucvu"].ToString();
                        tbLoaiTK.Text = loaitk;

                        string cmnd = (string)dr["PK_sCMND"].ToString();
                        tbCMND.Text = cmnd;

                        string tk = (string)dr["sTK"].ToString();
                        tbTK.Text = tk;

                        string ht = (string)dr["sHoTen"].ToString();
                        tbHoTen.Text = ht;

                        string ns = (string)dr["dNgaySinh"].ToString();
                        dtpNgaySinh.Text = ns;

                        string dc = (string)dr["sDiaChi"].ToString();
                        tbDiaChi.Text = dc;

                        string gt = (string)dr["sGioiTinh"].ToString();
                        if (gt == "Nữ")
                        {
                            rbNu.Checked = true;
                        }
                        if (gt == "Nam")
                        {
                            rbNam.Checked = true;
                        }

                        string sdt = (string)dr["sDienThoai"].ToString();
                        tbSDT.Text = sdt;

                        string ch = (string)dr["sCauHoiBM"].ToString();
                        tbCauHoi.Text = ch;

                        string tl = (string)dr["sCauTraLoi"].ToString();
                        tbCauTraLoi.Text = tl;

                    }

                    cnn.Close();
                }
            }
        }
    }
}
