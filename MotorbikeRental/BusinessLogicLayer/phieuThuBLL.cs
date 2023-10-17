using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{
    class phieuThuBLL
    {
        phieuThuDAL phieuThuDAL = new phieuThuDAL();
        public DataTable findAll()
        {
            return phieuThuDAL.findAll();
        }
    }
}
