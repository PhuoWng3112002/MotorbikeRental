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

namespace MotorbikeRental.QuanLyKho
{
    public partial class sanPham : Form
    {
        private const string MS_001 = "Không được để trống";
        private const string MS_002 = "Thêm thành công";
        private const string MS_003 = "Thêm thất bại";
        private const string MS_004 = "Loại phương tiện đã tồn tại đã tồn tại";
        private const string MS_005 = "Sửa thành công";
        private const string MS_006 = "Sửa thất bại";
        private const string MS_007 = "Xóa thành công";
        private const string MS_008 = "Xóa thất bại";
        private const string MS_009 = "Vui lòng nhập thông tin muốn tìm";
        private const string MS_013 = "Không tìm thấy thông tin";
        private const string MS_Notify = "Thông báo";
        private const string MS_Error = "Lỗi";
        private const string MS_Confirm = "Bạn có chắc chắn xóa không?";
        private const string MS_Warn = "Cảnh báo";
        private const string MS_Action = "Không thể xóa do tồn tại khóa ngoại";
        private const string MS_SQL = "Lỗi SQL";

        phuongTienBLL phuongTienBLL = new phuongTienBLL();
        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public sanPham()
        {
            InitializeComponent();
        }

        private void sanPham_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvPT, phuongTienBLL.findPT());
            LoadToComboBox();
        }
        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }
        private void LoadToComboBox()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                //loadDataToDataGridView(dgvPhieuNhap, phieuThuBLL.findAll());
                using (SqlCommand cmd = new SqlCommand("select * from tblAnhPT", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbAnhPT.ValueMember = "PK_iAnh";
                        cbAnhPT.DisplayMember = "PK_iAnh";
                        cbAnhPT.DataSource = dt;
                        cbAnhPT.Text = "";
                       

                    }

                }
                using (SqlCommand cmd = new SqlCommand("select * from tblLoaiPhuongTien", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbLoaiPT.ValueMember ="PK_iLoaiPT" ;
                        cbLoaiPT.DisplayMember = "sLoaiPT";
                        cbLoaiPT.DataSource = dt;
                        cbLoaiPT.Text = "";

                    }

                }

                
                using (SqlCommand cmd = new SqlCommand("select * from tblKho", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbMaPhieuThu.ValueMember = "PK_iPhieuThu";
                        cbMaPhieuThu.DisplayMember = "PK_iPhieuThu";
                        cbMaPhieuThu.DataSource = dt;
                        cbMaPhieuThu.Text = "";


                    }

                }
            }
        }
        private bool checkValid(object sender, EventArgs e)
        {
            //check trống
            bool check = true;
            if (tbMaPT.Text == "")
            {
                errorProvider.SetError(tbMaPT, MS_001);
                check = false;
            }
            else
            {
                errorProvider.SetError(tbMaPT, "");
            }

            if (cbAnhPT.Text == "")
            {
                errorProvider.SetError(tbGiaGoc, MS_001);
                check = false;
            }

            else
                errorProvider.SetError(cbAnhPT, "");
            ///************/

            /************************/
            if (cbLoaiPT.Text == null)
            {
                errorProvider.SetError(cbLoaiPT, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(cbLoaiPT, "");
            //**************
            //*************
            return check;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkValid(sender, e))
            {
                if (phuongTienBLL.checkExistsPTAndCategory(tbMaPT.Text))
                {
                    if (phuongTienBLL.insertPT(tbMaPT.Text,cbLoaiPT.SelectedValue.ToString(), cbMaPhieuThu.Text, tbTenPT.Text, tbGiaThue.Text, tbGiaGoc.Text, cbAnhPT.Text, cbTinhTrang.Text))
                    {
                        MessageBox.Show(MS_002, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProvider.Clear();
                        loadDataToDataGridView(dgvPT, phuongTienBLL.findPT());


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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaPT.Text = "";
            cbLoaiPT.Text = "";
            cbMaPhieuThu.Text = "";
            cbTinhTrang.Text = "";
            cbAnhPT.Text = "";
            tbGiaThue.Text = "";
            tbGiaGoc.Text = "";
            tbTenPT.Text = "";

            errorProvider.Clear();
        }

        private void tbMaPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbGiaThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbGiaGoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
    }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkValid(sender, e))
            {
                if (phuongTienBLL.updatePT(tbMaPT.Text, cbLoaiPT.SelectedValue.ToString(), cbMaPhieuThu.Text, tbTenPT.Text, tbGiaThue.Text, tbGiaGoc.Text, cbAnhPT.Text, cbTinhTrang.Text))
                {
                    MessageBox.Show(MS_005, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToDataGridView(dgvPT, phuongTienBLL.findPT());
                    btnLamMoi_Click(sender, e);
                }
                else
                    MessageBox.Show(MS_006, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPT.CurrentCell.RowIndex;

            tbMaPT.Text = dgvPT.Rows[r].Cells[0].Value.ToString();
            cbLoaiPT.SelectedValue = dgvPT.Rows[r].Cells[1].Value.ToString();
            cbMaPhieuThu.Text = dgvPT.Rows[r].Cells[2].Value.ToString();
            cbTinhTrang.Text = dgvPT.Rows[r].Cells[7].Value.ToString();
            cbAnhPT.Text = dgvPT.Rows[r].Cells[6].Value.ToString();
            tbGiaThue.Text = dgvPT.Rows[r].Cells[4].Value.ToString();
            tbGiaGoc.Text = dgvPT.Rows[r].Cells[5].Value.ToString();
            tbTenPT.Text = dgvPT.Rows[r].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(MS_Confirm, MS_Warn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (phuongTienBLL.deletePTById(tbMaPT.Text))
                    {
                        MessageBox.Show(MS_007, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataToDataGridView(dgvPT, phuongTienBLL.findPT());
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
    }
}
