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
    class quyenDAL
    {
        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblChucVu", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("tblChucVu"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(string PK_iChucVu, string sChucVu, string sGhiChu)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemChucVu";
                    cmd.Parameters.Add("@iChucVu",PK_iChucVu);
                    cmd.Parameters.Add("@sChucVu", sChucVu);
                    cmd.Parameters.Add("@sGhiChu", sGhiChu);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public bool update(string PK_iChucVu, string sChucVu, string sGhiChu)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaChucVu";
                    cmd.Parameters.AddWithValue("@iChucVu", PK_iChucVu);
                    cmd.Parameters.AddWithValue("@sChucVu", sChucVu);
                    cmd.Parameters.AddWithValue("@sGhiChu", sGhiChu);
                    
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
    }
}
