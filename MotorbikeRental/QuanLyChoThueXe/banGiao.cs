using MotorbikeRental.BusinessLogicLayer;
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

namespace MotorbikeRental.QuanLyChoThueXe
{
    public partial class banGiao : Form
    {


        banGiaoBLL banGiaoBLL = new banGiaoBLL();
        string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public banGiao()
        {
            InitializeComponent();
        }

        private void banGiao_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvBanGiao , banGiaoBLL.findAll());
            getDataCMNDKh();
            getDataCMNDNV();
            getDataHopDong();
            dgvBanGiao.ClearSelection();
        }

        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();


        }

        private void getDataCMNDNV()
        {
            List<KeyValuePair<string, string>> listNV = new List<KeyValuePair<string, string>>();
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from tblCTNV", cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maNV = reader.GetString(0);
                            string tenNV = reader.GetString(1);
                            listNV.Add(new KeyValuePair<string, string>(tenNV, maNV));
                        }
                    }
                }
                cnn.Close();
                cbCMNDNV.DataSource = listNV;
                cbCMNDNV.DisplayMember = "Value";
                cbCMNDNV.ValueMember = "Key";
            }
        }


        private void getDataCMNDKh()
        {
            List<KeyValuePair<string, string>> listKH = new List<KeyValuePair<string, string>>();
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from tblCTNguoiDung", cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maKH = reader.GetString(0);
                            string tenKH = reader.GetString(1);
                            listKH.Add(new KeyValuePair<string, string>(tenKH, maKH));
                        }
                    }
                }
                cnn.Close();
                cbCMNDKH.DataSource = listKH;
                cbCMNDKH.DisplayMember = "Value";
                cbCMNDKH.ValueMember = "Key";
            }
        }

        private void getDataHopDong()
        {
            List<KeyValuePair<int, int>> listKH = new List<KeyValuePair<int, int>>();
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from tblHopDong", cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maHD = reader.GetInt32(0); 
                            int tenHD = reader.GetInt32(1);  
                            listKH.Add(new KeyValuePair<int, int>(maHD, tenHD));
                        }
                    }
                }
                cnn.Close();
                cbHopDong.DataSource = listKH;
                cbHopDong.DisplayMember = "Key"; 
                cbHopDong.ValueMember = "Value"; 
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int PK_iHopDong = Convert.ToInt32(cbHopDong.Text.ToString());
            int iPhuongTien = Convert.ToInt32(tbIDPhuongTien.Text.Trim());
            DateTime dNgayThue = DateTime.Now;
            DateTime dNgayHenTra = dpNgayHenTra.Value;
            float fTongTienDatCoc = float.Parse(tbTongTienDatCoc.Text);
            float fTienThuePT = float.Parse(tbTienThuePT.Text);

            string FK_sCMND = cbCMNDKH.Text.ToString();
            string FK_sCMNDnv = cbCMNDNV.Text.ToString();

           string sGhiChu = tbGhiChu.Text.ToString();

            if (banGiaoBLL.insert(PK_iHopDong, iPhuongTien, dNgayThue, dNgayHenTra, fTongTienDatCoc, fTienThuePT, sGhiChu, FK_sCMND, FK_sCMNDnv))
            {
                MessageBox.Show("Thanh cong");
                banGiao_Load(null, null);
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int PK_iHopDong = Convert.ToInt32(cbHopDong.Text.ToString());
            int iPhuongTien = Convert.ToInt32(tbIDPhuongTien.Text.Trim());
            DateTime dNgayThue = DateTime.Now;
            DateTime dNgayHenTra = dpNgayHenTra.Value;
            float fTongTienDatCoc = float.Parse(tbTongTienDatCoc.Text);
            float fTienThuePT = float.Parse(tbTienThuePT.Text);

            string FK_sCMND = cbCMNDKH.Text.ToString();
            string FK_sCMNDnv = cbCMNDNV.Text.ToString();

            string sGhiChu = tbGhiChu.Text.ToString();


            if (banGiaoBLL.update(PK_iHopDong, iPhuongTien, dNgayThue, dNgayHenTra, fTongTienDatCoc, fTienThuePT, sGhiChu, FK_sCMND, FK_sCMNDnv))
            {
                MessageBox.Show("Thanh cong");
                banGiao_Load(null, null);
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int PK_iHopDong = Convert.ToInt32(cbHopDong.Text);

            if (dgvBanGiao.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cnn = new SqlConnection(constr))
                        {
                            using (SqlCommand cmd = cnn.CreateCommand())
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "delete tblBanGiao where PK_iHopDong = @PK_iHopDong";
                                cmd.Parameters.AddWithValue("@PK_iHopDong", PK_iHopDong);
                                cnn.Open();
                                cmd.ExecuteNonQuery();
                                cnn.Close();
                                MessageBox.Show("Xoa thanh cong ");
                                banGiao_Load(null, null);

                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        foreach (SqlError er in ex.Errors)
                        {
                            MessageBox.Show("Lỗi :" + er.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chua co lua chon xoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvBanGiao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBanGiao.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBanGiao.SelectedRows[0];

                tbIDPhuongTien.Text = selectedRow.Cells["iPhuongTien"].Value.ToString();
                tbTongTienDatCoc.Text = selectedRow.Cells["fTongTienDatCoc"].Value.ToString();
                tbTienThuePT.Text = selectedRow.Cells["fTongTienThuePT"].Value.ToString();
                foreach (KeyValuePair<string, string> item in cbCMNDKH.Items)
                {
                    if (item.Value == selectedRow.Cells["FK_sCMND"].Value.ToString())
                    {
                        cbCMNDKH.SelectedItem = item;
                        break;
                    }
                }

                foreach (KeyValuePair<string, string> item in cbCMNDNV.Items)
                {
                    if (item.Value == selectedRow.Cells["FK_sCMNDnv"].Value.ToString())
                    {
                        cbCMNDNV.SelectedItem = item;
                        break;
                    }
                }

                foreach (KeyValuePair<int, int> item in cbHopDong.Items)
                {
                    if (item.Value == Convert.ToInt32(selectedRow.Cells["PK_iHopDong"].Value))
                    {
                        cbHopDong.SelectedItem = item;
                        break;
                    }
                }

                tbGhiChu.Text = selectedRow.Cells["sGhiChu"].Value.ToString();

                if (DateTime.TryParse(selectedRow.Cells["dNgayThue"].Value.ToString(), out DateTime result))
                {
                    dtpNgayThue.Value = result;
                }
                if (DateTime.TryParse(selectedRow.Cells["dNgayHenTra"].Value.ToString(), out DateTime dNgayHenTra))
                {
                    dpNgayHenTra.Value = dNgayHenTra;
                }

            }
        }
    }
}
