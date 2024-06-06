using Nhom11.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11.Forms
{
    public partial class frmNhanvien : Form
    {
        DataTable tblNhanvien;
        public frmNhanvien()
        {
            InitializeComponent();
        }
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            txtManhanvien.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            Load_DataGridView();
            Functions.FillComboBox("select Machuyenmon,Tenchuyenmon from tblChuyenmon", cboChuyenmon, "Machuyenmon", "Tenchuyenmon");
            cboChuyenmon.SelectedIndex = -1;
            Functions.FillComboBox("select Maphongban,Tenphongban from tblPhongban", cboPhongban, "Maphongban", "Tenphongban");
            cboPhongban.SelectedIndex = -1;
            Functions.FillComboBox("select Matrinhdo,Tentrinhdo from tblTrinhdo", cboTrinhdo, "Matrinhdo", "Tentrinhdo");
            cboTrinhdo.SelectedIndex = -1;
            Functions.FillComboBox("select Machucvu,Tenchucvu from tblChucvu", cboChucvu, "Machucvu", "Tenchucvu");
            cboChucvu.SelectedIndex = -1;
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Manhanvien, Tennhanvien, Gioitinh, Diachi, Dienthoai, Ngaysinh, Email, Maphongban, Machucvu, Matrinhdo, Machuyenmon FROM tblNhanvien";
            tblNhanvien = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblNhanvien;
            DataGridView.Columns[0].HeaderText = "Mã nhân viên";
            DataGridView.Columns[1].HeaderText = "Tên nhân viên";
            DataGridView.Columns[2].HeaderText = "Giới tính";
            DataGridView.Columns[3].HeaderText = "Địa chỉ";
            DataGridView.Columns[4].HeaderText = "Điện thoại";
            DataGridView.Columns[5].HeaderText = "Ngày sinh";
            DataGridView.Columns[6].HeaderText = "Email";
            DataGridView.Columns[7].HeaderText = "Phòng ban";
            DataGridView.Columns[8].HeaderText = "Chức vụ";
            DataGridView.Columns[9].HeaderText = "Trình độ";
            DataGridView.Columns[10].HeaderText = "Chuyên môn";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.Columns[7].Width = 100;
            DataGridView.Columns[8].Width = 100;
            DataGridView.Columns[9].Width = 100;
            DataGridView.Columns[10].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManhanvien.Enabled = true;
            txtManhanvien.Focus();
        }
        private void ResetValues()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            mskNgaysinh.Text = "";
            mskDienthoai.Text = "";
            txtEmail.Text = "";
            chkGioitinh.Checked = false;
            txtDiachi.Text = "";
            cboPhongban.Text = "";
            cboTrinhdo.Text = "";
            cboChuyenmon.Text = "";
            cboChucvu.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (mskNgaysinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Functions.IsValidDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (cboChucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChucvu.Focus();
                return;
            }
            if (cboPhongban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhongban.Focus();
                return;
            }
            if (cboTrinhdo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn trình độ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrinhdo.Focus();
                return;
            }
            if (cboChuyenmon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn chuyên môn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChuyenmon.Focus();
                return;
            }
            sql = "SELECT Manhanvien FROM tblNhanvien WHERE Manhanvien=N'" + txtManhanvien.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanvien(Manhanvien,Tennhanvien,Gioitinh, Diachi, Dienthoai, Ngaysinh, Email, Maphongban, Machucvu, Matrinhdo, Machuyenmon) VALUES(N'" + txtManhanvien.Text.Trim() + "', N'" + txtTennhanvien.Text.Trim() + "', N'" + gt + "', N'" + txtDiachi.Text.Trim() + "', '" + mskDienthoai.Text + "', '" + Functions.ConvertDateTime(mskNgaysinh.Text) + "', '" + txtEmail.Text + "', '" + cboPhongban.SelectedValue.ToString() + "', '" + cboChucvu.SelectedValue.ToString() + "', '" + cboTrinhdo.SelectedValue.ToString() + "', '" + cboChuyenmon.SelectedValue.ToString() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }
        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhanvien.Focus();
                return;
            }
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManhanvien.Text = DataGridView.CurrentRow.Cells["Manhanvien"].Value.ToString();
            txtTennhanvien.Text = DataGridView.CurrentRow.Cells["Tennhanvien"].Value.ToString();
            if (DataGridView.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
                chkGioitinh.Checked = true;
            else
                chkGioitinh.Checked = false;
            txtDiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mskNgaysinh.Text = DataGridView.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            txtEmail.Text = DataGridView.CurrentRow.Cells["Email"].Value.ToString();
            string Machuyenmon, Maphongban, Matrinhdo, Machucvu;
            Machuyenmon = DataGridView.CurrentRow.Cells["Machuyenmon"].Value.ToString();
            cboChuyenmon.Text = Functions.GetFieldValues("select Tenchuyenmon from tblChuyenmon where Machuyenmon = '" + Machuyenmon + "'");
            Maphongban = DataGridView.CurrentRow.Cells["Maphongban"].Value.ToString();
            cboPhongban.Text = Functions.GetFieldValues("select Tenphongban from tblPhongban where Maphongban = '" + Maphongban + "'");
            Machucvu = DataGridView.CurrentRow.Cells["Machucvu"].Value.ToString();
            cboChucvu.Text = Functions.GetFieldValues("select Tenchucvu from tblChucvu where Machucvu = '" + Machucvu + "'");
            Matrinhdo = DataGridView.CurrentRow.Cells["Matrinhdo"].Value.ToString();
            cboTrinhdo.Text = Functions.GetFieldValues("select Tentrinhdo from tblTrinhdo where Matrinhdo = '" + Matrinhdo + "'");
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text.Trim() == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Functions.IsValidDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (cboChucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChucvu.Focus();
                return;
            }
            if (cboChuyenmon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn chuyên môn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChuyenmon.Focus();
                return;
            }
            if (cboPhongban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhongban.Focus();
                return;
            }
            if (cboTrinhdo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn trình độ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrinhdo.Focus();
                return;
            }
            sql = "UPDATE tblNhanvien SET  Tennhanvien=N'" + txtTennhanvien.Text.Trim().ToString() +
                    "',Diachi=N'" + txtDiachi.Text.Trim().ToString() +
                    "',Dienthoai='" + mskDienthoai.Text.ToString() + "',Gioitinh=N'" + gt +
                    "',Ngaysinh='" + Functions.ConvertDateTime(mskNgaysinh.Text) +
                    "',Email=N'" + txtEmail.Text.Trim().ToString() + "',Maphongban = '" + cboPhongban.SelectedValue.ToString() +
                    "',Machucvu = '" + cboChucvu.SelectedValue.ToString() + "',MaTrinhdo = '" + cboTrinhdo.SelectedValue.ToString() +
                    "',Machuyenmon = '" + cboChuyenmon.SelectedValue.ToString() +
                    "' WHERE Manhanvien=N'" + txtManhanvien.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = false;
            btnBoqua.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanvien WHERE Manhanvien=N'" + txtManhanvien.Text + "'";
                Functions.RunSql(sql);
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
            txtManhanvien.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
