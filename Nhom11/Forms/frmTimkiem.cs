using Nhom11.Classes;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;

namespace Nhom11.Forms
{
    public partial class frmTimkiem : Form
    {
        DataTable tblLVHD;
        DataTable tblKH;

        public frmTimkiem()
        {
            InitializeComponent();
        }

        private void Load_Combobox(object sender, EventArgs e)
        {
            string sql = "SELECT DISTINCT TenLVHD FROM tblLVHD";
            tblLVHD = Functions.GetDataToTable(sql);

            if (tblLVHD.Rows.Count > 0)
            {
                cboLVHD.DataSource = tblLVHD;
                cboLVHD.DisplayMember = "TenLVHD";
                cboLVHD.ValueMember = "TenLVHD";
                cboLVHD.SelectedIndex = -1; // Không chọn mục nào trong danh sách
                cboLVHD.Text = ""; // Đặt giá trị hiển thị mặc định là chuỗi rỗng
            }
            else
            {
                cboLVHD.DataSource = null;
                cboLVHD.Text = ""; // Đặt giá trị hiển thị mặc định là chuỗi rỗng
            }
        }



        private void frmTimkiem_Load(object sender, EventArgs e)
        {
            Load_Combobox(sender, e);
        }

        private void ResetValues()
        {
            txtMakhachhang.Text = "";
            txtTenkhachhang.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtEmail.Text = "";
            cboLVHD.SelectedIndex = -1;
        }

        private void Load_DataGridView()
        {
            string maKH = txtMakhachhang.Text.Trim();
            string tenKH = txtTenkhachhang.Text.Trim();
            string diachi = txtDiachi.Text.Trim();
            string dienthoai = txtDienthoai.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();
            string email = txtEmail.Text.Trim();
            string maLVHD = cboLVHD.Text.Trim();

            string sql =
                "SELECT kh.Makhachhang, kh.Tenkhachhang, kh.Diachi, kh.Dienthoai, kh.Email, lvhd.TenLVHD, " +
                "COUNT(hd.Makhachhang) AS Solanky, MAX(hd.Ngaykyket) AS Ngaykygannhat, SUM(hd.Tongtien) AS Tongtien " +
                "FROM tblKhachhang kh " +
                "LEFT JOIN tblHopdong hd ON kh.Makhachhang = hd.Makhachhang " +
                "INNER JOIN tblLVHD lvhd ON kh.MaLVHD = lvhd.MaLVHD " +
                "WHERE 1=1";

            if (!string.IsNullOrEmpty(maKH))
            {
                sql += " AND kh.Makhachhang = N'" + maKH + "'";
            }
            if (!string.IsNullOrEmpty(tenKH))
            {
                sql += " AND kh.Tenkhachhang LIKE N'%" + tenKH + "%'";
            }
            if (!string.IsNullOrEmpty(diachi))
            {
                sql += " AND kh.Diachi = N'" + diachi + "'";
            }
            if (!string.IsNullOrEmpty(dienthoai))
            {
                sql += " AND kh.Dienthoai = N'" + dienthoai + "'";
            }
            if (!string.IsNullOrEmpty(email))
            {
                sql += " AND kh.Email = N'" + email + "'";
            }
            if (!string.IsNullOrEmpty(maLVHD))
            {
                sql += " AND lvhd.TenLVHD = N'" + maLVHD + "'";
            }

            sql += " GROUP BY kh.Makhachhang, kh.Tenkhachhang, kh.Diachi, kh.Dienthoai, kh.Email, lvhd.TenLVHD;";

            try
            {
                tblKH = Functions.GetDataToTable(sql);
                if (tblKH != null && tblKH.Rows.Count > 0)
                {
                    DataGridView.DataSource = tblKH;
                    SetDataGridViewColumns();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDataGridViewColumns()
        {
            DataGridView.Columns[0].HeaderText = "Mã khách hàng";
            DataGridView.Columns[1].HeaderText = "Tên khách hàng";
            DataGridView.Columns[2].HeaderText = "Địa chỉ";
            DataGridView.Columns[3].HeaderText = "Điện thoại";
            DataGridView.Columns[4].HeaderText = "Email";
            DataGridView.Columns[5].HeaderText = "Lĩnh vực hoạt động";
            DataGridView.Columns[6].HeaderText = "Số lần ký";
            DataGridView.Columns[7].HeaderText = "Ngày ký gần nhất";
            DataGridView.Columns[8].HeaderText = "Tổng tiền";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 120;
            DataGridView.Columns[2].Width = 150;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 120;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.Columns[7].Width = 100;
            DataGridView.Columns[8].Width = 100;

            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string maKH = txtMakhachhang.Text.Trim();
            string tenKH = txtTenkhachhang.Text.Trim();
            string diachi = txtDiachi.Text.Trim();
            string dienthoai = txtDienthoai.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();
            string email = txtEmail.Text.Trim();
            string maLVHD = cboLVHD.Text.Trim();

            if (string.IsNullOrEmpty(maKH) &&
                string.IsNullOrEmpty(tenKH) &&
                string.IsNullOrEmpty(diachi) &&
                string.IsNullOrEmpty(dienthoai) &&
                string.IsNullOrEmpty(email) &&
                string.IsNullOrEmpty(maLVHD))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện tìm kiếm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Load_DataGridView();
            }
        }



        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn thoát ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
