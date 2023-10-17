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
    class phieuNhapDAL
    {
        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_PhieuNhap", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_PhieuThu"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public bool insert(string iPhieuN, string iTTrongTai, string iTongSLN, string iTongGiaN, string iNCC, string sCMND, string iPhieuThu, string iSoLuongN, string iLoaiPT)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemPhieuN";
                    cmd.Parameters.Add("@iPhieuN", iPhieuN);
                    cmd.Parameters.Add("@iTTrongTai", iTTrongTai);
                    cmd.Parameters.Add("@iTongSLN", iTongSLN);
                    cmd.Parameters.Add("@iTongGiaN", iTongGiaN);
                    cmd.Parameters.Add("@iNCC", iNCC);
                    cmd.Parameters.Add("@sCMND", sCMND);
                    cmd.Parameters.Add("@iPhieuThu", iPhieuThu);
                    cmd.Parameters.Add("@iSoLuongN", iSoLuongN);
                    cmd.Parameters.Add("@iLoaiPT", iLoaiPT);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public bool deleteById(string iMaPhieuN)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaPhieuN";
                    cmd.Parameters.AddWithValue("@iMaPhieuN", iMaPhieuN);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        public bool update(string iPhieuN, string iTTrongTai, string iTongSLN, string iTongGiaN, string iNCC, string sCMND, string iPhieuThu, string iSoLuongN, string iLoaiPT)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaPhieuN";
                    cmd.Parameters.Add("@iPhieuN", iPhieuN);
                    cmd.Parameters.Add("@iTTrongTai", iTTrongTai);
                    cmd.Parameters.Add("@iTongSLN", iTongSLN);
                    cmd.Parameters.Add("@iTongGiaN", iTongGiaN);
                    cmd.Parameters.Add("@iNCC", iNCC);
                    cmd.Parameters.Add("@sCMND", sCMND);
                    cmd.Parameters.Add("@iPhieuThu", iPhieuThu);
                    cmd.Parameters.Add("@iSoLuongN", iSoLuongN);
                    cmd.Parameters.Add("@iLoaiPT", iLoaiPT);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

    }
}
