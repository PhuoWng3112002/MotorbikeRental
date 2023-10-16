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
    public partial class danhGia : Form
    {
        public danhGia()
        {
            InitializeComponent();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {

        }

        private void vbButton5_Click(object sender, EventArgs e)
        {

        }

        private void vbButton3_Click(object sender, EventArgs e)
        {

        }

        private void vbButton4_Click(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void danhGia_Load(object sender, EventArgs e)
        {
            if (Program.maQuyen.Equals(Program.maQuyenBanHang))
            {
               
                panelKHEnable.Visible = false;
               
            }
            if (Program.maQuyen.Equals(Program.maQuyenQuanLy))
            {

                panelKHEnable.Visible = false;

            }
        }
    }
}
