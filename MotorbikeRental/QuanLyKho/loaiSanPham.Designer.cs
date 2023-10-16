
namespace MotorbikeRental.QuanLyKho
{
    partial class loaiSanPham
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamMoi = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnXoa = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnSua = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnThem = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaPT = new System.Windows.Forms.TextBox();
            this.lbAnh = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimKiem = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.panelTTPT = new System.Windows.Forms.Panel();
            this.tbLoaiPT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPhanKhoi = new System.Windows.Forms.TextBox();
            this.lbsPhanKhoi = new System.Windows.Forms.Label();
            this.dgvLoaiPT = new System.Windows.Forms.DataGridView();
            this.PK_iLoaiPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLoaiPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhanKhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDSPT = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderLoaiPT = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTTPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPT)).BeginInit();
            this.panelDSPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLoaiPT)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "II. Danh sách loại phương tiện";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnLamMoi.BorderRadius = 15;
            this.btnLamMoi.BorderSize = 2;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(273, 63);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextColor = System.Drawing.Color.Black;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 15;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(41, 63);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(273, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(41, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "I. Thông tin loại phương tiện";
            // 
            // tbMaPT
            // 
            this.tbMaPT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMaPT.Location = new System.Drawing.Point(170, 61);
            this.tbMaPT.Name = "tbMaPT";
            this.tbMaPT.Size = new System.Drawing.Size(282, 27);
            this.tbMaPT.TabIndex = 2;
            this.tbMaPT.TextChanged += new System.EventHandler(this.tbMaPT_TextChanged);
            this.tbMaPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaPT_KeyPress);
            // 
            // lbAnh
            // 
            this.lbAnh.AutoSize = true;
            this.lbAnh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAnh.Location = new System.Drawing.Point(21, 61);
            this.lbAnh.Name = "lbAnh";
            this.lbAnh.Size = new System.Drawing.Size(119, 20);
            this.lbAnh.TabIndex = 1;
            this.lbAnh.Text = "Mã phương tiện";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.43103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.56897F));
            this.tableLayoutPanel1.Controls.Add(this.btnTimKiem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLamMoi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 236);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.94805F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.05195F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 156);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.btnTimKiem.Location = new System.Drawing.Point(45, 112);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(143, 40);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panelTTPT
            // 
            this.panelTTPT.Controls.Add(this.tbLoaiPT);
            this.panelTTPT.Controls.Add(this.label5);
            this.panelTTPT.Controls.Add(this.tbPhanKhoi);
            this.panelTTPT.Controls.Add(this.lbsPhanKhoi);
            this.panelTTPT.Controls.Add(this.label2);
            this.panelTTPT.Controls.Add(this.tbMaPT);
            this.panelTTPT.Controls.Add(this.lbAnh);
            this.panelTTPT.Controls.Add(this.tableLayoutPanel1);
            this.panelTTPT.Location = new System.Drawing.Point(38, 103);
            this.panelTTPT.Name = "panelTTPT";
            this.panelTTPT.Size = new System.Drawing.Size(470, 395);
            this.panelTTPT.TabIndex = 5;
            // 
            // tbLoaiPT
            // 
            this.tbLoaiPT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbLoaiPT.Location = new System.Drawing.Point(170, 118);
            this.tbLoaiPT.Name = "tbLoaiPT";
            this.tbLoaiPT.Size = new System.Drawing.Size(282, 27);
            this.tbLoaiPT.TabIndex = 9;
            this.tbLoaiPT.TextChanged += new System.EventHandler(this.tbLoaiPT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(15, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại phương tiện";
            // 
            // tbPhanKhoi
            // 
            this.tbPhanKhoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPhanKhoi.Location = new System.Drawing.Point(170, 176);
            this.tbPhanKhoi.Name = "tbPhanKhoi";
            this.tbPhanKhoi.Size = new System.Drawing.Size(282, 27);
            this.tbPhanKhoi.TabIndex = 7;
            this.tbPhanKhoi.TextChanged += new System.EventHandler(this.tbPhanKhoi_TextChanged);
            // 
            // lbsPhanKhoi
            // 
            this.lbsPhanKhoi.AutoSize = true;
            this.lbsPhanKhoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsPhanKhoi.Location = new System.Drawing.Point(62, 176);
            this.lbsPhanKhoi.Name = "lbsPhanKhoi";
            this.lbsPhanKhoi.Size = new System.Drawing.Size(78, 20);
            this.lbsPhanKhoi.TabIndex = 6;
            this.lbsPhanKhoi.Text = "Phân khối";
            // 
            // dgvLoaiPT
            // 
            this.dgvLoaiPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_iLoaiPT,
            this.sLoaiPT,
            this.sPhanKhoi});
            this.dgvLoaiPT.Location = new System.Drawing.Point(26, 61);
            this.dgvLoaiPT.Name = "dgvLoaiPT";
            this.dgvLoaiPT.RowHeadersWidth = 51;
            this.dgvLoaiPT.RowTemplate.Height = 24;
            this.dgvLoaiPT.Size = new System.Drawing.Size(414, 312);
            this.dgvLoaiPT.TabIndex = 1;
            this.dgvLoaiPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiPT_CellContentClick);
            // 
            // PK_iLoaiPT
            // 
            this.PK_iLoaiPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PK_iLoaiPT.DataPropertyName = "PK_iLoaiPT";
            this.PK_iLoaiPT.HeaderText = "Mã loại phương tiện";
            this.PK_iLoaiPT.MinimumWidth = 6;
            this.PK_iLoaiPT.Name = "PK_iLoaiPT";
            this.PK_iLoaiPT.Width = 127;
            // 
            // sLoaiPT
            // 
            this.sLoaiPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sLoaiPT.DataPropertyName = "sLoaiPT";
            this.sLoaiPT.HeaderText = "Loai phương tiện";
            this.sLoaiPT.MinimumWidth = 6;
            this.sLoaiPT.Name = "sLoaiPT";
            // 
            // sPhanKhoi
            // 
            this.sPhanKhoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sPhanKhoi.DataPropertyName = "sPhanKhoi";
            this.sPhanKhoi.HeaderText = "Phân khối";
            this.sPhanKhoi.MinimumWidth = 6;
            this.sPhanKhoi.Name = "sPhanKhoi";
            // 
            // panelDSPT
            // 
            this.panelDSPT.Controls.Add(this.label3);
            this.panelDSPT.Controls.Add(this.dgvLoaiPT);
            this.panelDSPT.Location = new System.Drawing.Point(514, 103);
            this.panelDSPT.Name = "panelDSPT";
            this.panelDSPT.Size = new System.Drawing.Size(479, 395);
            this.panelDSPT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(308, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH SÁCH LOẠI PHƯƠNG TIỆN";
            // 
            // errorProviderLoaiPT
            // 
            this.errorProviderLoaiPT.ContainerControl = this;
            // 
            // loaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 530);
            this.Controls.Add(this.panelTTPT);
            this.Controls.Add(this.panelDSPT);
            this.Controls.Add(this.label1);
            this.Name = "loaiSanPham";
            this.Text = "loaiSanPham";
            this.Load += new System.EventHandler(this.loaiSanPham_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTTPT.ResumeLayout(false);
            this.panelTTPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPT)).EndInit();
            this.panelDSPT.ResumeLayout(false);
            this.panelDSPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLoaiPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private PresentationLayer.Custom.VBButton btnLamMoi;
        private PresentationLayer.Custom.VBButton btnXoa;
        private PresentationLayer.Custom.VBButton btnSua;
        private PresentationLayer.Custom.VBButton btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaPT;
        private System.Windows.Forms.Label lbAnh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTTPT;
        private System.Windows.Forms.TextBox tbLoaiPT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPhanKhoi;
        private System.Windows.Forms.Label lbsPhanKhoi;
        private System.Windows.Forms.DataGridView dgvLoaiPT;
        private System.Windows.Forms.Panel panelDSPT;
        private System.Windows.Forms.Label label1;
        private PresentationLayer.Custom.VBButton btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_iLoaiPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLoaiPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhanKhoi;
        private System.Windows.Forms.ErrorProvider errorProviderLoaiPT;
    }
}