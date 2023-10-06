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
    class nhaCungCapDAL
    {
        string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from vv_NhaCungCap", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_NhaCungCap"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public bool insert(string iNCC, string sPhuongTienN, string sHangSanXuat, string iSoluong,string iTrongTai, string fDonGiaN)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemNCC";
                    cmd.Parameters.AddWithValue("@NCC",iNCC );
                    cmd.Parameters.AddWithValue("@PhuongTienN", sPhuongTienN);
                    cmd.Parameters.AddWithValue("@HangSanXuat", sHangSanXuat);
                    cmd.Parameters.AddWithValue("@SoLuong", iSoluong);
                    cmd.Parameters.AddWithValue("@TrongTai", iTrongTai);
                    cmd.Parameters.AddWithValue("@DonGiaN", fDonGiaN);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool update(string iNCC, string sPhuongTienN, string sHangSanXuat, string iSoluong, string iTrongTai, string fDonGiaN)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaNCC";
                    cmd.Parameters.AddWithValue("@NCC", iNCC);
                    cmd.Parameters.AddWithValue("@PhuongTienN", sPhuongTienN);
                    cmd.Parameters.AddWithValue("@HangSanXuat", sHangSanXuat);
                    cmd.Parameters.AddWithValue("@SoLuong", iSoluong);
                    cmd.Parameters.AddWithValue("@TrongTai", iTrongTai);
                    cmd.Parameters.AddWithValue("@DonGiaN", fDonGiaN);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool deleteById(string NCC)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from tblNCC where PK_iNCC=@NCC ";
                    cmd.Parameters.AddWithValue("@NCC", NCC);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable search(string iNCC, string sPhuongTienN, string sHangSanXuat, string iSoluong, string iTrongTai, string fDonGiaN)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_TimKiemNCC";
                    cmd.Parameters.AddWithValue("@NCC", iNCC);
                    cmd.Parameters.AddWithValue("@PhuongTienN", sPhuongTienN);
                    cmd.Parameters.AddWithValue("@HangSanXuat", sHangSanXuat);
                    cmd.Parameters.AddWithValue("@SoLuong", iSoluong);
                    cmd.Parameters.AddWithValue("@TrongTai", iTrongTai);
                    cmd.Parameters.AddWithValue("@DonGiaN", fDonGiaN);
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
    }
}
