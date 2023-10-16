
namespace MotorbikeRental.QuanLyNhanSu
{
    partial class quyen
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
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.PK_iChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCV = new System.Windows.Forms.TextBox();
            this.lbsChucVu = new System.Windows.Forms.Label();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.lbsGhiChu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaCV = new System.Windows.Forms.TextBox();
            this.lbiChucVu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProviderChucVu = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLuu = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnLamMoi = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnSua = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnThem = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_iChucVu,
            this.sChucVu,
            this.sGhiChu});
            this.dgvChucVu.Location = new System.Drawing.Point(31, 57);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.RowHeadersWidth = 51;
            this.dgvChucVu.RowTemplate.Height = 24;
            this.dgvChucVu.Size = new System.Drawing.Size(414, 264);
            this.dgvChucVu.TabIndex = 4;
            this.dgvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellContentClick);
            // 
            // PK_iChucVu
            // 
            this.PK_iChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PK_iChucVu.DataPropertyName = "PK_iChucVu";
            this.PK_iChucVu.HeaderText = "Mã chức vụ";
            this.PK_iChucVu.MinimumWidth = 6;
            this.PK_iChucVu.Name = "PK_iChucVu";
            // 
            // sChucVu
            // 
            this.sChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sChucVu.DataPropertyName = "sChucVu";
            this.sChucVu.HeaderText = "Chức vu";
            this.sChucVu.MinimumWidth = 6;
            this.sChucVu.Name = "sChucVu";
            // 
            // sGhiChu
            // 
            this.sGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sGhiChu.DataPropertyName = "sGhiChu";
            this.sGhiChu.HeaderText = "Ghi chú";
            this.sGhiChu.MinimumWidth = 6;
            this.sGhiChu.Name = "sGhiChu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(297, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN TRỊ QUYỀN _ CHỨC VỤ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCV);
            this.panel1.Controls.Add(this.lbsChucVu);
            this.panel1.Controls.Add(this.tbGhiChu);
            this.panel1.Controls.Add(this.lbsGhiChu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbMaCV);
            this.panel1.Controls.Add(this.lbiChucVu);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(26, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 395);
            this.panel1.TabIndex = 5;
            // 
            // tbCV
            // 
            this.tbCV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbCV.Location = new System.Drawing.Point(134, 112);
            this.tbCV.Name = "tbCV";
            this.tbCV.Size = new System.Drawing.Size(282, 27);
            this.tbCV.TabIndex = 9;
            // 
            // lbsChucVu
            // 
            this.lbsChucVu.AutoSize = true;
            this.lbsChucVu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsChucVu.Location = new System.Drawing.Point(49, 115);
            this.lbsChucVu.Name = "lbsChucVu";
            this.lbsChucVu.Size = new System.Drawing.Size(64, 20);
            this.lbsChucVu.TabIndex = 8;
            this.lbsChucVu.Text = "Chức vụ";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbGhiChu.Location = new System.Drawing.Point(134, 162);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(282, 127);
            this.tbGhiChu.TabIndex = 7;
            // 
            // lbsGhiChu
            // 
            this.lbsGhiChu.AutoSize = true;
            this.lbsGhiChu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsGhiChu.Location = new System.Drawing.Point(52, 165);
            this.lbsGhiChu.Name = "lbsGhiChu";
            this.lbsGhiChu.Size = new System.Drawing.Size(61, 20);
            this.lbsGhiChu.TabIndex = 6;
            this.lbsGhiChu.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "I. Thông tin quyền _ Chức vụ";
            // 
            // tbMaCV
            // 
            this.tbMaCV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMaCV.Location = new System.Drawing.Point(134, 54);
            this.tbMaCV.Name = "tbMaCV";
            this.tbMaCV.ReadOnly = true;
            this.tbMaCV.Size = new System.Drawing.Size(282, 27);
            this.tbMaCV.TabIndex = 2;
            this.tbMaCV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaCV_KeyPress);
            // 
            // lbiChucVu
            // 
            this.lbiChucVu.AutoSize = true;
            this.lbiChucVu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbiChucVu.Location = new System.Drawing.Point(25, 57);
            this.lbiChucVu.Name = "lbiChucVu";
            this.lbiChucVu.Size = new System.Drawing.Size(88, 20);
            this.lbiChucVu.TabIndex = 1;
            this.lbiChucVu.Text = "Mã chức vụ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLamMoi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 295);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvChucVu);
            this.panel2.Location = new System.Drawing.Point(503, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 412);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(27, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "II. Danh sách quyền _ Chức vụ";
            // 
            // errorProviderChucVu
            // 
            this.errorProviderChucVu.ContainerControl = this;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 15;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(35, 55);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 40);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnLamMoi.Location = new System.Drawing.Point(257, 55);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextColor = System.Drawing.Color.Black;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            this.btnSua.Location = new System.Drawing.Point(257, 5);
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
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(35, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm quyền mới";
            this.btnThem.TextColor = System.Drawing.Color.Black;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // quyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "quyen";
            this.Text = "quyen";
            this.Load += new System.EventHandler(this.quyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCV;
        private System.Windows.Forms.Label lbsChucVu;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label lbsGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaCV;
        private System.Windows.Forms.Label lbiChucVu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PresentationLayer.Custom.VBButton btnLamMoi;
        private PresentationLayer.Custom.VBButton btnSua;
        private PresentationLayer.Custom.VBButton btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_iChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGhiChu;
        private PresentationLayer.Custom.VBButton btnLuu;
        private System.Windows.Forms.ErrorProvider errorProviderChucVu;
    }
}