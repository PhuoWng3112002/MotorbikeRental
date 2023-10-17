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
    class phuongTienDAL
    {
        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable findLoaiPT()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblLoaiPhuongTien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("tblLoaiPhuongTien"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public DataTable findPT()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from vv_PhuongTien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_PhuongTien"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(string PK_iLoaiPT, string sLoaiPT, string sPhanKhoi)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemLoaiPT";
                    cmd.Parameters.Add("@iLoaiPT", PK_iLoaiPT);
                    cmd.Parameters.Add("@sLoaiPT", sLoaiPT);
                    cmd.Parameters.Add("@sPhanKhoi", sPhanKhoi);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public bool insertPT(string maPT, string loaiPT, string iPhieuThu, string tenPT, string giaThue, string giaGoc,string anhPT, string tTrang)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemPT";
                    cmd.Parameters.Add("@maPT", maPT);
                    cmd.Parameters.Add("@loaiPT", loaiPT);
                    cmd.Parameters.Add("@iPhieuThu", iPhieuThu);
                    cmd.Parameters.Add("@tenPT", tenPT);
                    cmd.Parameters.Add("@giaThue", giaThue);
                    cmd.Parameters.Add("@giaGoc", giaGoc);
                    cmd.Parameters.Add("@anhPT", anhPT);
                    cmd.Parameters.Add("@tTrang", tTrang);


                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public bool update(string PK_iLoaiPT, string sLoaiPT, string sPhanKhoi)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaLoaiPT";
                    cmd.Parameters.Add("@iLoaiPT", PK_iLoaiPT);
                    cmd.Parameters.Add("@sLoaiPT", sLoaiPT);
                    cmd.Parameters.Add("@sPhanKhoi", sPhanKhoi);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        public bool updatePT(string maPT, string loaiPT, string iPhieuThu, string tenPT, string giaThue, string giaGoc, string anhPT, string tTrang)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaPT";
                    cmd.Parameters.Add("@maPT", maPT);
                    cmd.Parameters.Add("@loaiPT", loaiPT);
                    cmd.Parameters.Add("@iPhieuThu", iPhieuThu);
                    cmd.Parameters.Add("@tenPT", tenPT);
                    cmd.Parameters.Add("@giaThue", giaThue);
                    cmd.Parameters.Add("@giaGoc", giaGoc);
                    cmd.Parameters.Add("@anhPT", anhPT);
                    cmd.Parameters.Add("@tTrang", tTrang);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        public bool deleteById(string iLoaiPT)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from tblLoaiPhuongTien where PK_iLoaiPT=@iLoaiPT ";
                    cmd.Parameters.AddWithValue("@iLoaiPT", iLoaiPT);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }

        }
        public bool deletePTById(string iPT)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from tblCTPhuongTien where PK_iPhuongTien=@iPT " +
                        "Delete from tblPhuongTien where PK_iPhuongTien=@iPT ";
                    cmd.Parameters.AddWithValue("@iPT", iPT);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }

        }


        public DataTable search(string PK_iLoaiPT, string sLoaiPT, string sPhanKhoi)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_TimKiemLoaiPT";
                    cmd.Parameters.AddWithValue("@iLoaiPT", PK_iLoaiPT);
                    cmd.Parameters.AddWithValue("@sLoaiPT", sLoaiPT);
                    cmd.Parameters.AddWithValue("@sPhanKhoi", sPhanKhoi);
                    
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
