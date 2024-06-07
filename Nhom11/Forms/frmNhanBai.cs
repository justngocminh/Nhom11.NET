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
    public partial class frmNhanBai : Form
    {
        DataTable table;
        public frmNhanBai()
        {
            InitializeComponent();
        }


 
        private void frmNhanBai_Load(object sender, EventArgs e)
        {
            txtTacgia.Enabled = false;
            txtBaibao.Enabled = false;
            txtNV.Enabled = false;
            btnLuu.Enabled = false;
            btnChitiet.Enabled = false;
            Functions.FillComboBox("SELECT Matacgia FROM tblTacgia", cbMatacgia, "Matacgia", "Matacgia");
            cbMatacgia.SelectedIndex = -1;

            Functions.FillComboBox("SELECT Mabaibao FROM tblBaibao", cbMabaibao, "Mabaibao", "Mabaibao");
            cbMabaibao.SelectedIndex = -1;

            Functions.FillComboBox("SELECT Manhanvien FROM tblNhanvien", cbMaNV, "Manhanvien", "Manhanvien");
            cbMaNV.SelectedIndex = -1;

            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from tblNhanbai";
            table = Classes.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = table;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns[0].HeaderText = "Mã nhận bài";
            dataGridView1.Columns[1].HeaderText = "Mã tác giả";
            dataGridView1.Columns[2].HeaderText = "Mã bài báo";
            dataGridView1.Columns[3].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[4].HeaderText = "Ngày nhận bài";
            dataGridView1.Columns[5].HeaderText = "Nhuận bút";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhanbai.Focus();
                return;
            }

            DisplayData();
            btnChitiet.Enabled = true;
        }

        private void DisplayData()
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtNhanbai.Text = dataGridView1.CurrentRow.Cells["Manhanbai"].Value.ToString();
            string ma;
            ma = dataGridView1.CurrentRow.Cells["Matacgia"].Value.ToString();
            cbMatacgia.SelectedValue = ma;
            string tentacgia = Functions.GetFieldValues("SELECT Tentacgia FROM tblTacgia WHERE Matacgia = N'" + ma + "'");
            txtTacgia.Text = tentacgia;

            ma = dataGridView1.CurrentRow.Cells["Mabaibao"].Value.ToString();
            cbMabaibao.SelectedValue = ma;
            string tenbaibao = Functions.GetFieldValues("SELECT Tieude FROM tblBaibao WHERE Mabaibao = N'" + ma + "'");
            txtBaibao.Text = tenbaibao;

            ma = dataGridView1.CurrentRow.Cells["Manhanvien"].Value.ToString();
            cbMaNV.SelectedValue = ma;
            string tenNV = Functions.GetFieldValues("SELECT Tennhanvien FROM tblNhanvien WHERE Manhanvien = N'" + ma + "'");
            txtNV.Text = tenNV;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void cbMatacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMatacgia.SelectedIndex != -1)
            {
                string selectedMatacgia = cbMatacgia.SelectedValue.ToString();
                string tentacgia = Functions.GetFieldValues("SELECT Tentacgia FROM tblTacgia WHERE Matacgia = N'" + selectedMatacgia + "'");
                txtTacgia.Text = tentacgia;
            }
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMaNV.SelectedIndex != -1)
            {
                string selectedMaNV = cbMaNV.SelectedValue.ToString();
                string tennhanvien = Functions.GetFieldValues("SELECT Tennhanvien FROM tblNhanvien WHERE Manhanvien = N'" + selectedMaNV + "'");
                txtNV.Text = tennhanvien;
            }
        }

        private void cbMabaibao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMabaibao.SelectedIndex != -1)
            {
                string selectedMabaibao = cbMabaibao.SelectedValue.ToString();
                string tenbaibao = Functions.GetFieldValues("SELECT Tieude FROM tblBaibao WHERE Mabaibao = N'" + selectedMabaibao + "'");
                txtBaibao.Text = tenbaibao;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtNhanbai.Enabled = true;
            txtNhanbai.Focus();
        }

        private void ResetValues()
        {
            txtNhanbai.Text = "";
            cbMatacgia.SelectedItem = null;
            cbMabaibao.SelectedItem = null;
            cbMaNV.SelectedItem = null;
            txtNV.Text = "";
            txtBaibao.Text = "";
            txtTacgia.Text = "";
            btnChitiet.Enabled = false;
            Load_DataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNhanbai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbMatacgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbMabaibao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã bài báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem mã bài báo đã được chọn chưa, ngoại trừ bản ghi hiện tại
            sql = "SELECT Mabaibao FROM tblNhanbai WHERE Mabaibao = N'" + cbMabaibao.Text.Trim() + "' AND MaNhanbai <> N'" + txtNhanbai.Text.Trim() + "'";
            if (Classes.Functions.CheckKey(sql))
            {
                MessageBox.Show("Bài báo này đã được nhận bởi người khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMabaibao.Focus();
                cbMabaibao.Text = "";
                return;
            }

            if (txtNhanbai.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã nhận bài không được vượt quá 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime currentTime = DateTime.Now;

            string ngaynhanbai = currentTime.ToString("yyyy-MM-dd");

            string mabaibao = cbMabaibao.Text.Trim();

            // Lấy Matheloai từ tblBaibao dựa vào Mabaibao
            string sqlGetMatheloai = "SELECT Matheloai FROM tblBaibao WHERE Mabaibao = N'" + mabaibao + "'";
            string matheloai = Classes.Functions.GetFieldValues(sqlGetMatheloai);

            // Lấy Nhuanbut từ tblTheloai dựa vào Matheloai
            string sqlGetNhuanbut = "SELECT Nhuanbut FROM tblTheloai WHERE Matheloai = N'" + matheloai + "'";
            string nhuanbut = Classes.Functions.GetFieldValues(sqlGetNhuanbut);

            sql = "UPDATE tblNhanbai SET " +
              "Matacgia = N'" + cbMatacgia.Text.Trim() + "', " +
              "Mabaibao = N'" + cbMabaibao.Text.Trim() + "', " +
              "Manhanvien = N'" + cbMaNV.Text.Trim() + "', " +
              "Ngaynhanbai = N'" + ngaynhanbai + "', " +
              "Nhuanbut = N'" + nhuanbut + "' " +
              "WHERE MaNhanbai = N'" + txtNhanbai.Text.Trim() + "'";

            Classes.Functions.RunSql(sql);
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
                return;
            }
            if (txtNhanbai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy chọn một bản ghi!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblNhanbai where Manhanbai = N'" + txtNhanbai.Text + "'";
                Classes.Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtNhanbai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập mã nhận bài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhanbai.Focus();
                return;
            }
            if (cbMatacgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải chọn mã tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMatacgia.Focus();
                return;
            }
            if (cbMabaibao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải chọn mã bài báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMabaibao.Focus();
                return;
            }
            if (cbMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải chọn mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMaNV.Focus();
                return;
            }
            sql = "select Manhanbai from tblNhanbai where Manhanbai = N'" + txtNhanbai.Text.Trim() + "'";
            if (Classes.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhận bài này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhanbai.Focus();
                txtNhanbai.Text = "";
                return;
            }
            sql = "SELECT Mabaibao FROM tblNhanbai WHERE Mabaibao = N'" + cbMabaibao.Text.Trim() + "'";
            if (Classes.Functions.CheckKey(sql))
            {
                MessageBox.Show("Bài báo này đã được nhận bởi người khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMabaibao.Focus();
                cbMabaibao.Text = "";
                return;
            }

            if (txtNhanbai.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã nhận bài không được vượt quá 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhanbai.Focus();
                txtNhanbai.Text = "";
                return;
            }

            DateTime currentTime = DateTime.Now;

            string ngaynhanbai = currentTime.ToString("yyyy-MM-dd");

            string mabaibao = cbMabaibao.Text.Trim();

            // Lấy Matheloai từ tblBaibao dựa vào Mabaibao
            string sqlGetMatheloai = "SELECT Matheloai FROM tblBaibao WHERE Mabaibao = N'" + mabaibao + "'";
            string matheloai = Classes.Functions.GetFieldValues(sqlGetMatheloai);

            // Lấy Nhuanbut từ tblTheloai dựa vào Matheloai
            string sqlGetNhuanbut = "SELECT Nhuanbut FROM tblTheloai WHERE Matheloai = N'" + matheloai + "'";
            string nhuanbut = Classes.Functions.GetFieldValues(sqlGetNhuanbut);

            // Tiếp tục với việc thêm giá trị Nhuanbut vào câu truy vấn chèn dữ liệu vào bảng tblNhanbai
            sql = "INSERT INTO tblNhanbai (Manhanbai, Matacgia, Mabaibao, Manhanvien, Ngaynhanbai, Nhuanbut) VALUES (N'" + txtNhanbai.Text.Trim() + "', N'" + cbMatacgia.Text.Trim() + "', N'" + cbMabaibao.Text.Trim() + "', N'" + cbMaNV.Text.Trim() + "', N'" + ngaynhanbai + "', N'" + nhuanbut + "')";

            Classes.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtNhanbai.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblNhanbai WHERE 1=1";
            if (!string.IsNullOrEmpty(txtNhanbai.Text))
            {
                sql += " AND Manhanbai = N'" + txtNhanbai.Text + "'";
            }

            if (!string.IsNullOrEmpty(cbMatacgia.Text))
            {
                sql += " AND Matacgia = N'" + cbMatacgia.Text + "'";
            }

            if (!string.IsNullOrEmpty(cbMabaibao.Text))
            {
                sql += " AND Mabaibao = N'" + cbMabaibao.Text + "'";
            }

            if (!string.IsNullOrEmpty(cbMaNV.Text))
            {
                sql += " AND Manhanvien = N'" + cbMaNV.Text + "'";
            }

            table = Classes.Functions.GetDataToTable(sql);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bản ghi nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1.DataSource = table;
                DisplayData();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Lấy giá trị Manhanbai từ dòng hiện tại trong dataGridView1
                string manhanbai = dataGridView1.CurrentRow.Cells["Manhanbai"].Value.ToString();
                Hopdongnhanbai frm = new Hopdongnhanbai();
                frm.ManhanbaiFromNhanBai = manhanbai;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
