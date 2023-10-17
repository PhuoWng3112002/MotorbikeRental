using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.DataAccessLayer
{
    class anhDAL
    {
        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblAnhPT", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("tblAnhPT"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(string PK_iAnh, Image sUrl)
        {
            byte[] b = ImageToByteArray(sUrl);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into tblAnhPT values(@id, @url)";
                    cmd.Parameters.Add("@id",PK_iAnh);
                    cmd.Parameters.Add("@url", b);
               
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        //"insert into tblAnhPT values(@id,@url)"

        public bool update(string PK_iAnh, Image sUrl)
        {
            byte[] b = ImageToByteArray(sUrl);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update tblAnhPT SET sUrl = @url where @id = PK_iAnh";
                    cmd.Parameters.Add("@id", PK_iAnh);
                    cmd.Parameters.Add("@url", b);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();  
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        public bool deleteById(string iAnh)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from tblAnhPT where PK_iAnh=@id ";
                    cmd.Parameters.AddWithValue("@id", iAnh);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable search(string PK_iAnh)
        {
            //byte[] b = ImageToByteArray(sUrl);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_TimKiemAnh";
                    cmd.Parameters.AddWithValue("@id", PK_iAnh);
                    //cmd.Parameters.AddWithValue("@url", b);
                  

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
