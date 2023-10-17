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
    public partial class hopDong : Form
    {

        hopDongBLL hopDongBLL = new hopDongBLL();
        string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public hopDong()
        {
            InitializeComponent();
        }

        private void hopDong_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvHopDong, hopDongBLL.findAll());
            getDataCMNDKh();
            getDataCMNDNV();
            dgvHopDong.ClearSelection();
            
        }
        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();

            tbIDHopDong.Clear();
            tbIDPhuongTien.Clear();
            txtPhieuXuat.Clear();

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
                cbCNMDKH.DataSource = listKH;
                cbCNMDKH.DisplayMember = "Value";
                cbCNMDKH.ValueMember = "Key";
            }
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

        private void btnThem_Click(object sender, EventArgs e)
        {

            int PK_iHopDong  = Convert.ToInt32(tbIDHopDong.Text.Trim());
            int FK_iPhuongTien = Convert.ToInt32(tbIDPhuongTien.Text.Trim());
            DateTime dNgayThue = DateTime.Now;
            DateTime dNgayHenTra =  dpNgayHenTra.Value;
            float fTongTienDatCoc = float.Parse(tbTongTienDatCoc.Text);
            float fTienThuePT = float.Parse(tbTienThuePt.Text);

            string FK_sCMND = cbCNMDKH.Text.ToString();
            string FK_sCMNDnv = cbCMNDNV.Text.ToString();

            int FK_iPhieuX = Convert.ToInt32(txtPhieuXuat.Text.Trim());

            if (hopDongBLL.insert(PK_iHopDong, FK_iPhuongTien, dNgayThue, dNgayHenTra, fTongTienDatCoc, fTienThuePT, FK_sCMND, FK_sCMNDnv, FK_iPhieuX))
            {
                MessageBox.Show("Thanh cong");
                hopDong_Load(null, null);
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void dgvHopDong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHopDong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvHopDong.SelectedRows[0];

                tbIDHopDong.Text = selectedRow.Cells["PK_iHopDong"].Value.ToString();
                tbIDPhuongTien.Text = selectedRow.Cells["FK_iPhuongTien"].Value.ToString();
                tbTongTienDatCoc.Text = selectedRow.Cells["fTongTienDatCoc"].Value.ToString();
                tbTienThuePt.Text = selectedRow.Cells["fTienThuePT"].Value.ToString();
                foreach (KeyValuePair<string, string> item in cbCNMDKH.Items)
                {
                    if (item.Value == selectedRow.Cells["FK_sCMND"].Value.ToString())
                    {
                        cbCNMDKH.SelectedItem = item;
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

                txtPhieuXuat.Text = selectedRow.Cells["FK_iPhieuX"].Value.ToString();

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            int PK_iHopDong = Convert.ToInt32(tbIDHopDong.Text.Trim());
            int FK_iPhuongTien = Convert.ToInt32(tbIDPhuongTien.Text.Trim());
            DateTime dNgayThue = DateTime.Now;
            DateTime dNgayHenTra = dpNgayHenTra.Value;
            float fTongTienDatCoc = float.Parse(tbTongTienDatCoc.Text);
            float fTienThuePT = float.Parse(tbTienThuePt.Text);

            string FK_sCMND = cbCNMDKH.Text.ToString();
            string FK_sCMNDnv = cbCMNDNV.Text.ToString();

            int FK_iPhieuX = Convert.ToInt32(txtPhieuXuat.Text.Trim());
            if (hopDongBLL.update(PK_iHopDong, FK_iPhuongTien, dNgayThue, dNgayHenTra, fTongTienDatCoc, fTienThuePT, FK_sCMND, FK_sCMNDnv, FK_iPhieuX))
            {
                MessageBox.Show("Thanh cong");
                hopDong_Load(null, null);
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int PK_iHopDong = Convert.ToInt32(tbIDHopDong.Text.Trim());

            if (dgvHopDong.SelectedRows.Count > 0)
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
                                cmd.CommandText = "delete tblHopDong where PK_iHopDong = @PK_iHopDong";
                                cmd.Parameters.AddWithValue("@PK_iHopDong", PK_iHopDong);
                                cnn.Open();
                                cmd.ExecuteNonQuery();
                                cnn.Close();
                                MessageBox.Show("Xoa thanh cong ");
                                hopDong_Load(null, null);

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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            hopDong_Load(null, null);
        }
    }
}
