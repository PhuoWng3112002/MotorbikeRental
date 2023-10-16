using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{
    class quyenBLL
    {
        quyenDAL quyenDAL = new quyenDAL();
        public DataTable findAll()
        {
            return quyenDAL.findAll();
        }
        public bool insert(string PK_iChucVu, string sChucVu, string sGhiChu)
        {
            if (string.IsNullOrEmpty(PK_iChucVu) || string.IsNullOrEmpty(sChucVu))
                return false;
            else
                return quyenDAL.insert(PK_iChucVu,sChucVu,sGhiChu);
        }
        public bool checkExistsNameAndCategory(string PK_iChucVu)
        {
            DataTable dt = quyenDAL.findAll();

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["PK_iChucVu"].ToString(), PK_iChucVu, StringComparison.InvariantCultureIgnoreCase))
                    return false;
                else if (!string.IsNullOrEmpty(PK_iChucVu))
                    if (!int.TryParse(PK_iChucVu, out _) || int.Parse(PK_iChucVu) <= 0)
                        return false;
            }

            return true;
        }
        public bool update(string PK_iChucVu, string sChucVu, string sGhiChu)
        {

            if (string.IsNullOrEmpty(PK_iChucVu) || string.IsNullOrEmpty(sChucVu))
                return false;
            
            else
                return quyenDAL.update( PK_iChucVu,  sChucVu, sGhiChu);
        }
    }
}
