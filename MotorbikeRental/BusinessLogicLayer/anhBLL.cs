using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{
    class anhBLL
    {
        anhDAL anhDAL = new anhDAL();
        public DataTable findAll()
        {
            return anhDAL.findAll();
        }

        public bool insert(string PK_iAnh,Image sUrl)
        {
            if (string.IsNullOrEmpty(PK_iAnh))
                return false;
            else
                return anhDAL.insert(PK_iAnh,sUrl);
        }
        public bool checkExistsNameAndCategory(string PK_iAnh)
        {
            DataTable dt = anhDAL.findAll();

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["PK_iAnh"].ToString(), PK_iAnh, StringComparison.InvariantCultureIgnoreCase))
                    return false;
                else if (!string.IsNullOrEmpty(PK_iAnh))
                    if (!int.TryParse(PK_iAnh, out _) || int.Parse(PK_iAnh) <= 0)
                        return false;
            }

            return true;
        }
        public bool update(string PK_iAnh, Image sUrl)
        {

            if (string.IsNullOrEmpty(PK_iAnh))
                return false;

            else
                return anhDAL.update(PK_iAnh, sUrl);
        }
        public bool deleteById(string iAnh)
        {
            if (string.IsNullOrEmpty(iAnh))
            {
                return false;
            }
            return anhDAL.deleteById(iAnh);
        }
        public DataTable search(string PK_iAnh)
        {

            if (string.IsNullOrEmpty(PK_iAnh))
                return null;
            return anhDAL.search(PK_iAnh);
        }

    }
}
