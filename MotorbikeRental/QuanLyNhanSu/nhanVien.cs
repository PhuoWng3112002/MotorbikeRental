using MotorbikeRental.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorbikeRental.QuanLyNhanSu
{
    public partial class nhanVien : Form
    {
        taiKhoanBLL taiKhoanBLL = new taiKhoanBLL();
        public nhanVien()
        {
            InitializeComponent();
        }

        private void nhanVien_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvNV, taiKhoanBLL.findNV());
        }
        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }
    }
}
