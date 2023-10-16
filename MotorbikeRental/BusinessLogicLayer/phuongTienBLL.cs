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
        public bool insert(string PK_iLoaiPT, string sLoaiPT, string sPhanKhoi)
        {
            if (string.IsNullOrEmpty(PK_iLoaiPT) || string.IsNullOrEmpty(sLoaiPT) || string.IsNullOrEmpty(sPhanKhoi))
                return false;
            else
                return phuongTienDAL.insert(PK_iLoaiPT, sLoaiPT, sPhanKhoi);
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
        public bool update(string PK_iLoaiPT, string sLoaiPT, string sPhanKhoi)
        {

            if (string.IsNullOrEmpty(PK_iLoaiPT) || string.IsNullOrEmpty(sLoaiPT) || string.IsNullOrEmpty(sPhanKhoi))
                return false;

            else
                return phuongTienDAL.update(PK_iLoaiPT, sLoaiPT, sPhanKhoi);
        }
        public bool deleteById(string iLoaiPT)
        {
            if (string.IsNullOrEmpty(iLoaiPT))
            {
                return false;
            }
            return phuongTienDAL.deleteById(iLoaiPT);
        }
        public DataTable search(string PK_iLoaiPT, string sLoaiPT, string sPhanKhoi)
        {

            if (string.IsNullOrEmpty(PK_iLoaiPT) && string.IsNullOrEmpty(sLoaiPT) && string.IsNullOrEmpty(sPhanKhoi))
                return null;
            return phuongTienDAL.search(PK_iLoaiPT, sLoaiPT, sPhanKhoi);
        }


    }
}
