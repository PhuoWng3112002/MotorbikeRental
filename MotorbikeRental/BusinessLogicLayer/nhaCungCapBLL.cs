using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{
    class nhaCungCapBLL
    {
        nhaCungCapDAL nhaCungCapDAL = new nhaCungCapDAL();

        public DataTable findAll()
        {
            return nhaCungCapDAL.findAll();
        }

        public bool insert(string iNCC, string sPhuongTienN, string sHangSanXuat, string iSoLuong, string iTrongTai, string fDonGiaN)
        {
            if (string.IsNullOrEmpty(iNCC) || string.IsNullOrEmpty(sPhuongTienN) || string.IsNullOrEmpty(sHangSanXuat) || string.IsNullOrEmpty(iSoLuong)
                || string.IsNullOrEmpty(iTrongTai) || string.IsNullOrEmpty(fDonGiaN))
                return false;
            else if (!float.TryParse(fDonGiaN, out _) || float.Parse(fDonGiaN) <= 0)
                return false;
            else if (!int.TryParse(iSoLuong, out _) || int.Parse(iSoLuong) <= 0)
                return false;
            else if (!int.TryParse(iTrongTai, out _) || int.Parse(iTrongTai) <= 0)
                return false;
            else
                return nhaCungCapDAL.insert(iNCC, sPhuongTienN, sHangSanXuat, iSoLuong,iTrongTai, fDonGiaN);
        }
        //************************************************
        public bool update(string iNCC, string sPhuongTienN, string sHangSanXuat, string iSoLuong, string iTrongTai, string fDonGiaN)
        {
            if (string.IsNullOrEmpty(iNCC) || string.IsNullOrEmpty(sPhuongTienN) || string.IsNullOrEmpty(sHangSanXuat) || string.IsNullOrEmpty(iSoLuong)
                || string.IsNullOrEmpty(iTrongTai) || string.IsNullOrEmpty(fDonGiaN))
                return false;
            else if (!float.TryParse(fDonGiaN, out _) || float.Parse(fDonGiaN) <= 0)
                return false;
            else if (!int.TryParse(iSoLuong, out _) || int.Parse(iSoLuong) <= 0)
                return false;
            else if (!int.TryParse(iTrongTai, out _) || int.Parse(iTrongTai) <= 0)
                return false;
            else
                return nhaCungCapDAL.update(iNCC, sPhuongTienN, sHangSanXuat, iSoLuong,iTrongTai, fDonGiaN);
        }
        //****************************************************
        public bool deleteById(string NCC)
        {
            if (string.IsNullOrEmpty(NCC))
            {
                return false;
            }
            return nhaCungCapDAL.deleteById(NCC);
        }


        /****************************************************/
        public bool checkExistsNameAndCategory(string NCC)
        {
            DataTable dt = nhaCungCapDAL.findAll();

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["PK_iNCC"].ToString(), NCC, StringComparison.InvariantCultureIgnoreCase))
                    return false;
                else if (!string.IsNullOrEmpty(NCC))
                    if (!int.TryParse(NCC, out _) || int.Parse(NCC) <= 0)
                        return false;
            }

            return true;
        }
        /************************************/
        public DataTable search(string iNCC, string sPhuongTienN, string sHangSanXuat, string iSoLuong, string iTrongTai, string fDonGiaN)
        {

            if (string.IsNullOrEmpty(iNCC) && string.IsNullOrEmpty(sPhuongTienN) && string.IsNullOrEmpty(sHangSanXuat)
                && string.IsNullOrEmpty(iSoLuong) && string.IsNullOrEmpty(iTrongTai) && string.IsNullOrEmpty(fDonGiaN))
                return null;
            else if (!string.IsNullOrEmpty(fDonGiaN))
                if (!float.TryParse(fDonGiaN, out _) || float.Parse(fDonGiaN) <= 0)
                    return null;
            else if (!string.IsNullOrEmpty(iSoLuong))
                    if (!int.TryParse(iSoLuong, out _) || int.Parse(iSoLuong) <= 0)
                    return null;
            else if (!string.IsNullOrEmpty(iTrongTai))
                if (!int.TryParse(iTrongTai, out _) || int.Parse(iTrongTai) <= 0)
                    return null;
            return nhaCungCapDAL.search(iNCC, sPhuongTienN, sHangSanXuat, iSoLuong, iTrongTai, fDonGiaN);
        }


    }

}
