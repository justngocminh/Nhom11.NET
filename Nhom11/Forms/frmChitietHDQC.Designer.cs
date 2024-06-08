namespace Nhom11.Forms
{
    partial class frmChitietHDQC
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
            this.lblMaHD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaQC = new System.Windows.Forms.ComboBox();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtTenQC = new System.Windows.Forms.TextBox();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblBangso = new System.Windows.Forms.Label();
            this.lblBangchu = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.Blue;
            this.lblMaHD.Location = new System.Drawing.Point(121, 9);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(696, 46);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "CHI TIẾT HỢP ĐỒNG QUẢNG CÁO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaQC);
            this.groupBox1.Controls.Add(this.txtThanhtien);
            this.groupBox1.Controls.Add(this.txtDongia);
            this.groupBox1.Controls.Add(this.txtTenQC);
            this.groupBox1.Controls.Add(this.txtMaCTHD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin CTHD: ";
            // 
            // cboMaQC
            // 
            this.cboMaQC.FormattingEnabled = true;
            this.cboMaQC.Location = new System.Drawing.Point(151, 42);
            this.cboMaQC.Name = "cboMaQC";
            this.cboMaQC.Size = new System.Drawing.Size(142, 28);
            this.cboMaQC.TabIndex = 18;
            this.cboMaQC.SelectedIndexChanged += new System.EventHandler(this.cboMaQC_SelectedIndexChanged);
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(472, 102);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(140, 26);
            this.txtThanhtien.TabIndex = 14;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(151, 102);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(142, 26);
            this.txtDongia.TabIndex = 13;
            // 
            // txtTenQC
            // 
            this.txtTenQC.Location = new System.Drawing.Point(470, 44);
            this.txtTenQC.Name = "txtTenQC";
            this.txtTenQC.Size = new System.Drawing.Size(142, 26);
            this.txtTenQC.TabIndex = 12;
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaCTHD.Location = new System.Drawing.Point(140, 0);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(203, 19);
            this.txtMaCTHD.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thành tiền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên quảng cáo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã quảng cáo:";
            // 
            // DataGridViewCTHD
            // 
            this.DataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCTHD.Location = new System.Drawing.Point(32, 261);
            this.DataGridViewCTHD.Name = "DataGridViewCTHD";
            this.DataGridViewCTHD.RowHeadersWidth = 62;
            this.DataGridViewCTHD.RowTemplate.Height = 28;
            this.DataGridViewCTHD.Size = new System.Drawing.Size(839, 172);
            this.DataGridViewCTHD.TabIndex = 2;
            this.DataGridViewCTHD.Click += new System.EventHandler(this.DataGridViewCTHD_Click);
            this.DataGridViewCTHD.DoubleClick += new System.EventHandler(this.DataGridViewCTHD_DoubleClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(283, 534);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(515, 534);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 32);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(618, 534);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 32);
            this.btnBoqua.TabIndex = 5;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(723, 534);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 32);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblBangso
            // 
            this.lblBangso.AutoSize = true;
            this.lblBangso.Location = new System.Drawing.Point(28, 465);
            this.lblBangso.Name = "lblBangso";
            this.lblBangso.Size = new System.Drawing.Size(140, 20);
            this.lblBangso.TabIndex = 10;
            this.lblBangso.Text = "Tổng tiền bằng số:";
            // 
            // lblBangchu
            // 
            this.lblBangchu.AutoSize = true;
            this.lblBangchu.Location = new System.Drawing.Point(28, 502);
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.Size = new System.Drawing.Size(149, 20);
            this.lblBangchu.TabIndex = 19;
            this.lblBangchu.Text = "Tổng tiền bằng chữ:";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(391, 534);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(94, 32);
            this.btnCapnhat.TabIndex = 20;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // frmChitietHDQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 591);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.lblBangchu);
            this.Controls.Add(this.lblBangso);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataGridViewCTHD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMaHD);
            this.Name = "frmChitietHDQC";
            this.Text = "ChitietHDQC";
            this.Load += new System.EventHandler(this.frmChitietHDQC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridViewCTHD;
        private System.Windows.Forms.ComboBox cboMaQC;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTenQC;
        private System.Windows.Forms.TextBox txtMaCTHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblBangso;
        private System.Windows.Forms.Label lblBangchu;
        private System.Windows.Forms.Button btnCapnhat;
    }
}