namespace Nhom11.Forms
{
    partial class frmBaocaodoanhthu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMahopdong = new System.Windows.Forms.TextBox();
            this.txtDenngay = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoTheongay = new System.Windows.Forms.RadioButton();
            this.rdoTrongkhoang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTheongay = new System.Windows.Forms.MaskedTextBox();
            this.txtTungay = new System.Windows.Forms.MaskedTextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTracuu = new System.Windows.Forms.Button();
            this.lbTongdoanhthuso = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTongdoanhthuchu = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 37);
            this.label4.TabIndex = 99;
            this.label4.Text = "Báo cáo doanh thu";
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Location = new System.Drawing.Point(107, 49);
            this.txtTenkhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(159, 20);
            this.txtTenkhachhang.TabIndex = 1;
            this.txtTenkhachhang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenkhachhang_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMahopdong);
            this.groupBox1.Controls.Add(this.txtDenngay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenkhachhang);
            this.groupBox1.Controls.Add(this.rdoTheongay);
            this.groupBox1.Controls.Add(this.rdoTrongkhoang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTheongay);
            this.groupBox1.Controls.Add(this.txtTungay);
            this.groupBox1.Location = new System.Drawing.Point(28, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(726, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu thông tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Đến ngày";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(107, 74);
            this.txtTennhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(159, 20);
            this.txtTennhanvien.TabIndex = 2;
            this.txtTennhanvien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTennhanvien_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mã hợp đồng";
            // 
            // txtMahopdong
            // 
            this.txtMahopdong.Location = new System.Drawing.Point(107, 23);
            this.txtMahopdong.Margin = new System.Windows.Forms.Padding(2);
            this.txtMahopdong.Name = "txtMahopdong";
            this.txtMahopdong.Size = new System.Drawing.Size(159, 20);
            this.txtMahopdong.TabIndex = 0;
            this.txtMahopdong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMahopdong_KeyDown);
            // 
            // txtDenngay
            // 
            this.txtDenngay.Location = new System.Drawing.Point(616, 72);
            this.txtDenngay.Margin = new System.Windows.Forms.Padding(1);
            this.txtDenngay.Mask = "00/00/0000";
            this.txtDenngay.Name = "txtDenngay";
            this.txtDenngay.Size = new System.Drawing.Size(79, 20);
            this.txtDenngay.TabIndex = 5;
            this.txtDenngay.ValidatingType = typeof(System.DateTime);
            this.txtDenngay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDenngay_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Tên nhân viên";
            // 
            // rdoTheongay
            // 
            this.rdoTheongay.AutoSize = true;
            this.rdoTheongay.Location = new System.Drawing.Point(317, 27);
            this.rdoTheongay.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTheongay.Name = "rdoTheongay";
            this.rdoTheongay.Size = new System.Drawing.Size(76, 17);
            this.rdoTheongay.TabIndex = 4;
            this.rdoTheongay.TabStop = true;
            this.rdoTheongay.Text = "Theo ngày";
            this.rdoTheongay.UseVisualStyleBackColor = true;
            this.rdoTheongay.CheckedChanged += new System.EventHandler(this.rdoTheongay_CheckedChanged);
            // 
            // rdoTrongkhoang
            // 
            this.rdoTrongkhoang.AutoSize = true;
            this.rdoTrongkhoang.Location = new System.Drawing.Point(317, 73);
            this.rdoTrongkhoang.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTrongkhoang.Name = "rdoTrongkhoang";
            this.rdoTrongkhoang.Size = new System.Drawing.Size(92, 17);
            this.rdoTrongkhoang.TabIndex = 6;
            this.rdoTrongkhoang.TabStop = true;
            this.rdoTrongkhoang.Text = "Trong khoảng";
            this.rdoTrongkhoang.UseVisualStyleBackColor = true;
            this.rdoTrongkhoang.CheckedChanged += new System.EventHandler(this.rdoTrongkhoang_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Từ ngày";
            // 
            // txtTheongay
            // 
            this.txtTheongay.Location = new System.Drawing.Point(417, 26);
            this.txtTheongay.Margin = new System.Windows.Forms.Padding(1);
            this.txtTheongay.Mask = "00/00/0000";
            this.txtTheongay.Name = "txtTheongay";
            this.txtTheongay.Size = new System.Drawing.Size(73, 20);
            this.txtTheongay.TabIndex = 3;
            this.txtTheongay.ValidatingType = typeof(System.DateTime);
            this.txtTheongay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTheongay_KeyDown);
            // 
            // txtTungay
            // 
            this.txtTungay.Location = new System.Drawing.Point(464, 72);
            this.txtTungay.Margin = new System.Windows.Forms.Padding(1);
            this.txtTungay.Mask = "00/00/0000";
            this.txtTungay.Name = "txtTungay";
            this.txtTungay.Size = new System.Drawing.Size(79, 20);
            this.txtTungay.TabIndex = 4;
            this.txtTungay.ValidatingType = typeof(System.DateTime);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(496, 194);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 24);
            this.btnHuy.TabIndex = 49;
            this.btnHuy.Text = "Hủy tra cứu";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTracuu
            // 
            this.btnTracuu.Location = new System.Drawing.Point(612, 194);
            this.btnTracuu.Margin = new System.Windows.Forms.Padding(1);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Size = new System.Drawing.Size(102, 24);
            this.btnTracuu.TabIndex = 9;
            this.btnTracuu.Text = "Tra cứu";
            this.btnTracuu.UseVisualStyleBackColor = true;
            this.btnTracuu.Click += new System.EventHandler(this.btnTracuu_Click);
            // 
            // lbTongdoanhthuso
            // 
            this.lbTongdoanhthuso.AutoSize = true;
            this.lbTongdoanhthuso.Location = new System.Drawing.Point(29, 21);
            this.lbTongdoanhthuso.Name = "lbTongdoanhthuso";
            this.lbTongdoanhthuso.Size = new System.Drawing.Size(127, 13);
            this.lbTongdoanhthuso.TabIndex = 49;
            this.lbTongdoanhthuso.Text = "Tổng doanh thu bằng số:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXuat);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(15, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(714, 192);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin báo cáo";
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(475, 157);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(1);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(102, 24);
            this.btnXuat.TabIndex = 49;
            this.btnXuat.Text = "Xuất báo cáo";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(597, 157);
            this.btnDong.Margin = new System.Windows.Forms.Padding(1);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(96, 24);
            this.btnDong.TabIndex = 55;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(684, 124);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTongdoanhthuchu);
            this.groupBox3.Controls.Add(this.lbTongdoanhthuso);
            this.groupBox3.Location = new System.Drawing.Point(15, 437);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(714, 72);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin báo cáo";
            // 
            // lbTongdoanhthuchu
            // 
            this.lbTongdoanhthuchu.AutoSize = true;
            this.lbTongdoanhthuchu.Location = new System.Drawing.Point(29, 47);
            this.lbTongdoanhthuchu.Name = "lbTongdoanhthuchu";
            this.lbTongdoanhthuchu.Size = new System.Drawing.Size(134, 13);
            this.lbTongdoanhthuchu.TabIndex = 50;
            this.lbTongdoanhthuchu.Text = "Tổng doanh thu bằng chữ:";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(748, 279);
            this.chart1.Margin = new System.Windows.Forms.Padding(1);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(358, 232);
            this.chart1.TabIndex = 51;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(883, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Biểu đồ doanh thu";
            // 
            // frmBaocaodoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnTracuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBaocaodoanhthu";
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.frmBaocaodoanhthu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenkhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTheongay;
        private System.Windows.Forms.RadioButton rdoTrongkhoang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTungay;
        private System.Windows.Forms.MaskedTextBox txtTheongay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDenngay;
        private System.Windows.Forms.Label lbTongdoanhthuso;
        private System.Windows.Forms.Button btnTracuu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTongdoanhthuchu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMahopdong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDong;
    }
}