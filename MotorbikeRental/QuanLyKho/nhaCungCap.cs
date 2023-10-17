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
    public partial class nhaCungCap : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        private const string MS_001 = "Không được để trống";
        private const string MS_002 = "Thêm thành công";
        private const string MS_003 = "Thêm thất bại";
        private const string MS_004 = "Nhà cung cấp đã tồn tại";
        private const string MS_005 = "Sửa thành công";
        private const string MS_006 = "Sửa thất bại";
        private const string MS_007 = "Xóa thành công";
        private const string MS_008 = "Xóa thất bại";
        private const string MS_009 = "Vui lòng nhập thông tin muốn tìm";
        private const string MS_010 = "Số lượng phải lớn hơn 0";
        private const string MS_011 = "Trọng tải phải lớn hơn 0";
        private const string MS_012 = "Đơn giá phải lớn hơn 0";
        private const string MS_013 = "Không tìm thấy nhà cung cấp";
        private const string MS_Notify = "Thông báo";
        private const string MS_Error = "Lỗi";
        private const string MS_Confirm = "Bạn có chắc chắn xóa không?";
        private const string MS_Warn = "Cảnh báo";
        private const string MS_Action = "Không thể xóa do tồn tại khóa ngoại";
        private const string MS_SQL = "Lỗi SQL";
        nhaCungCapBLL nhaCungCapBLL = new nhaCungCapBLL();

        public nhaCungCap()
        {
            InitializeComponent();
        }

        private void nhaCungCap_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvNCC, nhaCungCapBLL.findAll());
        }
        private bool checkValid(object sender, EventArgs e)
        {
            //check trống
            bool check = true;

            if (tbNCC.Text.Trim() == "")
            {
                errorProviderNCC.SetError(tbNCC, MS_001);
                check = false;
            }
            else
                errorProviderNCC.SetError(tbNCC, "");
            //**************
            if (tbPhuongTienN.Text.Trim() == "")
            {
                errorProviderNCC.SetError(tbPhuongTienN, MS_001);
                check = false;
            }
            else
                errorProviderNCC.SetError(tbPhuongTienN, "");
            //*************
            if (tbHangSX.Text.Trim() == "")
            {
                errorProviderNCC.SetError(tbHangSX, MS_001);
                check = false;
            }
            else
                errorProviderNCC.SetError(tbHangSX, "");
            //***************
            if (tbSL.Text.Trim() == "")
            {
                errorProviderNCC.SetError(tbSL, MS_001);
                check = false;
            }
            else
                errorProviderNCC.SetError(tbSL, "");

            //***************
            if (tbTrongTai.Text.Trim() == "")
            {
                errorProviderNCC.SetError(tbTrongTai, MS_001);
                check = false;
            }
            else
                errorProviderNCC.SetError(tbTrongTai, "");
            //**************
            if (tbDonGiaN.Text.Trim() == "")
            {
                errorProviderNCC.SetError(tbDonGiaN, MS_001);
                check = false;
            }
            else
                errorProviderNCC.SetError(tbDonGiaN, "");
            //*************
            return check;
        }

        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbDonGiaN.Text = "";
            tbHangSX.Text = "";
            tbNCC.Text = "";
            tbPhuongTienN.Text = "";
            tbSL.Text = "";
            tbTrongTai.Text = "";

            tbNCC.ReadOnly = false;

            loadDataToDataGridView(dgvNCC, nhaCungCapBLL.findAll());

        }




        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            tbPhuongTienN.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
            tbHangSX.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
            tbSL.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
            tbTrongTai.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
            tbDonGiaN.Text = dgvNCC.CurrentRow.Cells[5].Value.ToString();

            tbNCC.ReadOnly = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkValid(sender, e))
            {
                if (nhaCungCapBLL.checkExistsNameAndCategory(tbNCC.Text))
                {
                    if (nhaCungCapBLL.insert(tbNCC.Text, tbPhuongTienN.Text, tbHangSX.Text, tbSL.Text, tbTrongTai.Text, tbDonGiaN.Text))
                    {
                        MessageBox.Show(MS_002, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProviderNCC.Clear();
                        loadDataToDataGridView(dgvNCC, nhaCungCapBLL.findAll());
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkValid(sender, e))
            {
                if (nhaCungCapBLL.update(tbNCC.Text, tbPhuongTienN.Text, tbHangSX.Text, tbSL.Text, tbTrongTai.Text, tbDonGiaN.Text))
                {
                    MessageBox.Show(MS_005, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToDataGridView(dgvNCC, nhaCungCapBLL.findAll());
                    btnLamMoi_Click(sender, e);
                }
                else
                    MessageBox.Show(MS_006, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //if (nhaCungCapBLL.checkExistsNameAndCategory(tbNCC.Text))
                //{

                //}
                //else
                //{
                //    MessageBox.Show(MS_030, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(MS_Confirm, MS_Warn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (nhaCungCapBLL.deleteById(tbNCC.Text))
                    {
                        MessageBox.Show(MS_007, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataToDataGridView(dgvNCC, nhaCungCapBLL.findAll());
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            bool check = true;

            if (tbDonGiaN.Text == "" && tbHangSX.Text == "" && tbNCC.Text == "" && tbPhuongTienN.Text == "" && tbSL.Text == "" && tbTrongTai.Text == "")
            {
                MessageBox.Show(MS_009, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }

            if (tbSL.Text != "")
            {
                if (!int.TryParse(tbSL.Text, out _) || int.Parse(tbSL.Text) <= 0)
                {
                    MessageBox.Show(MS_010, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                }
            }
            if (tbTrongTai.Text != "")
            {
                if (!int.TryParse(tbTrongTai.Text, out _) || int.Parse(tbTrongTai.Text) <= 0)
                {
                    MessageBox.Show(MS_011, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                }
            }
            if (tbDonGiaN.Text != "")
            {
                if (!float.TryParse(tbDonGiaN.Text, out _) || float.Parse(tbDonGiaN.Text) <= 0)
                {
                    MessageBox.Show(MS_012, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                }
            }

            if (check)
            {
                btnLamMoi.Enabled = true;
                DataTable dt = nhaCungCapBLL.search(tbNCC.Text, tbHangSX.Text, tbPhuongTienN.Text, tbSL.Text, tbTrongTai.Text, tbDonGiaN.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(MS_013, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadDataToDataGridView(dgvNCC, dt);
            }
        }

        private void tbSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbTrongTai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbDonGiaN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
