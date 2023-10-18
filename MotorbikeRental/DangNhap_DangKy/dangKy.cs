using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MotorbikeRental.BusinessLogicLayer;
using System.Text.RegularExpressions;

namespace MotorbikeRental.DangNhap_DangKi
{
    public partial class DangKy : Form
    {
        private const string MS_001 = "Không được để trống";
        private const string MS_002 = "Số CMND không đúng định dạng"; 
        private const string MS_003 = "Mật khẩu không khớp";
        private const string MS_004 = "Mật khẩu cần có 8 ký tự trở lên, tối đa 20 ký tự, bao gồm chữ số, chữ thường, chữ hoa";
        private const string MS_005 = "Ngày sinh không hợp lệ";
        private const string MS_006 = "Số điện thoại không đúng định dạng";
        private const string MS_007 = "Tạo tài khoản thành công. Hãy đăng nhập lại!";
        private const string MS_008 = "Tạo tài khoản thất bại. Hãy thử lại";
        private const string MS_009 = "Tài khoản đã tồn tại";
        private const string MS_Notify = "Thông báo";
        private const string MS_Error = "Lỗi";
        private const string MS_Warn = "Cảnh báo";

        taiKhoanBLL taiKhoanBLL = new taiKhoanBLL();

        /********************************************/
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        bool isMouseDown;

        int xLast;
        int yLast;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            isMouseDown = true;
            xLast = e.X;
            yLast = e.Y;

            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int newY = this.Top + (e.Y - yLast);
                int newX = this.Left + (e.X - xLast);

                this.Location = new Point(newX, newY);
            }

            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            isMouseDown = false;

