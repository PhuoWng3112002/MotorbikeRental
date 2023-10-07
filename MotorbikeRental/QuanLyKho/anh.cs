using MotorbikeRental.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorbikeRental.QuanLyKho
{
    public partial class anh : Form
    {
        private const string MS_001 = "Không được để trống";
        private const string MS_002 = "Thêm thành công";
        private const string MS_003 = "Thêm thất bại";
        private const string MS_004 = "Mã ảnh đã tồn tại";
        private const string MS_005 = "Sửa thành công";
        private const string MS_006 = "Sửa thất bại";
        private const string MS_007 = "Xóa thành công";
        private const string MS_008 = "Xóa thất bại";
        private const string MS_009 = "Vui lòng nhập thông tin muốn tìm";
        private const string MS_013 = "Không tìm thấy ảnh";
        private const string MS_Notify = "Thông báo";
        private const string MS_Error = "Lỗi";
        private const string MS_Confirm = "Bạn có chắc chắn xóa không?";
        private const string MS_Warn = "Cảnh báo";
        private const string MS_NotAccess = "Bạn không có quyền truy cập chức năng này";
        private const string MS_SQL = "Lỗi SQL";

        anhBLL anhBLL = new anhBLL();
        public anh()
        {
            InitializeComponent();
        }

        private void anh_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvAnhPT, anhBLL.findAll());

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

            if (tbAnh.Text.Trim() == "")
            {
                errorProviderAnhPT.SetError(tbAnh,MS_001);
                check = false;
            }
            else
                errorProviderAnhPT.SetError(tbAnh, "");
            if (pbAnh.Image==null)
            {
                errorProviderAnhPT.SetError(pbAnh, MS_001);
                check = false;
            }
            else
                errorProviderAnhPT.SetError(pbAnh, "");
            //**************
            //*************
            return check;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn ảnh phương tiện";
            /*Chỉ cho phép chọn ảnh */
            open.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbAnh.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkValid(sender, e))
            {
                if (anhBLL.checkExistsNameAndCategory(tbAnh.Text))
                {
                    if (anhBLL.insert(tbAnh.Text,pbAnh.Image))
                    {
                        MessageBox.Show(MS_002, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProviderAnhPT.Clear();
                        loadDataToDataGridView(dgvAnhPT, anhBLL.findAll());
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
            tbAnh.Text = "";
            pbAnh.Image = null;
            errorProviderAnhPT.Clear();
        }

        private void tbAnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgvAnhPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAnhPT.CurrentCell.RowIndex;
            tbAnh.Text = dgvAnhPT.Rows[r].Cells[0].Value.ToString();
            byte[] b = (byte[])dgvAnhPT.Rows[r].Cells[1].Value;
            pbAnh.Image = ByteArrayToImage(b);
        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
    }
}
