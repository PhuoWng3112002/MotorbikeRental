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
    public partial class lienHe : Form
    {
        private const string MS_001 = "Cảm ơn bạn. Chúng tôi sẽ liên hệ bạn sớm nhất!";
        private const string MS_Infor = "Thông báo";
        public lienHe()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show(MS_001, MS_Infor, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK){
                LayoutMaster lm = new LayoutMaster();
                lm.Show();
            }

        }
    }
}
