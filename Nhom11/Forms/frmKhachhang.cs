using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Nhom11.Forms;
using Nhom11.Classes;

namespace Nhom11.Forms
{
    public partial class frmKhachhang : Form
    {
        DataTable tblKH;
        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            txtMakhachhang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            Functions.FillComboBox("SELECT MaLVHD, TenLVHD FROM tblLVHD", cboLVHD, "MaLVHD", "TenLVHD");
            cboLVHD.SelectedIndex = -1;
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblKhachhang";
            tblKH = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblKH;
            DataGridView.Columns[0].HeaderText = "Mã khách hàng";
            DataGridView.Columns[1].HeaderText = "Tên khách hàng";
            DataGridView.Columns[2].HeaderText = "Địa chỉ";
            DataGridView.Columns[3].HeaderText = "Điện thoại";
            DataGridView.Columns[4].HeaderText = "Email";
            DataGridView.Columns[5].HeaderText = "Lĩnh vực hoạt động";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 120;
            DataGridView.Columns[2].Width = 150;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 120;
            DataGridView.Columns[5].Width = 150;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhachhang.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            txtMakhachhang.Text = DataGridView.CurrentRow.Cells["Makhachhang"].Value.ToString();
            txtTenkhachhang.Text = DataGridView.CurrentRow.Cells["Tenkhachhang"].Value.ToString();
            txtDiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            txtDienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
            txtEmail.Text = DataGridView.CurrentRow.Cells["Email"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["MaLVHD"].Value.ToString();
            cboLVHD.Text = Functions.GetFielbValues("SELECT TenLVHD FROM  tblLVHD WHERE MaLVHD = N'" + ma + "'");
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMakhachhang.Enabled = true;
            txtMakhachhang.Focus();
        }
        private void ResetValues()
        {
            txtMakhachhang.Text = "";
            txtTenkhachhang.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtEmail.Text = "";
            cboLVHD.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMakhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhachhang.Focus();
                return;
            }
            if (txtTenkhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhachhang.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (txtDienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienthoai.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email khách hàng", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (cboLVHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lĩnh vực hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLVHD.Focus();
                return;
            }

            sql = "SELECT Makhachhang FROM tblKhachhang WHERE Makhachhang=N'" + txtMakhachhang.Text.Trim() + "'";
            if (Classes.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhachhang.Focus();
                txtMakhachhang.Text = "";
                return;
            }
            sql = "INSERT INTO tblKhachhang (Makhachhang, Tenkhachhang, Diachi, Dienthoai, Email, MaLVHD) VALUES(N'" + txtMakhachhang.Text.Trim() + "', N'" + txtTenkhachhang.Text.Trim() + "', '" + txtDiachi.Text.Trim() + "', '" + txtDienthoai.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim() + "', '" + txtEmail.Text.Trim() + "', N'" + cboLVHD.SelectedValue.ToString() + "')";
            Classes.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMakhachhang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakhachhang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenkhachhang.Text == "")
            {
                MessageBox.Show("Bạn nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenkhachhang.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (txtDienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienthoai.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            if (cboLVHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lĩnh vực hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLVHD.Focus();
                return;
            }

            sql = "UPDATE tblKhachhang SET  Tenkhachhang=N'" + txtTenkhachhang.Text.Trim().ToString() +
               "',Diachi=N'" + txtDiachi.Text.Trim().ToString() +
               "',Dienthoai='" + txtDienthoai.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").ToString() + "',Email='" + txtEmail.Text.Trim().ToString() +
               "', MaLVHD=N'" + cboLVHD.SelectedValue.ToString() + "' WHERE Makhachhang=N'" + txtMakhachhang.Text + "'";
            Classes.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakhachhang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblKhachhang WHERE Makhachhang=N'" + txtMakhachhang.Text + "'";
                Classes.Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMakhachhang.Enabled = false;
        }
        private void txtMakhachhang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
        private void txtTenkhachhang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
        private void txtDiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
        private void txtDienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn thoát ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            frmTimkiem form = new frmTimkiem();
            form.Show();
        }
    }
}

