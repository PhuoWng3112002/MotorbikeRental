using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{
    class taiKhoanBLL
    {
        taiKhoanDAL taiKhoanDAL = new taiKhoanDAL();
        public int login(string tenTK, string matKhau)
        {
            DataTable dt = taiKhoanDAL.findByUsername(tenTK);
            if (dt.Rows.Count == 0)
                return 0; //Tên đăng nhập không tồn tại
            else
            {
                if (String.Equals(dt.Rows[0]["sMK"].ToString(), matKhau))
                {
                    Program.setSession(dt.Rows[0]["PK_sCMND"].ToString(), dt.Rows[0]["FK_iChucVu"].ToString(), dt.Rows[0]["sTK"].ToString());

                    return 1;
                }
                return 2; //Đúng tên dăng nhập nhưng Sai mật khẩu
            }
        }

        public bool checkPassword(string tenTK, string matKhau)
        {
            DataTable dt = taiKhoanDAL.findByUsername(tenTK);
            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["sMK"].ToString(), matKhau))
                {
                    return true;
                }
            }
            return false;
        }

        public bool changePassword(string tenTK, string matKhau)
        {
            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau))
            {
                return false;
            }

            if (checkingPasswordStrength(matKhau) < 4)
            {
                return false;
            }

            return taiKhoanDAL.changePassword(tenTK, matKhau);
        }

        public int checkingPasswordStrength(string password)
        {
            int score = 0;

            //Độ dài mật khẩu phải từ 8-20 ký tự
            if (password.Length >= 8 && password.Length <= 20)
                score++;

            //Check xem mật khẩu có số hay không
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))   //number only //"^\d+$" if you need to match more than one digit.
                score++;

            //Chekc xem mật khẩu có chữ thường không
            if (Regex.IsMatch(password, @"^(?=.*[a-z]).+$", RegexOptions.ECMAScript)) //lower
                score++;

            //Chekc xem mật khẩu có chữ hoa không
            if (Regex.IsMatch(password, @"^(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //upper case
                score++;

            //Chekc xem mật khẩu có ký tự đặc biệt hay không
            //if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
            //    score++;

            return score;
        }
        public DataTable findAll()
        {
            return taiKhoanDAL.findAll();
        }
        public DataTable findND()
        {
            return taiKhoanDAL.findND();
        }
        public DataTable findNV()
        {
            return taiKhoanDAL.findNV();
        }
        public bool insertND(string PK_sCMND, string sTK, string sMK, string sCauHoiBM, string sCauTraLoi, string sHoTen, string dNgaySinh, string sGioiTinh, string sDiaChi, string sDienThoai)
        {
            if (string.IsNullOrEmpty(PK_sCMND) || string.IsNullOrEmpty(sTK) || string.IsNullOrEmpty(sMK) || string.IsNullOrEmpty(sCauHoiBM)
                || string.IsNullOrEmpty(sCauTraLoi) || string.IsNullOrEmpty(sHoTen) || string.IsNullOrEmpty(dNgaySinh) || string.IsNullOrEmpty(sGioiTinh) || string.IsNullOrEmpty(sDienThoai) || string.IsNullOrEmpty(sDiaChi))
                return false;
            //else if (DateTime.Compare(Convert.ToDateTime(dNgaySinh),DateTime.Now)>0)
            //    return false;
            else
                return taiKhoanDAL.insertND(PK_sCMND, sTK, sMK, sCauHoiBM, sCauTraLoi, sHoTen, dNgaySinh, sGioiTinh, sDiaChi, sDienThoai);
        }
        public bool checkExistsNameAndCategory(string sCMND, string sTK)
        {
            DataTable dt = taiKhoanDAL.findAll();

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["PK_sCMND"].ToString(), sCMND, StringComparison.InvariantCultureIgnoreCase))
                    return false;
                //else if (!string.IsNullOrEmpty(sCMND))
                //    if (!int.TryParse(sCMND, out _) || int.Parse(NCC) <= 0)
                //        return false;
                if (String.Equals(dr["sTK"].ToString(), sTK, StringComparison.InvariantCultureIgnoreCase))
                    return false;
            }

            return true;
        }

        internal bool insertND(string text1, string text2, string text3, string text4, string text5, string text6, DateTime dateTime, string text7, string gioitinh, string text8)
        {
            throw new NotImplementedException();
        }
    }
}
