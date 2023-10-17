using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{
    class phieuNhapBLL
    {
        phieuNhapDAL phieuNhapDAL = new phieuNhapDAL();
        public DataTable findAll()
        {
            return phieuNhapDAL.findAll();
        }
        public bool checkExistsNameAndCategory(string iPhieuN)
        {
            DataTable dt = phieuNhapDAL.findAll();

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["PK_iPhieuN"].ToString(), iPhieuN, StringComparison.InvariantCultureIgnoreCase))
                    return false;
                else if (!string.IsNullOrEmpty(iPhieuN))
                    if (!int.TryParse(iPhieuN, out _) || int.Parse(iPhieuN) <= 0)
                        return false;
            }

            return true;
        }


        public bool insert(string iPhieuN, string iTTrongTai, string iTongSLN, string iTongGiaN, string iNCC, string sCMND, string iPhieuThu, string iSoLuongN, string iLoaiPT)
        {
            if (string.IsNullOrEmpty(iPhieuN)|| string.IsNullOrEmpty(iNCC) || string.IsNullOrEmpty(iSoLuongN) || string.IsNullOrEmpty(iLoaiPT) || string.IsNullOrEmpty(sCMND) || string.IsNullOrEmpty(iPhieuThu))
                return false;
            else
                return phieuNhapDAL.insert( iPhieuN,  iTTrongTai,  iTongSLN,  iTongGiaN,  iNCC,  sCMND,  iPhieuThu,  iSoLuongN,  iLoaiPT);
        }
        public bool deleteById(string iMaPhieuN)
        {
            if (string.IsNullOrEmpty(iMaPhieuN))
            {
                return false;
            }
            return phieuNhapDAL.deleteById(iMaPhieuN);
        }

        public bool update(string iPhieuN, string iTTrongTai, string iTongSLN, string iTongGiaN, string iNCC, string sCMND, string iPhieuThu, string iSoLuongN, string iLoaiPT)
        {

            if (string.IsNullOrEmpty(iPhieuN) || string.IsNullOrEmpty(iNCC) || string.IsNullOrEmpty(iSoLuongN) || string.IsNullOrEmpty(iLoaiPT) || string.IsNullOrEmpty(sCMND) || string.IsNullOrEmpty(iPhieuThu))
                return false;

            else
                return phieuNhapDAL.update(iPhieuN, iTTrongTai, iTongSLN, iTongGiaN, iNCC, sCMND, iPhieuThu, iSoLuongN, iLoaiPT);
        }

    }
}
