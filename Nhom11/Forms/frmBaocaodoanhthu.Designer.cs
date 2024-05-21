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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMahopdong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTracuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDenngay = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTungay = new System.Windows.Forms.MaskedTextBox();
            this.txtTheongay = new System.Windows.Forms.MaskedTextBox();
            this.rdoTrongkhoang = new System.Windows.Forms.RadioButton();
            this.rdoTheongay = new System.Windows.Forms.RadioButton();
            this.lbTongdoanhthuso = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXuat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTongdoanhthuchu = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 55);
            this.label4.TabIndex = 99;
            this.label4.Text = "Báo cáo doanh thu";
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Location = new System.Drawing.Point(195, 85);
            this.txtTenkhachhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(148, 26);
            this.txtTenkhachhang.TabIndex = 1;
            this.txtTenkhachhang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenkhachhang_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMahopdong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnTracuu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDenngay);
            this.groupBox1.Controls.Add(this.txtTenkhachhang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTungay);
            this.groupBox1.Controls.Add(this.txtTheongay);
            this.groupBox1.Controls.Add(this.rdoTrongkhoang);
            this.groupBox1.Controls.Add(this.rdoTheongay);
            this.groupBox1.Location = new System.Drawing.Point(22, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 188);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu thông tin";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(195, 128);
            this.txtTennhanvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(148, 26);
            this.txtTennhanvien.TabIndex = 2;
            this.txtTennhanvien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTennhanvien_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Tên nhân viên";
            // 
            // txtMahopdong
            // 
            this.txtMahopdong.Location = new System.Drawing.Point(195, 42);
            this.txtMahopdong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMahopdong.Name = "txtMahopdong";
            this.txtMahopdong.Size = new System.Drawing.Size(148, 26);
            this.txtMahopdong.TabIndex = 0;
            this.txtMahopdong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMahopdong_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mã hợp đồng";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(790, 138);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(153, 37);
            this.btnHuy.TabIndex = 49;
            this.btnHuy.Text = "Hủy tra cứu";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTracuu
            // 
            this.btnTracuu.Location = new System.Drawing.Point(982, 138);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Size = new System.Drawing.Size(153, 37);
            this.btnTracuu.TabIndex = 9;
            this.btnTracuu.Text = "Tra cứu";
            this.btnTracuu.UseVisualStyleBackColor = true;
            this.btnTracuu.Click += new System.EventHandler(this.btnTracuu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(902, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Đến ngày";
            // 
            // txtDenngay
            // 
            this.txtDenngay.Location = new System.Drawing.Point(982, 86);
            this.txtDenngay.Mask = "00/00/0000";
            this.txtDenngay.Name = "txtDenngay";
            this.txtDenngay.Size = new System.Drawing.Size(152, 26);
            this.txtDenngay.TabIndex = 8;
            this.txtDenngay.ValidatingType = typeof(System.DateTime);
            this.txtDenngay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDenngay_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Từ ngày";
            // 
            // txtTungay
            // 
            this.txtTungay.Location = new System.Drawing.Point(729, 86);
            this.txtTungay.Mask = "00/00/0000";
            this.txtTungay.Name = "txtTungay";
            this.txtTungay.Size = new System.Drawing.Size(152, 26);
            this.txtTungay.TabIndex = 7;
            this.txtTungay.ValidatingType = typeof(System.DateTime);
            // 
            // txtTheongay
            // 
            this.txtTheongay.Location = new System.Drawing.Point(651, 35);
            this.txtTheongay.Mask = "00/00/0000";
            this.txtTheongay.Name = "txtTheongay";
            this.txtTheongay.Size = new System.Drawing.Size(152, 26);
            this.txtTheongay.TabIndex = 5;
            this.txtTheongay.ValidatingType = typeof(System.DateTime);
            this.txtTheongay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTheongay_KeyDown);
            // 
            // rdoTrongkhoang
            // 
            this.rdoTrongkhoang.AutoSize = true;
            this.rdoTrongkhoang.Location = new System.Drawing.Point(498, 88);
            this.rdoTrongkhoang.Name = "rdoTrongkhoang";
            this.rdoTrongkhoang.Size = new System.Drawing.Size(132, 24);
            this.rdoTrongkhoang.TabIndex = 6;
            this.rdoTrongkhoang.TabStop = true;
            this.rdoTrongkhoang.Text = "Trong khoảng";
            this.rdoTrongkhoang.UseVisualStyleBackColor = true;
            this.rdoTrongkhoang.CheckedChanged += new System.EventHandler(this.rdoTrongkhoang_CheckedChanged);
            // 
            // rdoTheongay
            // 
            this.rdoTheongay.AutoSize = true;
            this.rdoTheongay.Location = new System.Drawing.Point(498, 35);
            this.rdoTheongay.Name = "rdoTheongay";
            this.rdoTheongay.Size = new System.Drawing.Size(108, 24);
            this.rdoTheongay.TabIndex = 4;
            this.rdoTheongay.TabStop = true;
            this.rdoTheongay.Text = "Theo ngày";
            this.rdoTheongay.UseVisualStyleBackColor = true;
            this.rdoTheongay.CheckedChanged += new System.EventHandler(this.rdoTheongay_CheckedChanged);
            // 
            // lbTongdoanhthuso
            // 
            this.lbTongdoanhthuso.AutoSize = true;
            this.lbTongdoanhthuso.Location = new System.Drawing.Point(44, 32);
            this.lbTongdoanhthuso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongdoanhthuso.Name = "lbTongdoanhthuso";
            this.lbTongdoanhthuso.Size = new System.Drawing.Size(186, 20);
            this.lbTongdoanhthuso.TabIndex = 49;
            this.lbTongdoanhthuso.Text = "Tổng doanh thu bằng số:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(22, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1161, 249);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin báo cáo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 188);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(772, 623);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(153, 37);
            this.btnXuat.TabIndex = 49;
            this.btnXuat.Text = "Xuất báo cáo";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTongdoanhthuchu);
            this.groupBox3.Controls.Add(this.lbTongdoanhthuso);
            this.groupBox3.Location = new System.Drawing.Point(22, 612);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 111);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin báo cáo";
            // 
            // lbTongdoanhthuchu
            // 
            this.lbTongdoanhthuchu.AutoSize = true;
            this.lbTongdoanhthuchu.Location = new System.Drawing.Point(44, 72);
            this.lbTongdoanhthuchu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongdoanhthuchu.Name = "lbTongdoanhthuchu";
            this.lbTongdoanhthuchu.Size = new System.Drawing.Size(195, 20);
            this.lbTongdoanhthuchu.TabIndex = 50;
            this.lbTongdoanhthuchu.Text = "Tổng doanh thu bằng chữ:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1209, 348);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(537, 357);
            this.chart1.TabIndex = 51;
            this.chart1.Text = "chart1";
            // 
            // frmBaocaodoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 780);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "frmBaocaodoanhthu";
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.frmBaocaodoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
    }
}