
namespace MotorbikeRental.QuanLyKho
{
    partial class anh
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAnhPT = new System.Windows.Forms.DataGridView();
            this.iAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUrl = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChonAnh = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.tbAnh = new System.Windows.Forms.TextBox();
            this.lbAnh = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vbButton4 = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.vbButton3 = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.vbButton2 = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.vbButton1 = new MotorbikeRental.PresentationLayer.Custom.VBButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnhPT)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(282, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH ẢNH PHƯƠNG TIỆN";
            // 
            // dgvAnhPT
            // 
            this.dgvAnhPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnhPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iAnh,
            this.sUrl});
            this.dgvAnhPT.Location = new System.Drawing.Point(33, 54);
            this.dgvAnhPT.Name = "dgvAnhPT";
            this.dgvAnhPT.RowHeadersWidth = 51;
            this.dgvAnhPT.RowTemplate.Height = 24;
            this.dgvAnhPT.Size = new System.Drawing.Size(414, 312);
            this.dgvAnhPT.TabIndex = 1;
            // 
            // iAnh
            // 
            this.iAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iAnh.DataPropertyName = "iAnh";
            this.iAnh.HeaderText = "iAnh";
            this.iAnh.MinimumWidth = 6;
            this.iAnh.Name = "iAnh";
            // 
            // sUrl
            // 
            this.sUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sUrl.DataPropertyName = "sUrl";
            this.sUrl.HeaderText = "Image";
            this.sUrl.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.sUrl.MinimumWidth = 6;
            this.sUrl.Name = "sUrl";
            this.sUrl.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sUrl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnChonAnh);
            this.panel1.Controls.Add(this.pbAnh);
            this.panel1.Controls.Add(this.tbAnh);
            this.panel1.Controls.Add(this.lbAnh);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 395);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "I. Thông tin ảnh phương tiện";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(31)))));
            this.btnChonAnh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(31)))));
            this.btnChonAnh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChonAnh.BorderRadius = 5;
            this.btnChonAnh.BorderSize = 0;
            this.btnChonAnh.FlatAppearance.BorderSize = 0;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(231, 234);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(150, 40);
            this.btnChonAnh.TabIndex = 4;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.TextColor = System.Drawing.Color.White;
            this.btnChonAnh.UseVisualStyleBackColor = false;
            // 
            // pbAnh
            // 
            this.pbAnh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbAnh.Location = new System.Drawing.Point(29, 102);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(182, 172);
            this.pbAnh.TabIndex = 3;
            this.pbAnh.TabStop = false;
            // 
            // tbAnh
            // 
            this.tbAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbAnh.Location = new System.Drawing.Point(99, 54);
            this.tbAnh.Name = "tbAnh";
            this.tbAnh.Size = new System.Drawing.Size(282, 27);
            this.tbAnh.TabIndex = 2;
            // 
            // lbAnh
            // 
            this.lbAnh.AutoSize = true;
            this.lbAnh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAnh.Location = new System.Drawing.Point(25, 57);
            this.lbAnh.Name = "lbAnh";
            this.lbAnh.Size = new System.Drawing.Size(54, 20);
            this.lbAnh.TabIndex = 1;
            this.lbAnh.Text = "ID ảnh";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.vbButton4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.vbButton3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.vbButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.vbButton1, 0, 0);
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
            // vbButton3
            // 
            this.vbButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.vbButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.vbButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton3.BorderRadius = 15;
            this.vbButton3.BorderSize = 0;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.Location = new System.Drawing.Point(35, 55);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(150, 40);
            this.vbButton3.TabIndex = 2;
            this.vbButton3.Text = "Xóa";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
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
            // vbButton1
            // 
            this.vbButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.vbButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 15;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(35, 5);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(150, 40);
            this.vbButton1.TabIndex = 0;
            this.vbButton1.Text = "Thêm";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvAnhPT);
            this.panel2.Location = new System.Drawing.Point(461, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 395);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "II. Danh sách ảnh phương tiện";
            // 
            // anh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "anh";
            this.Text = "anh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnhPT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAnhPT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private PresentationLayer.Custom.VBButton btnChonAnh;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.TextBox tbAnh;
        private System.Windows.Forms.Label lbAnh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PresentationLayer.Custom.VBButton vbButton4;
        private PresentationLayer.Custom.VBButton vbButton3;
        private PresentationLayer.Custom.VBButton vbButton2;
        private PresentationLayer.Custom.VBButton vbButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAnh;
        private System.Windows.Forms.DataGridViewImageColumn sUrl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}