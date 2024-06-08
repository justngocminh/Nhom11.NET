using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace Nhom11.Forms
{
    public partial class frmBaocaoloinhuan : Form
    {
        DataTable table;

        // Thiết lập kích thước form 
        public frmBaocaoloinhuan()
        {
            InitializeComponent();
            Size = new Size(1164, 605);
            MinimumSize = new Size(1164, 605);
        }

        // Tải datagridview
        private void Load_DataGridView(string sql)
        {
            table = Classes.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = table;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            dataGridView1.Columns[0].HeaderText = "Mã hợp đồng";
            dataGridView1.Columns[1].HeaderText = "Ngày ký kết";
            dataGridView1.Columns[2].HeaderText = "Doanh thu";
            dataGridView1.Columns[3].HeaderText = "Chi phí";
            dataGridView1.Columns[4].HeaderText = "Lợi nhuận";

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lbTongloinhuanso.Text = "Tổng lợi nhuận bằng số: " + ColumnTotal(dataGridView1, 4) + " đồng";
            lbTongloinhuanchu.Text = "Tổng lợi nhuận bằng chữ: " + Classes.Functions.ConvertNumberToWords((long)ColumnTotal(dataGridView1, 4)) + " đồng";
        }

        // Tải biểu đồ
        private void SetupStackedColumnChart(DataGridView dataGridView, Chart chart)
        {
            chart.Series.Clear();

            Series costSeries = new Series("Chi phí");
            Series profitSeries = new Series("Lợi nhuận");

            costSeries.ChartType = SeriesChartType.StackedColumn;
            profitSeries.ChartType = SeriesChartType.StackedColumn;

            chart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string xValue = row.Cells[0].Value.ToString();
                    double cost = Convert.ToDouble(row.Cells[3].Value);
                    double profit = Convert.ToDouble(row.Cells[4].Value);

                    costSeries.Points.AddXY(xValue, cost);
                    profitSeries.Points.AddXY(xValue, profit);
                }
            }

            chart.Series.Add(costSeries);
            chart.Series.Add(profitSeries);

            chart.DataBind();
        }

        // Tải form
        private void frmBaocaoloinhuan_Load(object sender, EventArgs e)
        {
            string sql = "select * from Baocaoloinhuan";
            txtMahopdong.Focus();
            txtTheongay.Enabled = false;
            txtTungay.Enabled = false;
            txtDenngay.Enabled = false;
            Load_DataGridView(sql);
            SetupStackedColumnChart(dataGridView1, chart1);

        }

        // Không cho điền chữ cái vào các ô tiền
        private void txtDoanhthu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDoanhthu2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNhuanbut1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNhuanbut2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLoinhuan1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLoinhuan2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Chuyển đổi qua lại radio button
        private void rdoTheongay_CheckedChanged(object sender, EventArgs e)
        {
            txtTheongay.Enabled = true;
            txtTungay.Enabled = false;
            txtDenngay.Enabled = false;
        }

        private void rdoTrongkhoang_CheckedChanged(object sender, EventArgs e)
        {
            txtDenngay.Enabled = true;
            txtTungay.Enabled = true;
            txtTheongay.Enabled = false;
        }

        // Nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            string sql = "select * from Baocaoloinhuan";
            txtMahopdong.Text = "";
            rdoTheongay.Checked = false;
            rdoTrongkhoang.Checked = false;
            txtDoanhthu1.Text = "";
            txtDoanhthu2.Text = "";
            txtNhuanbut1.Text = "";
            txtNhuanbut2.Text = "";
            txtLoinhuan1.Text = "";
            txtLoinhuan2.Text = "";
            txtTheongay.Text = "";
            txtTheongay.Enabled = false;
            txtTungay.Text = "";
            txtTungay.Enabled = false;
            txtDenngay.Text = "";
            txtDenngay.Enabled = false;
            txtMahopdong.Focus();
            Load_DataGridView(sql);
            SetupStackedColumnChart(dataGridView1, chart1);
        }

        // Nút tra cứu
        private void btnTracuu_Click(object sender, EventArgs e)
        {
            string sql = "select * from Baocaoloinhuan where 1 = 1";
            if (txtMahopdong.Text.Trim() == "" && txtDoanhthu1.Text.Trim() == "" && txtDoanhthu2.Text.Trim() == "" && txtNhuanbut1.Text.Trim() == "" && txtNhuanbut2.Text.Trim() == "" && txtLoinhuan1.Text.Trim() == "" && txtLoinhuan2.Text.Trim() == "" && rdoTheongay.Checked == false && rdoTrongkhoang.Checked == false)
            {
                MessageBox.Show("Hãy nhập ít nhất một thông tin để tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra cọc cạch
            if ((txtDoanhthu1.Text.Trim() != "" && txtDoanhthu2.Text.Trim() == "") || (txtDoanhthu1.Text.Trim() == "" && txtDoanhthu2.Text.Trim() != ""))
            {
                MessageBox.Show("Khoảng doanh thu không hợp lệ. Vui lòng nhập đầy đủ doanh thu tối thiểu và tối đa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((txtNhuanbut1.Text.Trim() != "" && txtNhuanbut2.Text.Trim() == "") || (txtNhuanbut1.Text.Trim() == "" && txtNhuanbut2.Text.Trim() != ""))
            {
                MessageBox.Show("Khoảng chi phí không hợp lệ. Vui lòng nhập đầy đủ chi phí tối thiểu và tối đa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((txtLoinhuan1.Text.Trim() != "" && txtLoinhuan2.Text.Trim() == "") || (txtLoinhuan1.Text.Trim() == "" && txtLoinhuan2.Text.Trim() != ""))
            {
                MessageBox.Show("Khoảng lợi nhuận không hợp lệ. Vui lòng nhập đầy đủ lợi nhuận tối thiểu và tối đa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra giá trị textbox hợp lệ
            if (txtDoanhthu1.Text.Trim() != "" && txtDoanhthu2.Text.Trim() != "")
            {
                int truoc = Convert.ToInt32(txtDoanhthu1.Text.Trim());
                int sau = Convert.ToInt32(txtDoanhthu2.Text.Trim());
                if (truoc > sau)
                {
                    MessageBox.Show("Khoảng doanh thu không hợp lệ. Doanh thu tối đa phải lớn hơn doanh thu tối thiểu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtNhuanbut1.Text.Trim() != "" && txtNhuanbut2.Text.Trim() != "")
            {
                int truoc = Convert.ToInt32(txtNhuanbut1.Text.Trim());
                int sau = Convert.ToInt32(txtNhuanbut2.Text.Trim());
                if (truoc > sau)
                {
                    MessageBox.Show("Khoảng chi phí không hợp lệ. Chi phí tối đa phải lớn hơn chi phí tối thiểu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtLoinhuan1.Text.Trim() != "" && txtLoinhuan2.Text.Trim() != "")
            {
                int truoc = Convert.ToInt32(txtLoinhuan1.Text.Trim());
                int sau = Convert.ToInt32(txtLoinhuan2.Text.Trim());
                if (truoc > sau)
                {
                    MessageBox.Show("Khoảng lợi nhuận không hợp lệ. Lợi nhuận tối đa phải lớn hơn lợi nhuận tối thiểu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Kiểm tra ngày tháng được điền đầy đủ
            if (!txtTheongay.MaskCompleted && rdoTheongay.Checked)
            {
                MessageBox.Show("Ngày tra cứu không hợp lệ. Vui lòng nhập đầy đủ ngày tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtTungay.MaskCompleted && rdoTrongkhoang.Checked)
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng nhập đầy đủ ngày tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtDenngay.MaskCompleted && rdoTrongkhoang.Checked)
            {
                MessageBox.Show("Ngày kết thúc không hợp lệ. Vui lòng nhập đầy đủ ngày tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra định dạng ngày tháng
            if (rdoTheongay.Checked)
            {
                if (!Classes.Functions.IsValidDate(txtTheongay.Text.Trim()))
                {
                    MessageBox.Show("Ngày tra cứu không hợp lệ. Vui lòng nhập đúng định dạng ngày tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (rdoTrongkhoang.Checked)
            {
                // Kiểm tra đến ngày phải lớn hơn từ ngày
                int compare = DateTime.Compare(DateTime.Parse(txtDenngay.Text), DateTime.Parse(txtTungay.Text));

                if (!Classes.Functions.IsValidDate(txtTungay.Text.Trim()))
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng nhập đúng định dạng ngày tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Classes.Functions.IsValidDate(txtDenngay.Text.Trim()))
                {
                    MessageBox.Show("Ngày kết thúc không hợp lệ. Vui lòng nhập đúng định dạng ngày tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (compare < 0)
                {
                    MessageBox.Show("Ngày trong ô 'Đến ngày' phải lớn hơn ngày trong ô 'Từ ngày'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtMahopdong.Text.Trim() != "")
            {
                sql = sql + "and Mahopdong = N'" + txtMahopdong.Text.Trim() + "'";
            }
            if (txtDoanhthu1.Text.Trim() != "" && txtDoanhthu2.Text.Trim() != "")
            {
                sql += "and (Doanhthu between N'" + txtDoanhthu1.Text.Trim() + "' and N'" + txtDoanhthu2.Text.Trim() + "')";
            }
            if (txtNhuanbut1.Text.Trim() != "" && txtNhuanbut2.Text.Trim() != "")
            {
                sql += "and (Nhuanbut between N'" + txtNhuanbut1.Text.Trim() + "' and N'" + txtNhuanbut2.Text.Trim() + "')";
            }
            if (txtLoinhuan1.Text.Trim() != "" && txtLoinhuan2.Text.Trim() != "")
            {
                sql += "and (Loinhuan between N'" + txtLoinhuan1.Text.Trim() + "' and N'" + txtLoinhuan2.Text.Trim() + "')";
            }
            if (txtTheongay.Text.Trim() != "  /  /" && rdoTheongay.Checked)
            {
                sql += "and Ngaykyket = N'" + Classes.Functions.ConvertDateTime(txtTheongay.Text.Trim()) + "'";
            }
            if (txtTungay.Text.Trim() != "  /  /" && txtDenngay.Text.Trim() != "  /  /" && rdoTrongkhoang.Checked)
            {
                sql += "and (Ngaykyket between N'" + Classes.Functions.ConvertDateTime(txtTungay.Text.Trim()) + "' and N'" + Classes.Functions.ConvertDateTime(txtDenngay.Text.Trim()) + "')";
            }
            Load_DataGridView(sql);
            SetupStackedColumnChart(dataGridView1, chart1);
        }
        // Bấm nút tra cứu bằng phím enter
        private void txtMahopdong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTracuu.PerformClick();
            }
        }

        private void txtDoanhthu2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTracuu.PerformClick();
            }
        }

        private void txtNhuanbut2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTracuu.PerformClick();
            }
        }

        private void txtLoinhuan2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTracuu.PerformClick();
            }
        }

        private void txtTheongay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTracuu.PerformClick();
            }
        }

        private void txtDenngay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTracuu.PerformClick();
            }
        }

        // Tính tổng lợi nhuận
        private decimal ColumnTotal(DataGridView dataGridView, int columnIndex)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[columnIndex].Value);
                }
            }

            return total;
        }

        // Nút đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Chuyển kiểu cột khi thay đổi kích cỡ form
        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            Classes.Functions.ChangeColumnsSize(dataGridView1);
        }

        // Xuất báo cáo
        private void ExportToExcel(DataGridView datagridview, string filepath)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add(System.Reflection.Missing.Value);

                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                worksheet.Cells[1, 1] = "Báo Cáo Lợi Nhuận";
                Excel.Range titleRange = worksheet.Range["A1", "E1"];
                titleRange.Merge();
                titleRange.Font.Size = 16;
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                for (int i = 0; i < datagridview.Columns.Count; i++)
                {
                    worksheet.Cells[2, i + 1] = datagridview.Columns[i].HeaderText;
                    worksheet.Cells[2, i + 1].Font.Bold = true;
                    worksheet.Cells[2, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }

                for (int i = 0; i < datagridview.Rows.Count; i++)
                {
                    for (int j = 0; j < datagridview.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 3, j + 1].Value = datagridview.Rows[i].Cells[j].Value;
                    }
                }

                int totalRow = datagridview.Rows.Count + 3;
                worksheet.Cells[totalRow, 4] = "Tổng  lợi nhuận: ";
                worksheet.Cells[totalRow, 4].Font.Bold = true;
                worksheet.Cells[totalRow, 4].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightYellow);
                worksheet.Cells[totalRow, 5].Formula = $"=SUM(E3:E{totalRow - 1})";
                worksheet.Cells[totalRow, 5].Font.Bold = true;
                worksheet.Cells[totalRow, 5].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightYellow);

                worksheet.Columns.AutoFit();

                workbook.SaveAs("" + filepath);

                //workbook.Close();
                //excelApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                MessageBox.Show("Dữ liệu đã được xuất thành công sang Excel.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        // Nút xuất báo cáo
        private void btnXuat_Click(object sender, EventArgs e)
        {
            string filepath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                filepath = saveFileDialog.FileName;
            }
            ExportToExcel(dataGridView1, filepath);
        }
    }
}
