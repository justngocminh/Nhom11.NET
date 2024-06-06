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
    public partial class frmBaibao : Form
    {
        DataTable tblBaibao;
        public frmBaibao()
        {
            InitializeComponent();
        }
        private void frmBaibao_Load(object sender, EventArgs e)
        {
            txtMabaibao.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            Load_DataGridView();
            Functions.FillComboBox("select Matacgia,Tentacgia from tblTacgia", cboTacgia, "Matacgia", "Tentacgia");
            cboTacgia.SelectedIndex = -1;
            Functions.FillComboBox("select Matheloai,Tentheloai from tblTheloai", cboTheloai, "Matheloai", "Tentheloai");
            cboTheloai.SelectedIndex = -1;
            Functions.FillComboBox("select Manhanvien,Tennhanvien from tblNhanvien", cboNhanvien, "Manhanvien", "Tennhanvien");
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Mabaibao, Matacgia, Matheloai, Manhanvien, Tieude, Noidung, Mota, Ngaydang FROM tblBaibao";
            tblBaibao = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblBaibao;
            DataGridView.Columns[0].HeaderText = "Mã bài báo";
            DataGridView.Columns[1].HeaderText = "Tác giả";
            DataGridView.Columns[2].HeaderText = "Thể loại";
            DataGridView.Columns[3].HeaderText = "Nhân viên phụ trách";
            DataGridView.Columns[4].HeaderText = "Tiêu đề";
            DataGridView.Columns[5].HeaderText = "Nội dung";
            DataGridView.Columns[6].HeaderText = "Mô tả";
            DataGridView.Columns[7].HeaderText = "Ngày đăng";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.Columns[7].Width = 100;
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
            txtMabaibao.Enabled = true;
            txtMabaibao.Focus();
        }
        private void ResetValues()
        {
            txtMabaibao.Text = "";
            txtTieude.Text = "";
            mskNgaydang.Text = "";
            txtNoidung.Text = "";
            txtMota.Text = "";
            cboTacgia.Text = "";
            cboTheloai.Text = "";
            cboNhanvien.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMabaibao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bài báo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMabaibao.Focus();
                return;
            }
            if (txtTieude.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tiêu đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTieude.Focus();
                return;
            }
            if (txtNoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoidung.Focus();
                return;
            }
            if (txtMota.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMota.Focus();
                return;
            }
            if (mskNgaydang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaydang.Focus();
                return;
            }
            if (!Functions.IsValidDate(mskNgaydang.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaydang.Text = "";
                mskNgaydang.Focus();
                return;
            }
            if (cboTacgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTacgia.Focus();
                return;
            }
            if (cboTheloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTheloai.Focus();
                return;
            }
            if (cboNhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên phụ trách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhanvien.Focus();
                return;
            }
            sql = "SELECT Mabaibao FROM tblBaibao WHERE Mabaibao=N'" + txtMabaibao.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã bài báo này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMabaibao.Focus();
                txtMabaibao.Text = "";
                return;
            }
            sql = "INSERT INTO tblBaibao(Mabaibao, Matacgia, Matheloai, Manhanvien, Tieude, Noidung, Mota, Ngaydang) VALUES(N'" + txtMabaibao.Text.Trim() + "', '" + cboTacgia.SelectedValue.ToString() + "', '" + cboTheloai.SelectedValue.ToString() + "', '" + cboNhanvien.SelectedValue.ToString() + "', N'" + txtTieude.Text.Trim() + "', N'" + txtNoidung.Text.Trim() + "', N'" + txtMota.Text.Trim() + "', '" + Functions.ConvertDateTime(mskNgaydang.Text) + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMabaibao.Enabled = false;
        }
        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMabaibao.Focus();
                return;
            }
            if (tblBaibao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMabaibao.Text = DataGridView.CurrentRow.Cells["Mabaibao"].Value.ToString();
            txtTieude.Text = DataGridView.CurrentRow.Cells["Tieude"].Value.ToString();
            txtNoidung.Text = DataGridView.CurrentRow.Cells["Noidung"].Value.ToString();
            txtMota.Text = DataGridView.CurrentRow.Cells["Mota"].Value.ToString();
            mskNgaydang.Text = DataGridView.CurrentRow.Cells["Ngaydang"].Value.ToString();
            string Matacgia, Matheloai, Manhanvien;
            Matacgia = DataGridView.CurrentRow.Cells["Matacgia"].Value.ToString();
            cboTacgia.Text = Functions.GetFieldValues("select Tentacgia from tblTacgia where Matacgia = '" + Matacgia + "'");
            Matheloai = DataGridView.CurrentRow.Cells["Matheloai"].Value.ToString();
            cboTheloai.Text = Functions.GetFieldValues("select Tentheloai from tblTheloai where Matheloai = '" + Matheloai + "'");
            Manhanvien = DataGridView.CurrentRow.Cells["Manhanvien"].Value.ToString();
            cboNhanvien.Text = Functions.GetFieldValues("select Tennhanvien from tblNhanvien where Manhanvien = '" + Manhanvien + "'");
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblBaibao.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMabaibao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTieude.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tiêu đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTieude.Focus();
                return;
            }
            if (txtNoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoidung.Focus();
                return;
            }
            if (txtMota.Text.Trim() == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMota.Focus();
                return;
            }
            if (mskNgaydang.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaydang.Focus();
                return;
            }
            if (!Functions.IsValidDate(mskNgaydang.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaydang.Text = "";
                mskNgaydang.Focus();
                return;
            }
            if (cboTacgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTacgia.Focus();
                return;
            }
            if (cboTheloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTheloai.Focus();
                return;
            }
            if (cboNhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhanvien.Focus();
                return;
            }
            sql = "UPDATE tblBaibao SET  Tieude=N'" + txtTieude.Text.Trim().ToString() +
                    "',Mota=N'" + txtMota.Text.Trim().ToString() +
                    "',Noidung='" + txtNoidung.Text.ToString() + "',Ngaydang='" + Functions.ConvertDateTime(mskNgaydang.Text) +
                    "',Matacgia = '" + cboTacgia.SelectedValue.ToString() +
                    "',Matheloai = '" + cboTheloai.SelectedValue.ToString() + "',Manhanvien = '" + cboNhanvien.SelectedValue.ToString() +
                    "' WHERE Mabaibao=N'" + txtMabaibao.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = false;
            btnBoqua.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblBaibao.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMabaibao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblBaibao WHERE Mabaibao=N'" + txtMabaibao.Text + "'";
                Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMabaibao.Enabled = false;
        }
    }
}
