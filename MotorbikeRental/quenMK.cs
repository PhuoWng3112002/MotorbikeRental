using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorbikeRental
{
    public partial class quenMK : Form
    {
        public quenMK()
        {
            InitializeComponent();
        }

        private void quenMK_Load(object sender, EventArgs e)
        {
            lbNhapCMND_b1.Show();
            lbCMND_b1.Show();
            btnNext.Show();
            txbCMND_b1.Show();


            lbTraloiCHBM_b2.Hide();
            lbCau1_b2.Hide();
            lbCau2_b2.Hide();
            lbTraloi1_b2.Hide();
            lbTraloi2_b2.Hide();
            txbTraloi1_b2.Hide();
            txbTraloi2_b2.Hide();
            cbCauhoi1_b2.Hide();
            cbCauhoi2_b2.Hide();
            btnPrev.Hide();
            btnLayLaiMK.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lbNhapCMND_b1.Hide();
            lbCMND_b1.Hide();
            btnNext.Hide();
            txbCMND_b1.Hide();

            lbTraloiCHBM_b2.Show();
            lbCau1_b2.Show();
            lbCau2_b2.Show();
            lbTraloi1_b2.Show();
            lbTraloi2_b2.Show();
            txbTraloi1_b2.Show();
            txbTraloi2_b2.Show();
            cbCauhoi1_b2.Show();
            cbCauhoi2_b2.Show();
            btnPrev.Show();
            btnLayLaiMK.Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lbNhapCMND_b1.Show();
            lbCMND_b1.Show();
            btnNext.Show();
            txbCMND_b1.Show();


            lbTraloiCHBM_b2.Hide();
            lbCau1_b2.Hide();
            lbCau2_b2.Hide();
            lbTraloi1_b2.Hide();
            lbTraloi2_b2.Hide();
            txbTraloi1_b2.Hide();
            txbTraloi2_b2.Hide();
            cbCauhoi1_b2.Hide();
            cbCauhoi2_b2.Hide();
            btnPrev.Hide();
            btnLayLaiMK.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
