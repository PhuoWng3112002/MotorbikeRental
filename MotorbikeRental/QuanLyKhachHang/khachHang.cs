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

namespace MotorbikeRental.QuanLyKhachHang
{
    public partial class khachHang : Form
    {
        taiKhoanBLL taiKhoanBLL = new taiKhoanBLL();
        public khachHang()
        {
            InitializeComponent();
        }

        private void khachHang_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvKH, taiKhoanBLL.findND());
        }
        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }
    }
}
