using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{
    class khoBLL
    {
        khoDAL khoDAL = new khoDAL();
        public DataTable findAll()
        {
            return khoDAL.findAll();
        }
        public bool insert(string iPhieuThu, string pt, string sl, string tt)
        {
            if (string.IsNullOrEmpty(iPhieuThu))
                return false;
            else
                return khoDAL.insert( iPhieuThu,  pt,  sl,  tt);
        }
        public bool checkExistsNameAndCategory(string iPhieuThu)
        {
            DataTable dt = khoDAL.findAll();

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["PK_iPhieuThu"].ToString(), iPhieuThu, StringComparison.InvariantCultureIgnoreCase))
                    return false;
                else if (!string.IsNullOrEmpty(iPhieuThu))
                    if (!int.TryParse(iPhieuThu, out _) || int.Parse(iPhieuThu) <= 0)
                        return false;
            }

            return true;
        }
    }
}