            base.OnMouseUp(e);
        }

        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 15;
            path.AddArc(0, 0, radius, radius, 180, 90);// Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);//Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);//Bottom-right corner

            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);//Bottom-left corner

            //Create a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);

            //************************
            
        }
        private bool checkValid(object sender, EventArgs e)
        {
            bool check = true;

            //Check trống----------------------------------------------------------------
            if (tbCMND.Text.Trim() == "")
            {
                errorProviderDangKy.SetError(tbCMND, MS_001);
                check = false;
            }
            else
                errorProviderDangKy.SetError(tbCMND, "");
            //**************
            if (tbTK.Text.Trim() == "")
            {
                errorProviderDangKy.SetError(tbTK, MS_001);
                check = false;
            }
            else
                errorProviderDangKy.SetError(tbTK, "");
            //*************
            if (tbMK.Text.Trim() == "")
            {
                errorProviderDangKy.SetError(tbMK, MS_001);
                check = false;
            }
            else
                errorProviderDangKy.SetError(tbMK, "");
            //***************
            if (tbNhapLaiMK.Text.Trim() == "")
            {
                errorProviderDangKy.SetError(tbNhapLaiMK, MS_001);
                check = false;
            }
            else
                errorProviderDangKy.SetError(tbNhapLaiMK, "");

            //***************
            if (tbHoTen.Text.Trim() == "")
            {
                errorProviderDangKy.SetError(tbHoTen, MS_001);
                check = false;
            }
            else
                errorProviderDangKy.SetError(tbHoTen, "");
            //**************
            if (dtpNgaySinh.Text.Trim() == "")
            {
                errorProviderDangKy.SetError(dtpNgaySinh, MS_001);
                check = false;
            }
            else
                errorProviderDangKy.SetError(dtpNgaySinh, "");
            //*************
            if (tbDiaChi.Text.Trim() == "")
            {
                errorProviderDangKy.SetError(tbDiaChi, MS_001);
                check = false;
            }
            else
                errorProviderDangKy.SetError(tbDiaChi, "");
            //*************
            if (rbNam.Checked == false && rbNu.Checked==false)
            {
                errorProviderDangKy.SetError(rbNu, MS_001);
                check = false;
            }
            else
                errorProviderDangKy.SetError(rbNu, "");
            //*************
            if (tbSDT.Text.Trim() == "")
            {
                //Check trống
                errorProviderDangKy.SetError(tbSDT, MS_001);
                check = false;
            }
            else
            {
                //**************************************
                //Check định dạng SĐT
                Regex checkSDT = new Regex(@"^(\\+84|0)(3|5|7|8|9)[0-9]{8}$");

                if (!checkSDT.IsMatch(tbSDT.Text.Trim()))
                {
                    errorProviderDangKy.SetError(tbSDT, MS_006);
                    check = false;
                }
                else
                    errorProviderDangKy.SetError(tbSDT, "");
            }
                
            //*************
            if (tbCauHoi.Text == "")
            {
                errorProviderDangKy.SetError(tbCauHoi, MS_001);
                check = false;
            }
            else
                errorProviderDangKy.SetError(tbCauHoi, "");
            //*************
            if (tbCauTraLoi.Text == "")
            {
                errorProviderDangKy.SetError(tbCauTraLoi, MS_001);
                check = false;
            }
            else
                errorProviderDangKy.SetError(tbCauTraLoi, "");

            //*************------------------------------------------------------------------------
            // Ngày sinh không được lớn hơn ngày hiện tại
            if (DateTime.Compare(Convert.ToDateTime(dtpNgaySinh.Value), DateTime.Now) > 0)
            {
                //MessageBox.Show(MS_005, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProviderDangKy.SetError(dtpNgaySinh, MS_005);
                check = false;
            }
            else
                errorProviderDangKy.SetError(dtpNgaySinh, "");
            //-------------------------------------------------------------------------------------
            // Mật khẩu 8-20 ký tự ,bao gồm chữ số, chữ hoa, chữ thường
            if (checkingPasswordStrength(tbMK.Text)<4)
            {
                errorProviderDangKy.SetError(tbMK,MS_004 );
                //MessageBox.Show(MS_004, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }
            else
            {
                errorProviderDangKy.SetError(tbMK, "");
            }
            //-----------------------------------------------------------------------------------------
            // Check confirm mật khẩu

            if(tbMK.Text != tbNhapLaiMK.Text)
            {
                errorProviderDangKy.SetError(tbNhapLaiMK, MS_003);
                //MessageBox.Show(MS_003, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            else
            {
                errorProviderDangKy.SetError(tbNhapLaiMK, "");
            }
            //********---------------------------------------------------------------------------------
            if (tbCMND.Text.Length != 12)
            {
                errorProviderDangKy.SetError(tbCMND, MS_002);
                check = false;
            }
            else
                errorProviderDangKy.SetError(tbCMND, "");
            return check;
        }

        private int checkingPasswordStrength(string matKhau)
        {
            int score = 0;

            //Độ dài mật khẩu phải từ 8-20 ký tự
            if (matKhau.Length >= 8 && matKhau.Length <= 20)
                score++;

            //Check xem mật khẩu có số hay không
            if (Regex.IsMatch(matKhau, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))   //number only //"^\d+$" if you need to match more than one digit.
                score++;

            //Chekc xem mật khẩu có chữ thường không
            if (Regex.IsMatch(matKhau, @"^(?=.*[a-z]).+$", RegexOptions.ECMAScript)) //lower
                score++;

            //Chekc xem mật khẩu có chữ hoa không
            if (Regex.IsMatch(matKhau, @"^(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //upper case
                score++;

            //Chekc xem mật khẩu có ký tự đặc biệt hay không
            //if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
            //    score++;

            return score;
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap_DangKi.DangNhap();
            dn.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbCauHoi.Text = "";
            tbCauTraLoi.Text = "";
            tbCMND.Text = "";
            tbDiaChi.Text = "";
            tbHoTen.Text = "";
            tbMK.Text = "";
            tbNhapLaiMK.Text = "";
            tbSDT.Text = "";
            tbTK.Text = "";

            rbNam.Checked = false;
            rbNu.Checked = false;

            tbCMND.Focus();

            //*****************************
            errorProviderDangKy.Clear();

        }

        public void btnDangKy_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (checkValid(sender, e))
            {
                if (taiKhoanBLL.checkExistsNameAndCategory(tbCMND.Text, tbTK.Text))
                {
                    if (rbNam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    else
                    {
                        gioitinh ="Nữ";
                    }
                    if (taiKhoanBLL.insertND(tbCMND.Text, tbTK.Text, tbMK.Text, tbCauHoi.Text, tbCauTraLoi.Text, tbHoTen.Text, Convert.ToString(dtpNgaySinh.Value), tbDiaChi.Text,
                       gioitinh,tbSDT.Text))
                    {
                        //Tạo tài khoản thành công
                        MessageBox.Show(MS_007, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProviderDangKy.Clear();
                        btnHuy_Click(sender, e);
                        DangNhap dn = new DangNhap();
                        dn.Show();
                        this.Hide();
                    }
                    else
                    {
                        //Tạo tài khoản thất bại
                        MessageBox.Show(MS_008, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Tài khoản đã tồn tại
                    MessageBox.Show(MS_009, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            
        }

     

        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            //Chỉ cho nhập số
            //if (System.Text.RegularExpressions.Regex.IsMatch(tbSDT.Text, "  ^ [0-9]")))
            //{
            //    tbSDT.Text = "";
            //}
        }

        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //không nhập kí tự khác ngoài số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbNhapLaiMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCMND_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbCMND_Validating(object sender, CancelEventArgs e)
        {
            bool check = true;

            if (tbCMND.Text.Length!=12)
            {
                errorProviderDangKy.SetError(tbCMND, MS_002);
                check = false;
            }
            else
                errorProviderDangKy.SetError(tbCMND, "");
            
        }
    }
}
