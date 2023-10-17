using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{



    internal class banGiaoBLL
    {
        banGiaoDAL banGiaoDAL = new banGiaoDAL();

        public DataTable findAll()
        {
            return banGiaoDAL.findAll();
        }

        public bool insert(int PK_iHopDong, int iPhuongTien, DateTime dNgayThue, DateTime dNgayHenTra, float fTongTienDatCoc, float fTienThuePT, string sGhiChu, string FK_sCMND, string FK_sCMNDnv)
        {
            return banGiaoDAL.insert(PK_iHopDong, iPhuongTien, dNgayThue, dNgayHenTra, fTongTienDatCoc, fTienThuePT, sGhiChu, FK_sCMND, FK_sCMNDnv);
        }


        public bool update(int PK_iHopDong, int iPhuongTien, DateTime dNgayThue, DateTime dNgayHenTra, float fTongTienDatCoc, float fTienThuePT, string sGhiChu, string FK_sCMND, string FK_sCMNDnv)
        {
            return banGiaoDAL.update(PK_iHopDong, iPhuongTien, dNgayThue, dNgayHenTra, fTongTienDatCoc, fTienThuePT, sGhiChu, FK_sCMND, FK_sCMNDnv);
        }
    }
}