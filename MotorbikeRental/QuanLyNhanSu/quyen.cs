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

namespace MotorbikeRental.QuanLyNhanSu
{
    public partial class quyen : Form
    {
        private const string MS_001 = "Không được để trống";
        private const string MS_002 = "Thêm thành công";
        private const string MS_003 = "Thêm thất bại";
        private const string MS_004 = "Quyền đã tồn tại";
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
        private const string MS_NotAccess = "Bạn không có quyền truy cập chức năng này";
        private const string MS_SQL = "Lỗi SQL";

        quyenBLL quyenBLL = new quyenBLL();
        public quyen()
        {
            InitializeComponent();
        }

        private void quyen_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvChucVu, quyenBLL.findAll());
            btnLuu.Enabled = false;
            btnLuu.BackColor = Color.Gray;

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
            if (tbCV.Text == "")
            {
                errorProviderChucVu.SetError(tbCV, MS_001);
                check = false;
            }
            else
            {
                errorProviderChucVu.SetError(tbCV, "");
            }

            if (tbMaCV.Text.Trim() == "")
            {
                errorProviderChucVu.SetError(tbMaCV, MS_001);
                check = false;
            }

            else
                errorProviderChucVu.SetError(tbMaCV, "");
            ///************/
           
            /************************/
            if (tbGhiChu.Text == null)
            {
                errorProviderChucVu.SetError(tbGhiChu, MS_001);
                check = false;
            }
            else
                errorProviderChucVu.SetError(tbGhiChu,"");
            //**************
            //*************
            return check;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnSua.BackColor = Color.Gray;
            btnThem.Enabled = false;
            btnThem.BackColor = Color.Gray;

            tbMaCV.ReadOnly = false;
            btnLuu.Enabled = true;
            btnLuu.BackColor = Color.RoyalBlue;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //tbMaCV.ReadOnly = true;
            tbGhiChu.Text = "";
            tbCV.Text = "";
            tbMaCV.Text = "";
            btnLuu.Enabled = false;
            btnLuu.BackColor = Color.Gray;

            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnSua.BackColor = Color.FromArgb(78, 189, 74);
            btnThem.BackColor = Color.FromArgb(80, 160, 255);
            errorProviderChucVu.Clear();
            tbMaCV.ReadOnly = true;

            errorProviderChucVu.Clear();
        }

        

        private void tbMaCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkValid(sender, e))
            {
                if (quyenBLL.checkExistsNameAndCategory(tbMaCV.Text))
                {
                    if (quyenBLL.insert(tbMaCV.Text,tbCV.Text,tbGhiChu.Text))
                    {
                        MessageBox.Show(MS_002, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProviderChucVu.Clear();
                        loadDataToDataGridView(dgvChucVu, quyenBLL.findAll());

                        /**********************/
                        //btnLuu.Enabled = false;
                        //btnLuu.BackColor = Color.Gray;

                        //btnSua.Enabled = true;
                        //btnThem.Enabled = true;
                        //btnSua.BackColor = Color.FromArgb(78, 189, 74);
                        //btnThem.BackColor = Color.FromArgb(80, 160, 255);
                        //errorProviderChucVu.Clear();
                        //tbMaCV.ReadOnly = true;

                        btnLamMoi_Click(sender,e);
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

        private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvChucVu.CurrentCell.RowIndex;
            tbMaCV.Text = dgvChucVu.Rows[r].Cells[0].Value.ToString();
            tbCV.Text = dgvChucVu.Rows[r].Cells[1].Value.ToString();
            tbGhiChu.Text = dgvChucVu.Rows[r].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkValid(sender, e))
            {
                if (quyenBLL.update(tbMaCV.Text, tbCV.Text, tbGhiChu.Text))
                {
                    MessageBox.Show(MS_005, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToDataGridView(dgvChucVu, quyenBLL.findAll());
                    btnLamMoi_Click(sender, e);
                }
                else
                    MessageBox.Show(MS_006, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
    }
}
