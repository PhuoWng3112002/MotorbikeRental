using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MotorbikeRental.BusinessLogicLayer;

namespace MotorbikeRental.DangNhap_DangKi
{
    public partial class DangNhap : Form
    {
        //******************************
        private const string MS_001 = "Vui lòng nhập đủ thông tin";
        private const string MS_002 = "Sai tên tài khoản";
        private const string MS_003 = "Sai mật khẩu";
        private const string MS_004 = "Tài khoản không tồn tại";
        taiKhoanBLL taiKhoanBLL = new taiKhoanBLL();
        //******************************
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        bool isMouseDown;

        int xLast;
        int yLast;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            isMouseDown = true;
            xLast = e.X;
            yLast = e.Y;

            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int newY = this.Top + (e.Y - yLast);
                int newX = this.Left + (e.X - xLast);

                this.Location = new Point(newX, newY);
            }

            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            isMouseDown = false;

            base.OnMouseUp(e);
        }
        /**************************/
        public DangNhap()
        {
            InitializeComponent();
        }
        //**** CHECK valid login

        public bool checkValidDangNhap(string tenTK, string matKhau)
        {
            if (tenTK.Equals("") || matKhau.Equals(""))
                return false;

            return true;
        }

        //******************************
        private void DangNhap_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 15;
            path.AddArc(0, 0, radius, radius, 180, 90);// Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);//Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);//Bottom-right corner

            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);//Bottom-left corner

            //Create a region with the rounded rectangle path and apply it to the form - ok u know?
            this.Region = new Region(path);

            //************************

            tbTK.Clear();
            tbMK.Clear();

            tbTK.Focus();
        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbHienMK.Checked == false) 
            {
                tbMK.PasswordChar = '*';
            }
            else
            {
                tbMK.PasswordChar = '\0';
            }

        }

        private void link_QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenMK mk = new quenMK();
            mk.Show();
        }

        private void link_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk= new DangNhap_DangKi.DangKy();
            dk.Show();
            this.Hide();
        }

    

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void ckbHienMK_CheckStateChanged(object sender, EventArgs e)
        {
           
        }


        private void btnDangNhap_Click(object sender, EventArgs e)

        {

            //LayoutMaster lm = new LayoutMaster();
            //lm.Show();
            //this.Hide();
            if (!checkValidDangNhap(tbTK.Text, tbMK.Text))
            {
                errorProviderLogin.SetError(tbTK, MS_001);
                errorProviderLogin.SetError(tbMK, MS_001);
            }
            else
            {
                errorProviderLogin.Clear();

                if (taiKhoanBLL.login(tbTK.Text, tbMK.Text) == 0)
                    errorProviderLogin.SetError(tbTK, MS_002);
                else if (taiKhoanBLL.login(tbTK.Text, tbMK.Text) == 2)
                {
                    errorProviderLogin.SetError(tbMK, MS_003);
                    tbMK.Text = "";
                }
                else if (taiKhoanBLL.login(tbTK.Text, tbMK.Text) == 1)
                {
                    new LayoutMaster().Show();
                    this.Hide();
                }
            }
        }

       
        private void panel_Title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangNhap_DangKi.DangKy();
            dk.Show();
            this.Hide();
        }
    }
}
