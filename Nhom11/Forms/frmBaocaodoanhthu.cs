﻿using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace Nhom11.Forms
{
    public partial class frmBaocaodoanhthu : Form
    {
        DataTable table;
        public frmBaocaodoanhthu()
        {
            InitializeComponent();
            this.Size = new Size(1195, 546);
        }
        private void Load_DataGridView(string sql)
        {
            table = Classes.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = table;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns[0].HeaderText = "Mã hợp đồng";
            dataGridView1.Columns[1].HeaderText = "Tên khách hàng";
            dataGridView1.Columns[2].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[3].HeaderText = "Ngày ký kết";
            dataGridView1.Columns[4].HeaderText = "Ngày bắt đầu";
            dataGridView1.Columns[5].HeaderText = "Ngày kết thúc";
            dataGridView1.Columns[6].HeaderText = "Tổng tiền";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].Width = 120;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmBaocaodoanhthu_Load(object sender, EventArgs e)
        {
            string sql = "select * from Baocaodoanhthu";
            txtMahopdong.Focus();
            txtTheongay.Enabled = false;
            txtTungay.Enabled = false;
            txtDenngay.Enabled = false;
            Load_DataGridView(sql);
            SetupColumnChart();
            lbTongdoanhthuso.Text += " " + CalculateColumnTotal(dataGridView1, 6) + " nghìn đồng";
            lbTongdoanhthuchu.Text += " " + NumberConverter.NumberToWords((long)CalculateColumnTotal(dataGridView1, 6)) + " đồng";
        }
        private void SetupColumnChart()
        {
            // Xóa dữ liệu cũ trong biểu đồ (nếu có)
            chart1.Series.Clear();

            // Tạo một chuỗi dữ liệu mới cho biểu đồ
            var series = new Series("Tổng tiền", (int)SeriesChartType.Column);

            // Lặp qua các hàng trong DataGridView để thêm dữ liệu vào chuỗi dữ liệu của biểu đồ
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra xem dữ liệu trong cột "Tổng tiền" và "Ngày ký kết" có hợp lệ không
                if (row.Cells[6].Value != null && row.Cells[6].Value.ToString() != "" &&
                    row.Cells[3].Value != null && row.Cells[3].Value.ToString() != "")
                {
                    // Thêm điểm dữ liệu vào chuỗi dữ liệu của biểu đồ
                    series.Points.AddXY(DateTime.Parse(row.Cells[3].Value.ToString()), Convert.ToDouble(row.Cells[6].Value));
                }
            }

            // Thêm chuỗi dữ liệu vào biểu đồ
            chart1.Series.Add(series);

            // Đặt tiêu đề cho trục x và y
            chart1.ChartAreas[0].AxisX.Title = "Ngày ký kết";
            chart1.ChartAreas[0].AxisY.Title = "Tổng tiền";

            // Cập nhật lại biểu đồ
            chart1.Update();
        }
        private void rdoTheongay_CheckedChanged(object sender, EventArgs e)
        {
            txtTheongay.Enabled = true;
            txtTungay.Enabled = false;
            txtDenngay.Enabled = false;
        }

        private void rdoTrongkhoang_CheckedChanged(object sender, EventArgs e)
        {
            txtTheongay.Enabled = false;
            txtTungay.Enabled = true;
            txtDenngay.Enabled = true;
        }

        //Sử dụng nút enter để kích hoạt tra cứu
        private void txtMahopdong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTracuu.PerformClick();
            }
        }

        private void txtTenkhachhang_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnTracuu.PerformClick();
            }
        }

        private void txtTennhanvien_KeyDown(object sender, KeyEventArgs e)
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


        // Thiết lập nút Tra cứu
        private void btnTracuu_Click(object sender, EventArgs e)
        {
            string sql = "select * from Baocaodoanhthu where 1 = 1";
            if (txtMahopdong.Text.Trim() == "" && txtTenkhachhang.Text.Trim() == "" && txtTennhanvien.Text.Trim() == "" && txtMahopdong.Text.Trim() == "" && rdoTheongay.Checked == false && rdoTrongkhoang.Checked == false)
            {
                MessageBox.Show("Hãy nhập ít nhất một thông tin để tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (rdoTheongay.Checked)
            {
                if (!Classes.Functions.IsDate(txtTheongay.Text.Trim()))
                {
                    MessageBox.Show("Ngày tra cứu không hợp lệ. Vui lòng nhập đúng định dạng ngày tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (rdoTrongkhoang.Checked)
            {
                int compare = DateTime.Compare(DateTime.Parse(txtDenngay.Text), DateTime.Parse(txtTungay.Text));

                if (!Classes.Functions.IsDate(txtTungay.Text.Trim()))
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng nhập đúng định dạng ngày tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Classes.Functions.IsDate(txtDenngay.Text.Trim()))
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
            if (txtTenkhachhang.Text.Trim() != "")
            {
                sql += "and Tenkhachhang = N'" + txtTenkhachhang.Text.Trim() + "'";
            }
            if (txtTennhanvien.Text.Trim() != "")
            {
                sql += "and Tennhanvien = N'" + txtTennhanvien.Text.Trim() + "'";
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
            SetupColumnChart();
            lbTongdoanhthuso.Text = "Tổng doanh thu bằng số: " + CalculateColumnTotal(dataGridView1, 6) + " nghìn đồng";
            lbTongdoanhthuchu.Text = "Tổng doanh thu bằng chữ: " + NumberConverter.NumberToWords((long)CalculateColumnTotal(dataGridView1, 6)) + " đồng";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string sql = "select * from Baocaodoanhthu";
            txtTenkhachhang.Text = "";
            txtTennhanvien.Text = "";
            txtMahopdong.Text = "";
            txtTheongay.Text = "";
            txtTheongay.Enabled = false;
            txtTungay.Text = "";
            txtTungay.Enabled = false;
            txtDenngay.Text = "";
            txtDenngay.Enabled = false;
            rdoTheongay.Checked = false;
            rdoTrongkhoang.Checked = false;
            txtMahopdong.Focus();
            Load_DataGridView(sql);
            SetupColumnChart();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string filepath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Đặt các thuộc tính cho SaveFileDialog
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            // Hiển thị hộp thoại mở tệp và kiểm tra xem người dùng đã chọn tệp nào để lưu chưa
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                filepath = saveFileDialog.FileName;
            }
            ExportToExcel(dataGridView1, filepath);
        }

        // Tìm vị trí ô tổng doanh thu trong excel
        private decimal CalculateColumnTotal(DataGridView dataGridView, int columnIndex)
        {
            decimal total = 0;

            // Lặp qua các hàng của DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Kiểm tra giá trị của ô trong cột columnIndex
                if (row.Cells[columnIndex].Value != null)
                {
                    // Thêm giá trị của ô vào tổng
                    total += Convert.ToDecimal(row.Cells[columnIndex].Value);
                }
            }

            return total;
        }

        private void ExportToExcel(DataGridView datagridview, string filepath)
        {
            try
            {
                // Khởi tạo một ứng dụng Excel mới
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true; // Hiển thị ứng dụng Excel

                // Tạo một Workbook mới
                Excel.Workbook workbook = excelApp.Workbooks.Add(System.Reflection.Missing.Value);

                // Tạo một Worksheet mới
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                // Đặt tiêu đề cho báo cáo
                worksheet.Cells[1, 1] = "Báo Cáo Doanh Thu";
                Excel.Range titleRange = worksheet.Range["A1", "G1"];
                titleRange.Merge();
                titleRange.Font.Size = 16;
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Đặt tiêu đề cho các cột từ DataGridView
                for (int i = 0; i < datagridview.Columns.Count; i++)
                {
                    worksheet.Cells[2, i + 1] = datagridview.Columns[i].HeaderText;
                    worksheet.Cells[2, i + 1].Font.Bold = true;
                    worksheet.Cells[2, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }

                // Sao chép dữ liệu từ DataGridView sang Excel
                for (int i = 0; i < datagridview.Rows.Count; i++)
                {
                    for (int j = 0; j < datagridview.Columns.Count; j++)
                    {
                        if ((j == 3 || j == 4 || j == 5) && datagridview.Rows[i].Cells[j].Value != null)
                        {
                            DateTime dateValue;
                            if (DateTime.TryParse(datagridview.Rows[i].Cells[j].Value.ToString(), out dateValue))
                            {
                                worksheet.Cells[i + 3, j + 1].NumberFormat = "dd/MM/yyyy";
                                worksheet.Cells[i + 3, j + 1].Value = dateValue;
                            }
                        }
                        else
                        {
                            worksheet.Cells[i + 3, j + 1].Value = datagridview.Rows[i].Cells[j].Value;
                        }
                    }
                }

                // Thêm công thức tính tổng vào cột "Tổng tiền" (giả định cột này có index là 7)
                int totalRow = datagridview.Rows.Count + 3;
                worksheet.Cells[totalRow, 6] = "Tổng tiền: ";
                worksheet.Cells[totalRow, 6].Font.Bold = true;
                worksheet.Cells[totalRow, 6].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightYellow);
                worksheet.Cells[totalRow, 7].Formula = $"=SUM(G3:G{totalRow - 1})";
                worksheet.Cells[totalRow, 7].Font.Bold = true;
                worksheet.Cells[totalRow, 7].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightYellow);

                // AutoFit cột để điều chỉnh độ rộng dựa trên nội dung
                worksheet.Columns.AutoFit();

                // Lưu Workbook vào một tệp Excel
                workbook.SaveAs("" + filepath);

                // Đóng Workbook và ứng dụng Excel
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
    }

    // Chuyển số thành chữ
    public class NumberConverter
    {
        private static readonly string[] Units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private static readonly string[] Tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        private static readonly string[] Hundreds = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
        private static readonly string[] BigNumbers = { "", "nghìn", "triệu", "tỷ" };

        private static string ConvertThreeDigitNumber(int number)
        {
            int hundred = number / 100;
            int ten = (number % 100) / 10;
            int unit = number % 10;

            StringBuilder result = new StringBuilder();

            if (hundred > 0)
            {
                result.Append(Hundreds[hundred]);
            }

            if (ten == 0 && unit > 0)
            {
                if (hundred > 0)
                {
                    result.Append(" linh");
                }
                result.Append(" ").Append(Units[unit]);
            }
            else
            {
                if (ten > 0)
                {
                    if (hundred > 0)
                    {
                        result.Append(" ");
                    }
                    result.Append(Tens[ten]);
                }

                if (unit > 0)
                {
                    if (hundred > 0 || ten > 0)
                    {
                        result.Append(" ");
                    }
                    if (ten == 1 && unit == 1)
                    {
                        result.Append("một");
                    }
                    else if (ten > 1 && unit == 5)
                    {
                        result.Append("lăm");
                    }
                    else
                    {
                        result.Append(Units[unit]);
                    }
                }
            }

            return result.ToString().Trim();
        }

        private static string ConvertNumberToWords(long number)
        {
            if (number == 0)
            {
                return "không";
            }

            StringBuilder result = new StringBuilder();

            int[] groups = new int[4];
            int groupIndex = 0;

            while (number > 0)
            {
                groups[groupIndex] = (int)(number % 1000);
                number /= 1000;
                groupIndex++;
            }

            for (int i = groupIndex - 1; i >= 0; i--)
            {
                if (groups[i] > 0)
                {
                    if (result.Length > 0)
                    {
                        result.Append(" ");
                    }
                    result.Append(ConvertThreeDigitNumber(groups[i]));
                    if (i > 0)
                    {
                        result.Append(" ").Append(BigNumbers[i]);
                    }
                }
            }

            return result.ToString().Trim();
        }

        public static string NumberToWords(long number)
        {
            return ConvertNumberToWords(number);
        }
    }
}
