using MotorbikeRental.BusinessLogicLayer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MotorbikeRental.QuanLyChoThueXe
{
    public partial class phieuNhapKho : Form
    {
        private const string MS_001 = "Không được để trống";
        private const string MS_002 = "Thêm thành công";
        private const string MS_003 = "Thêm thất bại";
        private const string MS_004 = "Mã đã tồn tại";
        private const string MS_005 = "Sửa thành công";
        private const string MS_006 = "Sửa thất bại";
        private const string MS_007 = "Xóa thành công";
        private const string MS_008 = "Xóa thất bại";
        private const string MS_009 = "Vui lòng nhập mã phiếu nhập muốn tìm";
        private const string MS_013 = "Không tìm thấy phiếu nhập";
        private const string MS_Notify = "Thông báo";
        private const string MS_Error = "Lỗi";
        private const string MS_Confirm = "Bạn có chắc chắn xóa không?";
        private const string MS_Warn = "Cảnh báo";
        private const string MS_Action = "Không thể xóa";
        private const string MS_SQL = "Lỗi SQL";

        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        phieuNhapBLL phieuNhapBLL = new phieuNhapBLL();
        public phieuNhapKho()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private bool checkValid(object sender, EventArgs e)
        {
            //check trống
            bool check = true;

            if (tbMaPhieuN.Text.Trim() == "")
            {
                errorProvider.SetError(tbMaPhieuN, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(tbMaPhieuN, "");
            if (cbMaNCC.Text== "--Chọn nhà cung cấp--")
            {
                errorProvider.SetError(cbMaNCC, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(cbMaNCC, "");

            if (cbCMND.Text == "--Nhân viên lập phiếu--")
            {
                errorProvider.SetError(cbCMND, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(cbCMND, "");

            if (cbLoaiPT.Text == "--Chọn loại phương tiện--")
            {
                errorProvider.SetError(cbLoaiPT, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(cbLoaiPT, "");

            if (tbSL.Text == "")
            {
                errorProvider.SetError(tbSL, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(tbSL, "");

            if (tbMaPhieuThu.Text == "")
            {
                errorProvider.SetError(tbMaPhieuThu, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(tbMaPhieuThu, "");


            //**************
            //*************
            return check;
        }
        private void phieuNhapKho_Load(object sender, EventArgs e)
        {
           
            loadDataToDataGridView(dgvPhieuNhap, phieuNhapBLL.findAll());
            LoadToComboBox();

        }

        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadToComboBox()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                //loadDataToDataGridView(dgvPhieuNhap, phieuThuBLL.findAll());
                using (SqlCommand cmd = new SqlCommand("select * from tblNCC", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbMaNCC.ValueMember = "PK_iNCC";
                        cbMaNCC.DisplayMember = "PK_iNCC";
                        cbMaNCC.DataSource = dt;
                        cbMaNCC.Text = "--Chọn nhà cung cấp--";
                        tbTenPT.Text = "";
                        tbHangSX.Text = "";
                        tbDonGiaN.Text = "";

                    }

                }
                using (SqlCommand cmd = new SqlCommand("select * from tblLoaiPhuongTien", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbLoaiPT.ValueMember = "PK_iLoaiPT";
                        cbLoaiPT.DisplayMember = "PK_iLoaiPT";
                        cbLoaiPT.DataSource = dt;
                        cbLoaiPT.Text = "--Chọn loại phương tiện--";
                        tbPhanKhoi.Text = "";

                    }

                }
                
                using (SqlCommand cmd = new SqlCommand("select * from tblNhanVien", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbCMND.ValueMember = "PK_sCMND";
                        cbCMND.DisplayMember = "PK_sCMND";
                        cbCMND.DataSource = dt;
                        cbCMND.Text = "--Nhân viên lập phiếu--";
                        

                    }

                }
                using (SqlCommand cmd = new SqlCommand("select * from tblKho", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tbMaPhieuThu.ValueMember = "PK_iPhieuThu";
                        tbMaPhieuThu.DisplayMember = "PK_iPhieuThu";
                        tbMaPhieuThu.DataSource = dt;
                        tbMaPhieuThu.Text = "";


                    }

                }
            }
        }

        private void cbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNCC where PK_iNCC='" + cbMaNCC.Text + "'", cnn))
                {

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string donGiaN = (string)dr["fDonGiaN"].ToString();
                        tbDonGiaN.Text = donGiaN;

                        string tenPT = (string)dr["sPhuongTienN"].ToString();
                        tbTenPT.Text = tenPT;

                        string HSX = (string)dr["sHangSanXuat"].ToString();
                        tbHangSX.Text = (string)dr["sHangSanXuat"].ToString();

                    }
                    if (tbSL.Text != "")
                    {
                        tbTongSL.Text = tbSL.Text;

                        int tongDG = Convert.ToInt32(tbSL.Text) * Convert.ToInt32(tbDonGiaN.Text);
                        tbTongDonGiaN.Text = Convert.ToString(tongDG);
                    }
                    else
                    {
                        tbTongDonGiaN.Text = "";
                        tbTongSL.Text = "";

                    }
                    cnn.Close();
                }    
                    


            }
        }

        private void cbLoaiPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblLoaiPhuongTien where PK_iLoaiPT='" + cbLoaiPT.SelectedValue + "'", cnn))
                {

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string phanKhoi = (string)dr["sPhanKhoi"].ToString();
                        tbPhanKhoi.Text = phanKhoi;
                    }
                    if (tbSL.Text != "")
                    {
                        int sl = Convert.ToInt32(tbSL.Text);
                        int pk = Convert.ToInt32(tbPhanKhoi.Text);
                        int tongTT = sl * pk;
                        tbTongTT.Text = Convert.ToString(tongTT);
                    }
                    else
                    {
                        tbTongTT.Text = "";

                    }
                    cnn.Close();
                }



            }

        }

        private void tbSL_TextChanged(object sender, EventArgs e)
        {
            try
            {

            if (tbSL.Text != "" || tbPhanKhoi.Text != null || tbDonGiaN.Text!="" )
            {

            tbTongSL.Text = tbSL.Text;
                int sl = Convert.ToInt32(tbSL.Text);
                int pk = Convert.ToInt32(tbPhanKhoi.Text);
            int tongTT = sl*pk;
            tbTongTT.Text = Convert.ToString(tongTT);

             int tongDG = Convert.ToInt32(tbSL.Text) * Convert.ToInt32(tbDonGiaN.Text);
                tbTongDonGiaN.Text = Convert.ToString(tongDG);
            }
            else if(tbSL.Text=="")
            {
                tbTongSL.Text = "";
                tbTongTT.Text = "";
                tbTongDonGiaN.Text = "";
            }
            }
            catch(Exception ex)
            {
                
                if(tbSL.Text == "")
                {
                errorProvider.SetError(tbSL, "Không được trống: " + ex.Message);

                }
                else
                {
                    errorProvider.Clear();
                }
                    //MessageBox.Show("Số lượng không được trống hoặc" + ex.Message);

            }
        }

        private void tbSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tbPhanKhoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMaPhieuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbMaPhieuN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int r = dgvPhieuNhap.CurrentCell.RowIndex;
            tbMaPhieuN.Text = dgvPhieuNhap.Rows[r].Cells[0].Value.ToString();
            tbTongTT.Text = dgvPhieuNhap.Rows[r].Cells[1].Value.ToString();
            tbTongDonGiaN.Text = dgvPhieuNhap.Rows[r].Cells[2].Value.ToString();
            cbMaNCC.Text = dgvPhieuNhap.Rows[r].Cells[3].Value.ToString();
            cbCMND.Text = dgvPhieuNhap.Rows[r].Cells[4].Value.ToString();
            tbMaPhieuThu.Text = dgvPhieuNhap.Rows[r].Cells[5].Value.ToString();
            tbSL.Text = dgvPhieuNhap.Rows[r].Cells[6].Value.ToString();
            cbLoaiPT.Text= dgvPhieuNhap.Rows[r].Cells[7].Value.ToString();

            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaPhieuN.Text = "";
            cbMaNCC.Text = "";
            tbTenPT.Text = "";
            tbHangSX.Text = "";
            tbDonGiaN.Text = "";
            cbLoaiPT.Text = "";
            tbPhanKhoi.Text = "";
            tbSL.Text = "";
            tbTongTT.Text = "";
            tbTongSL.Text = "";
            tbTongDonGiaN.Text = "";
            cbCMND.Text = "";
            tbMaPhieuThu.Text = "";

            errorProvider.Clear();
            phieuNhapKho_Load(sender,e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkValid(sender, e))
                {
                    if (phieuNhapBLL.checkExistsNameAndCategory(tbMaPhieuN.Text))
                    {
                        if (phieuNhapBLL.insert(tbMaPhieuN.Text,tbTongTT.Text,tbTongSL.Text,tbTongDonGiaN.Text,cbMaNCC.SelectedValue.ToString(),cbCMND.SelectedValue.ToString(),tbMaPhieuThu.Text,tbSL.Text,cbLoaiPT.SelectedValue.ToString()))
                        {
                            MessageBox.Show(MS_002, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            errorProvider.Clear();
                            loadDataToDataGridView(dgvPhieuNhap, phieuNhapBLL.findAll());
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show(MS_003, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(MS_004, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                if (error.Contains("40"))
                {
                    MessageBox.Show(MS_SQL, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(MS_Error, MS_Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(MS_Confirm, MS_Warn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (phieuNhapBLL.deleteById(tbMaPhieuN.Text))
                    {
                        MessageBox.Show(MS_007, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataToDataGridView(dgvPhieuNhap, phieuNhapBLL.findAll());
                        btnLamMoi_Click(sender, e);
                    }
                    else
                        MessageBox.Show(MS_008, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                if (error.Contains("40"))
                {
                    MessageBox.Show(MS_SQL, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(MS_Action, MS_Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkValid(sender, e))
                {

                    if (phieuNhapBLL.update(tbMaPhieuN.Text, tbTongTT.Text, tbTongSL.Text, tbTongDonGiaN.Text, cbMaNCC.SelectedValue.ToString(), cbCMND.SelectedValue.ToString(), tbMaPhieuThu.SelectedValue.ToString(), tbSL.Text, cbLoaiPT.SelectedValue.ToString()))
                    {
                        MessageBox.Show(MS_005, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataToDataGridView(dgvPhieuNhap, phieuNhapBLL.findAll());
                        btnLamMoi_Click(sender, e);
                    }
                    else
                        MessageBox.Show(MS_006, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                if (error.Contains("40"))
                {
                    MessageBox.Show(MS_SQL, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(MS_Error, MS_Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tbMaPhieuThu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
