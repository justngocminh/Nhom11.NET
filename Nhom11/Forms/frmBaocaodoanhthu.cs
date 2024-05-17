using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Nhom11.Forms
{
    public partial class frmBaocaodoanhthu : Form
    {
        DataTable table;
        public frmBaocaodoanhthu()
        {
            InitializeComponent();
            this.Size = new Size(1000, 570);
        }
        private void Load_DataGridView(string sql)
        {
            //sql = "select Mahopdong, Tenkhachhang, Tennhanvien, Ngaykyket, Ngaybatdau, Ngayketthuc, Tongtien from Hopdong left join tblNhanvien on Hopdong.Manhanvien = tblNhanvien.Manhanvien left join tblKhachhang on Hopdong.Makhachhang = tblKhachhang.Makhachhang";
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
        }

        private void frmBaocaodoanhthu_Load(object sender, EventArgs e)
        {
            string sql = "select * from Baocaodoanhthu";
            txtTheongay.Enabled = false;
            txtTungay.Enabled = false;
            txtDenngay.Enabled = false;
            Load_DataGridView(sql);
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
                sql += "and Ngaykyket = N'" + Classes.Functions.ConvertDateTime(txtTungay.Text.Trim()) + "'";
            }
            Load_DataGridView(sql);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string sql = "select * from Baocaodoanhthu";
            txtTenkhachhang.Text = "";
            txtTennhanvien.Text = "";
            txtMahopdong.Text = "";
            txtTheongay.Text = "";
            txtTungay.Text = "";
            txtDenngay.Text = "";
            rdoTheongay.Checked = false;
            rdoTrongkhoang.Checked = false;
            Load_DataGridView(sql);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string filepath = "E:\\Homeworks\\forC#\\Nhom11.NET\\Baocaodoanhthu.xlsx";
            //string filepath = "";
            //SaveFileDialog saveFileDialog = new SaveFileDialog();

            //// Đặt các thuộc tính cho SaveFileDialog
            //saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            //saveFileDialog.FilterIndex = 1;
            //saveFileDialog.RestoreDirectory = true;

            //// Hiển thị hộp thoại mở tệp và kiểm tra xem người dùng đã chọn tệp nào để lưu chưa
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{

            //    filepath = saveFileDialog.FileName;
            //}
            ExportToExcel(dataGridView1, filepath);
        }
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

                worksheet.Range["A1", "G1"].Value = "BÁO CÁO DOANH THU";


                // Đặt tiêu đề cho các cột từ DataGridView
                for (int i = 0; i < datagridview.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 2] = datagridview.Columns[i].HeaderText;
                    worksheet.Cells[1, i + 2].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightYellow);
                }

                // Sao chép dữ liệu từ DataGridView sang Excel
                for (int i = 0; i < datagridview.Rows.Count; i++)
                {
                    for (int j = 0; j < datagridview.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 2] = datagridview.Rows[i].Cells[j].Value.ToString();
                    }
                }

                int totalcellrow = datagridview.Rows.Count + 2;
                int totalcellcol = datagridview.Columns.Count;

                decimal totalvalue = CalculateColumnTotal(dataGridView1, 6);

                worksheet.Cells[totalcellcol - 1, totalcellrow] = "Tổng doanh thu: ";
                worksheet.Cells[totalcellcol, totalcellrow] = "" + totalvalue;

                // AutoFit cột để điều chỉnh độ rộng dựa trên nội dung
                worksheet.Columns.AutoFit();

                // Lưu Workbook vào một tệp Excel
                workbook.SaveAs("" + filepath);

                // Đóng Workbook và ứng dụng Excel
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Dữ liệu đã được xuất thành công sang Excel.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
