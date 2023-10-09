using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.DataAccessLayer
{
    class taiKhoanDAL
    {
        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable findByUsername(string tenTK)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_TimKiemTenTaiKhoan";
                    cmd.Parameters.AddWithValue("@TenTK", tenTK);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool changePassword(string tenTK, string matKhau)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DoiMatKhau";
                    cmd.Parameters.AddWithValue("@tenTK", tenTK);
                    cmd.Parameters.AddWithValue("@MK", matKhau);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from vv_CTTaiKhoan_Chucvu", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_CTTaiKhoan_Chucvu"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public DataTable findND()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select PK_sCMND, sTK, sMK, sCauHoiBM, sCauTraLoi,sHoTen, dNgaySinh, sDiaChi, sGioiTinh, sDienThoai from vv_CTTaiKhoan_Chucvu where FK_iChucVu =3", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_CTTaiKhoan_Chucvu"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public DataTable findNV()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select PK_sCMND, sTK, sMK, sCauHoiBM, sCauTraLoi,sHoTen, dNgaySinh, sDiaChi, sGioiTinh, sDienThoai,sChucVu from vv_CTTaiKhoan_Chucvu where FK_iChucVu=2 or FK_iChucVu=1", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_CTTaiKhoan_Chucvu"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public bool insertND(string PK_sCMND, string sTK, string sMK, string sCauHoiBM, string sCauTraLoi, string sHoTen, string dNgaySinh, string sGioiTinh, string sDiaChi, string sDienThoai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemND";
                    cmd.Parameters.AddWithValue("@CMND", PK_sCMND);
                    cmd.Parameters.AddWithValue("@TK", sTK);
                    cmd.Parameters.AddWithValue("@MK", sMK);
                    cmd.Parameters.AddWithValue("@CauHoi", sCauHoiBM);
                    cmd.Parameters.AddWithValue("@CauTraLoi", sCauTraLoi);
                    cmd.Parameters.AddWithValue("@HoTen", sHoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh",dNgaySinh);
                    cmd.Parameters.AddWithValue("@DiaChi",  sDiaChi);
                    cmd.Parameters.AddWithValue("@GioiTinh", sGioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", sDienThoai);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

    }
}
