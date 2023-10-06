using MotorbikeRental.BusinessLogicLayer;
using MotorbikeRental.DangNhap_DangKi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorbikeRental.TaiKhoan
{
    public partial class doiMatKhau : Form
    {
        private const string MS_001 = "Vui lòng nhập đủ thông tin";
        private const string MS_006 = "Mật khẩu cần có 8 ký tự trở lên, tối đa 20 ký tự, bao gồm chữ số, chữ thường, chữ hoa";
        private const string MS_007 = "Mật khẩu nhập lại không đúng";
        private const string MS_008 = "Mật khẩu cũ không đúng";
        private const string MS_009 = "Đổi mật khẩu thành công";
        private const string MS_010 = "Đổi mật khẩu thất bại";
        private const string MS_Notify = "Thông báo";


        taiKhoanBLL taiKhoanBLL = new taiKhoanBLL();

        //******************************
        public doiMatKhau()
        {
            InitializeComponent();
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

        private bool checkValidDoiMatKhau(object sender, EventArgs e)
        {
            bool check = true;

            if (tbMatKhauCu.Text.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(tbMatKhauCu, MS_001);
                check = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(tbMatKhauCu, "");
            }

            if (tbMatKhauMoi.Text.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(tbMatKhauMoi, MS_001);
                check = false;
            }
            else if (checkingPasswordStrength(tbMatKhauMoi.Text) < 4)
            {
                MessageBox.Show(MS_006, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(tbMatKhauMoi, "");
            }

            if (tbNhapLaiMatKhauMoi.Text.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(tbNhapLaiMatKhauMoi, MS_001);
                check = false;
            }
            else if (tbNhapLaiMatKhauMoi.Text != tbMatKhauMoi.Text)
            {
                errorProviderDoiMatKhau.SetError(tbNhapLaiMatKhauMoi, MS_007);
                tbNhapLaiMatKhauMoi.Text = "";
                check = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(tbNhapLaiMatKhauMoi, "");
            }

            return check;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauCu = tbMatKhauCu.Text;
            string nhapLaiMatKhauMoi = tbNhapLaiMatKhauMoi.Text;

            if (checkValidDoiMatKhau(sender, e))
            {
                if (!taiKhoanBLL.checkPassword(Program.tenTK, matKhauCu))
                    MessageBox.Show(MS_008, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (taiKhoanBLL.changePassword(Program.tenTK, nhapLaiMatKhauMoi))
                    {
                        MessageBox.Show(MS_009, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DangNhap dn = new DangNhap_DangKi.DangNhap()
;                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(MS_010, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMatKhauCu.Text = "";
            tbMatKhauMoi.Text = "";
            tbNhapLaiMatKhauMoi.Text = "";
            errorProviderDoiMatKhau.Clear();
        }

        private void btnVeTrangChu_Click(object sender, EventArgs e)
        {
  
        }

        private void doiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void doiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
           

        }
    }
}
