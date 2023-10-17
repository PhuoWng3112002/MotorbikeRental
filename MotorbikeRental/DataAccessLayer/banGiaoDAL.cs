using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.DataAccessLayer
{
    internal class banGiaoDAL
    {
        string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblBanGiao", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("bangiao"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }


        public bool insert(int PK_iHopDong, int iPhuongTien, DateTime dNgayThue, DateTime dNgayHenTra, float fTongTienDatCoc, float fTienThuePT, string FK_sCMND, string FK_sCMNDnv, string sGhiChu)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "proc_ThemBanGiao";
                    cmd.Parameters.AddWithValue("@PK_iHopDong", PK_iHopDong);
                    cmd.Parameters.AddWithValue("@iPhuongTien", iPhuongTien);
                    cmd.Parameters.AddWithValue("@dNgayThue", dNgayThue);
                    cmd.Parameters.AddWithValue("@dNgayHenTra", dNgayHenTra);
                    cmd.Parameters.AddWithValue("@fTongTienDatCoc", fTongTienDatCoc);
                    cmd.Parameters.AddWithValue("@fTienThuePT", fTienThuePT);
                    cmd.Parameters.AddWithValue("@FK_sCMND", FK_sCMND);
                    cmd.Parameters.AddWithValue("@FK_sCMNDnv", FK_sCMNDnv);
                    cmd.Parameters.AddWithValue("@sGhiChu", sGhiChu);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }



        public bool update(int PK_iHopDong, int iPhuongTien, DateTime dNgayThue, DateTime dNgayHenTra, float fTongTienDatCoc, float fTienThuePT, string FK_sCMND, string FK_sCMNDnv, string sGhiChu)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "proc_SuaBanGiao";
                    cmd.Parameters.AddWithValue("@PK_iHopDong", PK_iHopDong);
                    cmd.Parameters.AddWithValue("@iPhuongTien", iPhuongTien);
                    cmd.Parameters.AddWithValue("@dNgayThue", dNgayThue);
                    cmd.Parameters.AddWithValue("@dNgayHenTra", dNgayHenTra);
                    cmd.Parameters.AddWithValue("@fTongTienDatCoc", fTongTienDatCoc);
                    cmd.Parameters.AddWithValue("@fTienThuePT", fTienThuePT);
                    cmd.Parameters.AddWithValue("@FK_sCMND", FK_sCMND);
                    cmd.Parameters.AddWithValue("@FK_sCMNDnv", FK_sCMNDnv);
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