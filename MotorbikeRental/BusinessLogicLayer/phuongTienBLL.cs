using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{
    class phuongTienBLL
    {
        phuongTienDAL phuongTienDAL = new phuongTienDAL();

        public DataTable findLoaiPT()
        {
            return phuongTienDAL.findLoaiPT();
        }
        public DataTable findPT()
        {
            return phuongTienDAL.findPT();
        }
        public bool insert(string PK_iLoaiPT, string sLoaiPT, string sPhanKhoi)
        {
            if (string.IsNullOrEmpty(PK_iLoaiPT) || string.IsNullOrEmpty(sLoaiPT) || string.IsNullOrEmpty(sPhanKhoi))
                return false;
            else
                return phuongTienDAL.insert(PK_iLoaiPT, sLoaiPT, sPhanKhoi);
        }
        
        public bool insertPT(string maPT, string loaiPT, string iPhieuThu, string tenPT, string giaThue, string giaGoc, string anhPT, string tTrang)
        {
            if (string.IsNullOrEmpty(maPT) || string.IsNullOrEmpty(loaiPT) || string.IsNullOrEmpty(iPhieuThu) || string.IsNullOrEmpty(tenPT) || string.IsNullOrEmpty(giaThue) || string.IsNullOrEmpty(giaGoc) || string.IsNullOrEmpty(anhPT) || string.IsNullOrEmpty(tTrang))
                return false;
            else
                return phuongTienDAL.insertPT( maPT,  loaiPT,  iPhieuThu,  tenPT,  giaThue,  giaGoc,  anhPT,  tTrang);
        }
        public bool checkExistsNameAndCategory(string PK_iLoaiPT)
        {
            DataTable dt = phuongTienDAL.findLoaiPT();

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["PK_iLoaiPT"].ToString(), PK_iLoaiPT, StringComparison.InvariantCultureIgnoreCase))
                    return false;
                else if (!string.IsNullOrEmpty(PK_iLoaiPT))
                    if (!int.TryParse(PK_iLoaiPT, out _) || int.Parse(PK_iLoaiPT) <= 0)
                        return false;
            }

            return true;
        }
        public bool checkExistsPTAndCategory(string PK_iPT)
        {
            DataTable dt = phuongTienDAL.findPT();

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["PK_iPhuongTien"].ToString(), PK_iPT, StringComparison.InvariantCultureIgnoreCase))
                    return false;
                else if (!string.IsNullOrEmpty(PK_iPT))
                    if (!int.TryParse(PK_iPT, out _) || int.Parse(PK_iPT) <= 0)
                        return false;
            }

            return true;
        }
        public bool update(string PK_iLoaiPT, string sLoaiPT, string sPhanKhoi)
        {

            if (string.IsNullOrEmpty(PK_iLoaiPT) || string.IsNullOrEmpty(sLoaiPT) || string.IsNullOrEmpty(sPhanKhoi))
                return false;

            else
                return phuongTienDAL.update(PK_iLoaiPT, sLoaiPT, sPhanKhoi);
        }
        public bool updatePT(string maPT, string loaiPT, string iPhieuThu, string tenPT, string giaThue, string giaGoc, string anhPT, string tTrang)
        {

            if (string.IsNullOrEmpty(maPT) || string.IsNullOrEmpty(loaiPT) || string.IsNullOrEmpty(iPhieuThu) || string.IsNullOrEmpty(tenPT) || string.IsNullOrEmpty(giaThue) || string.IsNullOrEmpty(giaGoc) || string.IsNullOrEmpty(anhPT) || string.IsNullOrEmpty(tTrang))
                return false;

            else
                return phuongTienDAL.updatePT(maPT, loaiPT, iPhieuThu, tenPT, giaThue, giaGoc, anhPT, tTrang);
        }
        public bool deleteById(string iLoaiPT)
        {
            if (string.IsNullOrEmpty(iLoaiPT))
            {
                return false;
            }
            return phuongTienDAL.deleteById(iLoaiPT);
        }
        public bool deletePTById(string iPT)
        {
            if (string.IsNullOrEmpty(iPT))
            {
                return false;
            }
            return phuongTienDAL.deletePTById(iPT);
        }
        public DataTable search(string PK_iLoaiPT, string sLoaiPT, string sPhanKhoi)
        {

            if (string.IsNullOrEmpty(PK_iLoaiPT) && string.IsNullOrEmpty(sLoaiPT) && string.IsNullOrEmpty(sPhanKhoi))
                return null;
            return phuongTienDAL.search(PK_iLoaiPT, sLoaiPT, sPhanKhoi);
        }


    }
}
