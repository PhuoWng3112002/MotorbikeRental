
namespace MotorbikeRental.QuanLyChoThueXe
{
    partial class hopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.PK_iHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTongTienDatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTienThuePT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_iPhuongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayHenTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_sCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_sCMNDnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_iPhieuX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbIDPhuongTien = new System.Windows.Forms.TextBox();
            this.lbPhuongTienN = new System.Windows.Forms.Label();
            this.errorProviderHopDong = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbHangSX = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbCMNDNV = new System.Windows.Forms.Label();
            this.lbDSHopDong = new System.Windows.Forms.Label();
            this.lbTrongTai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDHopDong = new System.Windows.Forms.TextBox();
            this.lbNCC = new System.Windows.Forms.Label();
            this.plDSNCC = new System.Windows.Forms.Panel();
            this.plThongTinNCC = new System.Windows.Forms.Panel();
            this.cbCNMDKH = new System.Windows.Forms.ComboBox();
            this.cbCMNDNV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhieuXuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpNgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.btnLamMoi = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnTimKiem = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnXoa = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnThem = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnSua = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.tbTienThuePt = new System.Windows.Forms.TextBox();
            this.tbTongTienDatCoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHopDong)).BeginInit();
            this.plDSNCC.SuspendLayout();
            this.plThongTinNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 69);
            this.label2.TabIndex = 22;
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.AllowUserToDeleteRows = false;
            this.dgvHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_iHopDong,
            this.fTongTienDatCoc,
            this.fTienThuePT,
            this.FK_iPhuongTien,
            this.dNgayThue,
            this.dNgayHenTra,
            this.FK_sCMND,
            this.FK_sCMNDnv,
            this.FK_iPhieuX});
            this.dgvHopDong.GridColor = System.Drawing.Color.White;
            this.dgvHopDong.Location = new System.Drawing.Point(27, 72);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(1171, 284);
            this.dgvHopDong.TabIndex = 4;
            this.dgvHopDong.SelectionChanged += new System.EventHandler(this.dgvHopDong_SelectionChanged);
            // 
            // PK_iHopDong
            // 
            this.PK_iHopDong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PK_iHopDong.DataPropertyName = "PK_iHopDong";
            this.PK_iHopDong.HeaderText = "idHĐ";
            this.PK_iHopDong.MinimumWidth = 6;
            this.PK_iHopDong.Name = "PK_iHopDong";
            this.PK_iHopDong.ReadOnly = true;
            // 
            // fTongTienDatCoc
            // 
            this.fTongTienDatCoc.DataPropertyName = "fTongTienDatCoc";
            this.fTongTienDatCoc.HeaderText = "Tổng tiền";
            this.fTongTienDatCoc.MinimumWidth = 6;
            this.fTongTienDatCoc.Name = "fTongTienDatCoc";
            this.fTongTienDatCoc.ReadOnly = true;
            this.fTongTienDatCoc.Width = 125;
            // 
            // fTienThuePT
            // 
            this.fTienThuePT.DataPropertyName = "fTienThuePT";
            this.fTienThuePT.HeaderText = "Tiền Thuê PT";
            this.fTienThuePT.MinimumWidth = 6;
            this.fTienThuePT.Name = "fTienThuePT";
            this.fTienThuePT.ReadOnly = true;
            this.fTienThuePT.Width = 125;
            // 
            // FK_iPhuongTien
            // 
            this.FK_iPhuongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FK_iPhuongTien.DataPropertyName = "FK_iPhuongTien";
            this.FK_iPhuongTien.HeaderText = "Id Phương Tiện";
            this.FK_iPhuongTien.MinimumWidth = 6;
            this.FK_iPhuongTien.Name = "FK_iPhuongTien";
            this.FK_iPhuongTien.ReadOnly = true;
            // 
            // dNgayThue
            // 
            this.dNgayThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dNgayThue.DataPropertyName = "dNgayThue";
            this.dNgayThue.HeaderText = "Ngày Thuê";
            this.dNgayThue.MinimumWidth = 6;
            this.dNgayThue.Name = "dNgayThue";
            this.dNgayThue.ReadOnly = true;
            // 
            // dNgayHenTra
            // 
            this.dNgayHenTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dNgayHenTra.DataPropertyName = "dNgayHenTra";
            this.dNgayHenTra.HeaderText = "Ngày Trả";
            this.dNgayHenTra.MinimumWidth = 6;
            this.dNgayHenTra.Name = "dNgayHenTra";
            this.dNgayHenTra.ReadOnly = true;
            // 
            // FK_sCMND
            // 
            this.FK_sCMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FK_sCMND.DataPropertyName = "FK_sCMND";
            this.FK_sCMND.HeaderText = "CMND KH";
            this.FK_sCMND.MinimumWidth = 6;
            this.FK_sCMND.Name = "FK_sCMND";
            this.FK_sCMND.ReadOnly = true;
            // 
            // FK_sCMNDnv
            // 
            this.FK_sCMNDnv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FK_sCMNDnv.DataPropertyName = "FK_sCMNDnv";
            this.FK_sCMNDnv.HeaderText = "CMND NV";
            this.FK_sCMNDnv.MinimumWidth = 6;
            this.FK_sCMNDnv.Name = "FK_sCMNDnv";
            this.FK_sCMNDnv.ReadOnly = true;
            // 
            // FK_iPhieuX
            // 
            this.FK_iPhieuX.DataPropertyName = "FK_iPhieuX";
            this.FK_iPhieuX.HeaderText = "Id Phiếu Nhập";
            this.FK_iPhieuX.MinimumWidth = 6;
            this.FK_iPhieuX.Name = "FK_iPhieuX";
            this.FK_iPhieuX.ReadOnly = true;
            this.FK_iPhieuX.Width = 125;
            // 
            // tbIDPhuongTien
            // 
            this.tbIDPhuongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbIDPhuongTien.Location = new System.Drawing.Point(174, 109);
            this.tbIDPhuongTien.Name = "tbIDPhuongTien";
            this.tbIDPhuongTien.Size = new System.Drawing.Size(282, 27);
            this.tbIDPhuongTien.TabIndex = 15;
            // 
            // lbPhuongTienN
            // 
            this.lbPhuongTienN.AutoSize = true;
            this.lbPhuongTienN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhuongTienN.Location = new System.Drawing.Point(25, 112);
            this.lbPhuongTienN.Name = "lbPhuongTienN";
            this.lbPhuongTienN.Size = new System.Drawing.Size(115, 20);
            this.lbPhuongTienN.TabIndex = 14;
            this.lbPhuongTienN.Text = "ID Phương Tiện";
            // 
            // errorProviderHopDong
            // 
            this.errorProviderHopDong.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(19, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "II. Danh Sách Hợp Đồng";
            // 
            // lbHangSX
            // 
            this.lbHangSX.AutoSize = true;
            this.lbHangSX.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHangSX.Location = new System.Drawing.Point(25, 167);
            this.lbHangSX.Name = "lbHangSX";
            this.lbHangSX.Size = new System.Drawing.Size(140, 20);
            this.lbHangSX.TabIndex = 12;
            this.lbHangSX.Text = "CMND Khách hàng";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSL.Location = new System.Drawing.Point(545, 57);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(84, 20);
            this.lbSL.TabIndex = 10;
            this.lbSL.Text = "Ngày Thuê";
            // 
            // lbCMNDNV
            // 
            this.lbCMNDNV.AutoSize = true;
            this.lbCMNDNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCMNDNV.Location = new System.Drawing.Point(545, 166);
            this.lbCMNDNV.Name = "lbCMNDNV";
            this.lbCMNDNV.Size = new System.Drawing.Size(132, 20);
            this.lbCMNDNV.TabIndex = 8;
            this.lbCMNDNV.Text = "CMND Nhân Viên";
            // 
            // lbDSHopDong
            // 
            this.lbDSHopDong.AutoSize = true;
            this.lbDSHopDong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDSHopDong.Location = new System.Drawing.Point(435, 28);
            this.lbDSHopDong.Name = "lbDSHopDong";
            this.lbDSHopDong.Size = new System.Drawing.Size(280, 31);
            this.lbDSHopDong.TabIndex = 23;
            this.lbDSHopDong.Text = "DANH SÁCH HỢP ĐỒNG";
            // 
            // lbTrongTai
            // 
            this.lbTrongTai.AutoSize = true;
            this.lbTrongTai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTrongTai.Location = new System.Drawing.Point(545, 111);
            this.lbTrongTai.Name = "lbTrongTai";
            this.lbTrongTai.Size = new System.Drawing.Size(103, 20);
            this.lbTrongTai.TabIndex = 6;
            this.lbTrongTai.Text = "Ngày Hẹn Trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "I. Thông tin hợp đồng";
            // 
            // tbIDHopDong
            // 
            this.tbIDHopDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbIDHopDong.Location = new System.Drawing.Point(174, 54);
            this.tbIDHopDong.Name = "tbIDHopDong";
            this.tbIDHopDong.Size = new System.Drawing.Size(282, 27);
            this.tbIDHopDong.TabIndex = 2;
            // 
            // lbNCC
            // 
            this.lbNCC.AutoSize = true;
            this.lbNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNCC.Location = new System.Drawing.Point(25, 57);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(99, 20);
            this.lbNCC.TabIndex = 1;
            this.lbNCC.Text = "ID Hợp Đồng";
            // 
            // plDSNCC
            // 
            this.plDSNCC.Controls.Add(this.label3);
            this.plDSNCC.Controls.Add(this.dgvHopDong);
            this.plDSNCC.Location = new System.Drawing.Point(84, 589);
            this.plDSNCC.Name = "plDSNCC";
            this.plDSNCC.Size = new System.Drawing.Size(1201, 377);
            this.plDSNCC.TabIndex = 25;
            // 
            // plThongTinNCC
            // 
            this.plThongTinNCC.Controls.Add(this.tbTongTienDatCoc);
            this.plThongTinNCC.Controls.Add(this.tbTienThuePt);
            this.plThongTinNCC.Controls.Add(this.cbCNMDKH);
            this.plThongTinNCC.Controls.Add(this.cbCMNDNV);
            this.plThongTinNCC.Controls.Add(this.label7);
            this.plThongTinNCC.Controls.Add(this.label5);
            this.plThongTinNCC.Controls.Add(this.txtPhieuXuat);
            this.plThongTinNCC.Controls.Add(this.label4);
            this.plThongTinNCC.Controls.Add(this.dpNgayHenTra);
            this.plThongTinNCC.Controls.Add(this.dtpNgayThue);
            this.plThongTinNCC.Controls.Add(this.btnLamMoi);
            this.plThongTinNCC.Controls.Add(this.btnTimKiem);
            this.plThongTinNCC.Controls.Add(this.btnXoa);
            this.plThongTinNCC.Controls.Add(this.tbIDPhuongTien);
            this.plThongTinNCC.Controls.Add(this.btnThem);
            this.plThongTinNCC.Controls.Add(this.lbPhuongTienN);
            this.plThongTinNCC.Controls.Add(this.btnSua);
            this.plThongTinNCC.Controls.Add(this.lbHangSX);
            this.plThongTinNCC.Controls.Add(this.lbSL);
            this.plThongTinNCC.Controls.Add(this.lbCMNDNV);
            this.plThongTinNCC.Controls.Add(this.lbTrongTai);
            this.plThongTinNCC.Controls.Add(this.label1);
            this.plThongTinNCC.Controls.Add(this.tbIDHopDong);
            this.plThongTinNCC.Controls.Add(this.lbNCC);
            this.plThongTinNCC.Location = new System.Drawing.Point(84, 92);
            this.plThongTinNCC.Name = "plThongTinNCC";
            this.plThongTinNCC.Size = new System.Drawing.Size(1019, 462);
            this.plThongTinNCC.TabIndex = 24;
            // 
            // cbCNMDKH
            // 
            this.cbCNMDKH.FormattingEnabled = true;
            this.cbCNMDKH.Location = new System.Drawing.Point(174, 166);
            this.cbCNMDKH.Name = "cbCNMDKH";
            this.cbCNMDKH.Size = new System.Drawing.Size(282, 24);
            this.cbCNMDKH.TabIndex = 44;
            // 
            // cbCMNDNV
            // 
            this.cbCMNDNV.FormattingEnabled = true;
            this.cbCMNDNV.Location = new System.Drawing.Point(686, 162);
            this.cbCMNDNV.Name = "cbCMNDNV";
            this.cbCMNDNV.Size = new System.Drawing.Size(291, 24);
            this.cbCMNDNV.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(545, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tiền Thuê Phương Tiện: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(18, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tổng Tiền Đặt Cọc : ";
            // 
            // txtPhieuXuat
            // 
            this.txtPhieuXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhieuXuat.Location = new System.Drawing.Point(174, 228);
            this.txtPhieuXuat.Name = "txtPhieuXuat";
            this.txtPhieuXuat.Size = new System.Drawing.Size(282, 27);
            this.txtPhieuXuat.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(25, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "ID Phiếu Xuất";
            // 
            // dpNgayHenTra
            // 
            this.dpNgayHenTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dpNgayHenTra.CustomFormat = " ";
            this.dpNgayHenTra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dpNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNgayHenTra.Location = new System.Drawing.Point(686, 110);
            this.dpNgayHenTra.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.dpNgayHenTra.Name = "dpNgayHenTra";
            this.dpNgayHenTra.Size = new System.Drawing.Size(291, 30);
            this.dpNgayHenTra.TabIndex = 33;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayThue.CustomFormat = " ";
            this.dtpNgayThue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThue.Location = new System.Drawing.Point(686, 57);
            this.dtpNgayThue.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(291, 30);
            this.dtpNgayThue.TabIndex = 32;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnLamMoi.BorderRadius = 14;
            this.btnLamMoi.BorderSize = 2;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(835, 344);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextColor = System.Drawing.Color.Black;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(635, 344);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(150, 40);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 14;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(435, 344);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 15;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(35, 344);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 15;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(235, 344);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tbTienThuePt
            // 
            this.tbTienThuePt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTienThuePt.Location = new System.Drawing.Point(726, 225);
            this.tbTienThuePt.Name = "tbTienThuePt";
            this.tbTienThuePt.Size = new System.Drawing.Size(251, 27);
            this.tbTienThuePt.TabIndex = 45;
            // 
            // tbTongTienDatCoc
            // 
            this.tbTongTienDatCoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTongTienDatCoc.Location = new System.Drawing.Point(174, 289);
            this.tbTongTienDatCoc.Name = "tbTongTienDatCoc";
            this.tbTongTienDatCoc.Size = new System.Drawing.Size(282, 27);
            this.tbTongTienDatCoc.TabIndex = 46;
            // 
            // hopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 1004);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDSHopDong);
            this.Controls.Add(this.plDSNCC);
            this.Controls.Add(this.plThongTinNCC);
            this.Name = "hopDong";
            this.Load += new System.EventHandler(this.hopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHopDong)).EndInit();
            this.plDSNCC.ResumeLayout(false);
            this.plDSNCC.PerformLayout();
            this.plThongTinNCC.ResumeLayout(false);
            this.plThongTinNCC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private PresentationLayer.Custom.VBButton btnLamMoi;
        private PresentationLayer.Custom.VBButton btnTimKiem;
        private PresentationLayer.Custom.VBButton btnXoa;
        private System.Windows.Forms.TextBox tbIDPhuongTien;
        private PresentationLayer.Custom.VBButton btnThem;
        private System.Windows.Forms.Label lbPhuongTienN;
        private PresentationLayer.Custom.VBButton btnSua;
        private System.Windows.Forms.ErrorProvider errorProviderHopDong;
        private System.Windows.Forms.Label lbDSHopDong;
        private System.Windows.Forms.Panel plDSNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel plThongTinNCC;
        private System.Windows.Forms.Label lbHangSX;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbCMNDNV;
        private System.Windows.Forms.Label lbTrongTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIDHopDong;
        private System.Windows.Forms.Label lbNCC;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.DateTimePicker dpNgayHenTra;
        private System.Windows.Forms.TextBox txtPhieuXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCMNDNV;
        private System.Windows.Forms.ComboBox cbCNMDKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_iHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTongTienDatCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTienThuePT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_iPhuongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayHenTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_sCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_sCMNDnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_iPhieuX;
        private System.Windows.Forms.TextBox tbTongTienDatCoc;
        private System.Windows.Forms.TextBox tbTienThuePt;
    }
}