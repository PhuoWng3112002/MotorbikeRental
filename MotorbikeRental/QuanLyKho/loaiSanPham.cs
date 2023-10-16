using MotorbikeRental.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorbikeRental.QuanLyKho
{
    public partial class loaiSanPham : Form
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
        public loaiSanPham()
        {
            InitializeComponent();
        }

        private void tbMaPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLoaiPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhanKhoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void loaiSanPham_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvLoaiPT, phuongTienBLL.findLoaiPT());

        }
        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }

        private bool checkValid(object sender, EventArgs e)
        {
            //check trống
            bool check = true;
            if (tbMaPT.Text == "")
            {
                errorProviderLoaiPT.SetError(tbMaPT, MS_001);
                check = false;
            }
            else
            {
                errorProviderLoaiPT.SetError(tbMaPT, "");
            }

            if (tbLoaiPT.Text == "")
            {
                errorProviderLoaiPT.SetError(tbLoaiPT, MS_001);
                check = false;
            }

            else
                errorProviderLoaiPT.SetError(tbLoaiPT, "");
            ///************/

            /************************/
            if (tbPhanKhoi.Text == null)
            {
                errorProviderLoaiPT.SetError(tbPhanKhoi, MS_001);
                check = false;
            }
            else
                errorProviderLoaiPT.SetError(tbPhanKhoi, "");
            //**************
            //*************
            return check;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkValid(sender, e))
            {
                if (phuongTienBLL.checkExistsNameAndCategory(tbMaPT.Text))
                {
                    if (phuongTienBLL.insert(tbMaPT.Text,tbLoaiPT.Text,tbPhanKhoi.Text))
                    {
                        MessageBox.Show(MS_002, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProviderLoaiPT.Clear();
                        loadDataToDataGridView(dgvLoaiPT, phuongTienBLL.findLoaiPT());


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

        private void tbMaPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbPhanKhoi.Text = "";
            tbMaPT.Text = "";
            tbLoaiPT.Text = "";

            errorProviderLoaiPT.Clear();
            loadDataToDataGridView(dgvLoaiPT, phuongTienBLL.findLoaiPT());
        }

        private void dgvLoaiPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLoaiPT.CurrentCell.RowIndex;
            tbMaPT.Text = dgvLoaiPT.Rows[r].Cells[0].Value.ToString();
            tbLoaiPT.Text = dgvLoaiPT.Rows[r].Cells[1].Value.ToString();
            tbPhanKhoi.Text = dgvLoaiPT.Rows[r].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkValid(sender, e))
            {
                if (phuongTienBLL.update(tbMaPT.Text, tbLoaiPT.Text, tbPhanKhoi.Text))
                {
                    MessageBox.Show(MS_005, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToDataGridView(dgvLoaiPT, phuongTienBLL.findLoaiPT());
                    btnLamMoi_Click(sender, e);
                }
                else
                    MessageBox.Show(MS_006, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (tbMaPT.Text == "" && tbLoaiPT.Text == "" && tbPhanKhoi.Text == "")
            {
                MessageBox.Show(MS_009, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }

            if (check)
            {
                btnLamMoi.Enabled = true;
                DataTable dt = phuongTienBLL.search(tbMaPT.Text, tbLoaiPT.Text, tbPhanKhoi.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(MS_013, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadDataToDataGridView(dgvLoaiPT, dt);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(MS_Confirm, MS_Warn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (phuongTienBLL.deleteById(tbMaPT.Text))
                    {
                        MessageBox.Show(MS_007, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataToDataGridView(dgvLoaiPT, phuongTienBLL.findLoaiPT());
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

