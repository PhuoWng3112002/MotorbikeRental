using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{
    internal class hopDongBLL
    {
        hopDongDAL hopDongDAL = new hopDongDAL();
        public DataTable findAll()
        {
            return hopDongDAL.findAll();
        }

        public bool insert(int PK_iHopDong, int FK_iPhuongTien, DateTime dNgayThue, DateTime dNgayHenTra, float fTongTienDatCoc, float fTienThuePT, string FK_sCMND, string FK_sCMNDnv, int FK_iPhieuX)
        {
            return hopDongDAL.insert(PK_iHopDong, FK_iPhuongTien, dNgayThue, dNgayHenTra, fTongTienDatCoc, fTienThuePT, FK_sCMND, FK_sCMNDnv, FK_iPhieuX);
        }


        public bool update(int PK_iHopDong, int FK_iPhuongTien, DateTime dNgayThue, DateTime dNgayHenTra, float fTongTienDatCoc, float fTienThuePT, string FK_sCMND, string FK_sCMNDnv, int FK_iPhieuX)
        {
            return hopDongDAL.update(PK_iHopDong, FK_iPhuongTien, dNgayThue, dNgayHenTra, fTongTienDatCoc, fTienThuePT, FK_sCMND, FK_sCMNDnv, FK_iPhieuX);
        }


    }
}