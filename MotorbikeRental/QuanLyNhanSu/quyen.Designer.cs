
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
            this.dgvAnhPT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnh = new System.Windows.Forms.TextBox();
            this.lbiChucVu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vbButton4 = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.vbButton2 = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.btnThem = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbsGhiChu = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbsChucVu = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.vbButton1 = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.PK_iChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnhPT)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAnhPT
            // 
            this.dgvAnhPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnhPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_iChucVu,
            this.sChucVu,
            this.sGhiChu});
            this.dgvAnhPT.Location = new System.Drawing.Point(31, 57);
            this.dgvAnhPT.Name = "dgvAnhPT";
            this.dgvAnhPT.RowHeadersWidth = 51;
            this.dgvAnhPT.RowTemplate.Height = 24;
            this.dgvAnhPT.Size = new System.Drawing.Size(414, 264);
            this.dgvAnhPT.TabIndex = 4;
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
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lbsChucVu);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbsGhiChu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbAnh);
            this.panel1.Controls.Add(this.lbiChucVu);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(26, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 395);
            this.panel1.TabIndex = 5;
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
            // tbAnh
            // 
            this.tbAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbAnh.Location = new System.Drawing.Point(134, 54);
            this.tbAnh.Name = "tbAnh";
            this.tbAnh.ReadOnly = true;
            this.tbAnh.Size = new System.Drawing.Size(282, 27);
            this.tbAnh.TabIndex = 2;
            this.tbAnh.TextChanged += new System.EventHandler(this.tbAnh_TextChanged);
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
            this.tableLayoutPanel1.Controls.Add(this.vbButton1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.vbButton4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.vbButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 295);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // vbButton4
            // 
            this.vbButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbButton4.BackColor = System.Drawing.Color.Transparent;
            this.vbButton4.BackgroundColor = System.Drawing.Color.Transparent;
            this.vbButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.vbButton4.BorderRadius = 15;
            this.vbButton4.BorderSize = 2;
            this.vbButton4.FlatAppearance.BorderSize = 0;
            this.vbButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton4.ForeColor = System.Drawing.Color.Black;
            this.vbButton4.Location = new System.Drawing.Point(257, 55);
            this.vbButton4.Name = "vbButton4";
            this.vbButton4.Size = new System.Drawing.Size(150, 40);
            this.vbButton4.TabIndex = 3;
            this.vbButton4.Text = "Làm mới";
            this.vbButton4.TextColor = System.Drawing.Color.Black;
            this.vbButton4.UseVisualStyleBackColor = false;
            // 
            // vbButton2
            // 
            this.vbButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.vbButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 15;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(257, 5);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(150, 40);
            this.vbButton2.TabIndex = 1;
            this.vbButton2.Text = "Sửa";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
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
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(134, 162);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 127);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.Location = new System.Drawing.Point(134, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 27);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvAnhPT);
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
            // vbButton1
            // 
            this.vbButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.vbButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 15;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(35, 55);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(150, 40);
            this.vbButton1.TabIndex = 4;
            this.vbButton1.Text = "Lưu";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnhPT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnhPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbsChucVu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbsGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnh;
        private System.Windows.Forms.Label lbiChucVu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PresentationLayer.Custom.VBButton vbButton4;
        private PresentationLayer.Custom.VBButton vbButton2;
        private PresentationLayer.Custom.VBButton btnThem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_iChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGhiChu;
        private PresentationLayer.Custom.VBButton vbButton1;
    }
}