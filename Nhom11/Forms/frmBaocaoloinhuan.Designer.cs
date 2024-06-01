namespace Nhom11.Forms
{
    partial class frmBaocaoloinhuan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnXuat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTongloinhuanso = new System.Windows.Forms.Label();
            this.lbTongloinhuanso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMahopdong = new System.Windows.Forms.TextBox();
            this.txtDenngay = new System.Windows.Forms.MaskedTextBox();
            this.rdoTheongay = new System.Windows.Forms.RadioButton();
            this.rdoTrongkhoang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDong = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtTheongay = new System.Windows.Forms.MaskedTextBox();
            this.btnTracuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTungay = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLoinhuan2 = new System.Windows.Forms.TextBox();
            this.txtLoinhuan1 = new System.Windows.Forms.TextBox();
            this.txtNhuanbut2 = new System.Windows.Forms.TextBox();
            this.txtNhuanbut1 = new System.Windows.Forms.TextBox();
            this.txtDoanhthu2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoanhthu1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox3.Controls.Add(this.txtTongloinhuanso);
            this.groupBox3.Controls.Add(this.lbTongloinhuanso);
            this.groupBox3.Location = new System.Drawing.Point(28, 468);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(714, 72);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin báo cáo";
            // 
            // txtTongloinhuanso
            // 
            this.txtTongloinhuanso.AutoSize = true;
            this.txtTongloinhuanso.Location = new System.Drawing.Point(29, 47);
            this.txtTongloinhuanso.Name = "txtTongloinhuanso";
            this.txtTongloinhuanso.Size = new System.Drawing.Size(129, 13);
            this.txtTongloinhuanso.TabIndex = 50;
            this.txtTongloinhuanso.Text = "Tổng lợi nhuận bằng chữ:";
            // 
            // lbTongloinhuanso
            // 
            this.lbTongloinhuanso.AutoSize = true;
            this.lbTongloinhuanso.Location = new System.Drawing.Point(29, 21);
            this.lbTongloinhuanso.Name = "lbTongloinhuanso";
            this.lbTongloinhuanso.Size = new System.Drawing.Size(122, 13);
            this.lbTongloinhuanso.TabIndex = 49;
            this.lbTongloinhuanso.Text = "Tổng lợi nhuận bằng số:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Đến ngày";
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
            this.txtMahopdong.Size = new System.Drawing.Size(214, 20);
            this.txtMahopdong.TabIndex = 0;
            this.txtMahopdong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMahopdong_KeyDown);
            // 
            // txtDenngay
            // 
            this.txtDenngay.Location = new System.Drawing.Point(650, 66);
            this.txtDenngay.Margin = new System.Windows.Forms.Padding(1);
            this.txtDenngay.Mask = "00/00/0000";
            this.txtDenngay.Name = "txtDenngay";
            this.txtDenngay.Size = new System.Drawing.Size(79, 20);
            this.txtDenngay.TabIndex = 5;
            this.txtDenngay.ValidatingType = typeof(System.DateTime);
            this.txtDenngay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDenngay_KeyDown);
            // 
            // rdoTheongay
            // 
            this.rdoTheongay.AutoSize = true;
            this.rdoTheongay.Location = new System.Drawing.Point(359, 26);
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
            this.rdoTrongkhoang.Location = new System.Drawing.Point(359, 69);
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
            this.label1.Location = new System.Drawing.Point(456, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Từ ngày";
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(761, 310);
            this.chart1.Margin = new System.Windows.Forms.Padding(1);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(358, 232);
            this.chart1.TabIndex = 105;
            this.chart1.Text = "chart1";
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
            // txtTheongay
            // 
            this.txtTheongay.Location = new System.Drawing.Point(444, 23);
            this.txtTheongay.Margin = new System.Windows.Forms.Padding(1);
            this.txtTheongay.Mask = "00/00/0000";
            this.txtTheongay.Name = "txtTheongay";
            this.txtTheongay.Size = new System.Drawing.Size(77, 20);
            this.txtTheongay.TabIndex = 3;
            this.txtTheongay.ValidatingType = typeof(System.DateTime);
            this.txtTheongay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTheongay_KeyDown);
            // 
            // btnTracuu
            // 
            this.btnTracuu.Location = new System.Drawing.Point(625, 225);
            this.btnTracuu.Margin = new System.Windows.Forms.Padding(1);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Size = new System.Drawing.Size(102, 24);
            this.btnTracuu.TabIndex = 101;
            this.btnTracuu.Text = "Tra cứu";
            this.btnTracuu.UseVisualStyleBackColor = true;
            this.btnTracuu.Click += new System.EventHandler(this.btnTracuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(509, 225);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 24);
            this.btnHuy.TabIndex = 103;
            this.btnHuy.Text = "Hủy tra cứu";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTungay
            // 
            this.txtTungay.Location = new System.Drawing.Point(506, 66);
            this.txtTungay.Margin = new System.Windows.Forms.Padding(1);
            this.txtTungay.Mask = "00/00/0000";
            this.txtTungay.Name = "txtTungay";
            this.txtTungay.Size = new System.Drawing.Size(76, 20);
            this.txtTungay.TabIndex = 4;
            this.txtTungay.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(872, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "Biểu đồ thống kê lợi nhuận";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXuat);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(28, 263);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(714, 192);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin báo cáo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 37);
            this.label4.TabIndex = 107;
            this.label4.Text = "Báo cáo lợi nhuận";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtLoinhuan2);
            this.groupBox1.Controls.Add(this.txtLoinhuan1);
            this.groupBox1.Controls.Add(this.txtNhuanbut2);
            this.groupBox1.Controls.Add(this.txtNhuanbut1);
            this.groupBox1.Controls.Add(this.txtDoanhthu2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMahopdong);
            this.groupBox1.Controls.Add(this.txtDenngay);
            this.groupBox1.Controls.Add(this.txtDoanhthu1);
            this.groupBox1.Controls.Add(this.rdoTheongay);
            this.groupBox1.Controls.Add(this.rdoTrongkhoang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTheongay);
            this.groupBox1.Controls.Add(this.txtTungay);
            this.groupBox1.Location = new System.Drawing.Point(29, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(746, 142);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu thông tin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(213, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 113;
            this.label14.Text = "Đến";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(213, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 112;
            this.label13.Text = "Đến";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 111;
            this.label12.Text = "Đến";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 110;
            this.label11.Text = "Từ ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 109;
            this.label10.Text = "Từ ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 108;
            this.label9.Text = "Từ ";
            // 
            // txtLoinhuan2
            // 
            this.txtLoinhuan2.Location = new System.Drawing.Point(245, 98);
            this.txtLoinhuan2.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoinhuan2.Name = "txtLoinhuan2";
            this.txtLoinhuan2.Size = new System.Drawing.Size(76, 20);
            this.txtLoinhuan2.TabIndex = 59;
            this.txtLoinhuan2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoinhuan2_KeyDown);
            this.txtLoinhuan2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoinhuan2_KeyPress);
            // 
            // txtLoinhuan1
            // 
            this.txtLoinhuan1.Location = new System.Drawing.Point(132, 98);
            this.txtLoinhuan1.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoinhuan1.Name = "txtLoinhuan1";
            this.txtLoinhuan1.Size = new System.Drawing.Size(76, 20);
            this.txtLoinhuan1.TabIndex = 58;
            this.txtLoinhuan1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoinhuan1_KeyPress);
            // 
            // txtNhuanbut2
            // 
            this.txtNhuanbut2.Location = new System.Drawing.Point(245, 73);
            this.txtNhuanbut2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhuanbut2.Name = "txtNhuanbut2";
            this.txtNhuanbut2.Size = new System.Drawing.Size(76, 20);
            this.txtNhuanbut2.TabIndex = 57;
            this.txtNhuanbut2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhuanbut2_KeyDown);
            this.txtNhuanbut2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhuanbut2_KeyPress);
            // 
            // txtNhuanbut1
            // 
            this.txtNhuanbut1.Location = new System.Drawing.Point(132, 73);
            this.txtNhuanbut1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhuanbut1.Name = "txtNhuanbut1";
            this.txtNhuanbut1.Size = new System.Drawing.Size(76, 20);
            this.txtNhuanbut1.TabIndex = 56;
            this.txtNhuanbut1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhuanbut1_KeyPress);
            // 
            // txtDoanhthu2
            // 
            this.txtDoanhthu2.Location = new System.Drawing.Point(245, 49);
            this.txtDoanhthu2.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoanhthu2.Name = "txtDoanhthu2";
            this.txtDoanhthu2.Size = new System.Drawing.Size(76, 20);
            this.txtDoanhthu2.TabIndex = 55;
            this.txtDoanhthu2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDoanhthu2_KeyDown);
            this.txtDoanhthu2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoanhthu2_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Lợi nhuận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Nhuận bút";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Doanh thu";
            // 
            // txtDoanhthu1
            // 
            this.txtDoanhthu1.Location = new System.Drawing.Point(132, 49);
            this.txtDoanhthu1.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoanhthu1.Name = "txtDoanhthu1";
            this.txtDoanhthu1.Size = new System.Drawing.Size(76, 20);
            this.txtDoanhthu1.TabIndex = 1;
            this.txtDoanhthu1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoanhthu1_KeyPress);
            // 
            // frmBaocaoloinhuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnTracuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBaocaoloinhuan";
            this.Text = "Báo cáo lợi nhuận";
            this.Load += new System.EventHandler(this.frmBaocaoloinhuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtTongloinhuanso;
        private System.Windows.Forms.Label lbTongloinhuanso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMahopdong;
        private System.Windows.Forms.MaskedTextBox txtDenngay;
        private System.Windows.Forms.RadioButton rdoTheongay;
        private System.Windows.Forms.RadioButton rdoTrongkhoang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MaskedTextBox txtTheongay;
        private System.Windows.Forms.Button btnTracuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.MaskedTextBox txtTungay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoanhthu1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoinhuan2;
        private System.Windows.Forms.TextBox txtLoinhuan1;
        private System.Windows.Forms.TextBox txtNhuanbut2;
        private System.Windows.Forms.TextBox txtNhuanbut1;
        private System.Windows.Forms.TextBox txtDoanhthu2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}