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
    public partial class kho : Form
    {
        private const string MS_001 = "Không được để trống";
        private const string MS_002 = "Thêm thành công";
        private const string MS_003 = "Thêm thất bại";
        private const string MS_004 = "Mã ảnh đã tồn tại";
        private const string MS_005 = "Sửa thành công";
        private const string MS_006 = "Sửa thất bại";
        private const string MS_007 = "Xóa thành công";
        private const string MS_008 = "Xóa thất bại";
        private const string MS_009 = "Vui lòng nhập mã ảnh muốn tìm";
        private const string MS_013 = "Không tìm thấy ảnh";
        private const string MS_Notify = "Thông báo";
        private const string MS_Error = "Lỗi";
        private const string MS_Confirm = "Bạn có chắc chắn xóa không?";
        private const string MS_Warn = "Cảnh báo";
        private const string MS_Action = "Không thể xóa";
        private const string MS_SQL = "Lỗi SQL";

        khoBLL khoBLL = new khoBLL();
        public kho()
        {
            InitializeComponent();
        }

        private void tbMaPhieuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void kho_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgv, khoBLL.findAll());

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

            if (tbMaPhieuThu.Text.Trim() == "")
            {
                errorProvider.SetError(tbMaPhieuThu, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(tbMaPhieuThu, "");
            if (tbPT.Text == "")
            {
                errorProvider.SetError(tbPT, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(tbPT, "");
            if (tbSL.Text == "")
            {
                errorProvider.SetError(tbSL, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(tbSL, "");
            if (tbTongTien.Text == "")
            {
                errorProvider.SetError(tbTongTien, MS_001);
                check = false;
            }
            else
                errorProvider.SetError(tbTongTien, "");
            //**************
            //*************
            return check;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkValid(sender, e))
                {
                    if (khoBLL.checkExistsNameAndCategory(tbMaPhieuThu.Text))
                    {
                        if (khoBLL.insert(tbMaPhieuThu.Text, tbPT.Text,tbSL.Text,tbTongTien.Text))
                        {
                            MessageBox.Show(MS_002, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            errorProvider.Clear();
                            loadDataToDataGridView(dgv, khoBLL.findAll());
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbTongTien.Text = "";
            tbSL.Text = "";
            tbMaPhieuThu.Text = "";
            tbPT.Text = "";

            errorProvider.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
