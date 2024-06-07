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
    public partial class frmTacgia : Form
    {
        DataTable table;
        public frmTacgia()
        {
            InitializeComponent();
        }

        private void frmTacgia_Load(object sender, EventArgs e)
        {
            txtMatacgia.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            ResetValues();
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblTacgia";
            table = Functions.GetDataToTable(sql);
            DataGridView.DataSource = table;
            DataGridView.Columns[0].HeaderText = "Mã tác giả";
            DataGridView.Columns[1].HeaderText = "Tên tác giả";
            DataGridView.Columns[2].HeaderText = "Địa chỉ";
            DataGridView.Columns[3].HeaderText = "Điện thoại";
            DataGridView.Columns[4].HeaderText = "Email";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 120;
            DataGridView.Columns[2].Width = 300;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 120;
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
                txtMatacgia.Focus();
                return;
            }
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            txtMatacgia.Text = DataGridView.CurrentRow.Cells["Matacgia"].Value.ToString();
            txtTentacgia.Text = DataGridView.CurrentRow.Cells["Tentacgia"].Value.ToString();
            txtDiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            txtDienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
            txtEmail.Text = DataGridView.CurrentRow.Cells["Email"].Value.ToString();                   
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
            txtMatacgia.Enabled = true;
            txtMatacgia.Focus();
        }
        private void ResetValues()
        {
            txtMatacgia.Text = "";
            txtTentacgia.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtEmail.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMatacgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã tác giả", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatacgia.Focus();
                return;
            }
            if (txtTentacgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tác giả", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTentacgia.Focus();
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
                MessageBox.Show("Bạn phải nhập số điện thoại tác giả", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienthoai.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email tác giả", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
        

            sql = "SELECT Matacgia FROM tblTacgia WHERE Matacgia=N'" + txtMatacgia.Text.Trim() + "'";
            if (Classes.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã tác giả này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatacgia.Focus();
                txtMatacgia.Text = "";
                return;
            }
            sql = "INSERT INTO tblTacgia (Matacgia, Tentacgia, Diachi, Dienthoai, Email) VALUES(N'" + txtMatacgia.Text.Trim() + "', N'" + txtTentacgia.Text.Trim() + "', '" + txtDiachi.Text.Trim() + "', '" + txtDienthoai.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim() + "', '" + txtEmail.Text.Trim() + "')";
            Classes.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMatacgia.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMatacgia.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTentacgia.Text == "")
            {
                MessageBox.Show("Bạn nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTentacgia.Focus();
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
            

            sql = "UPDATE tblTacgia SET  Tentacgia=N'" + txtTentacgia.Text.Trim().ToString() +
               "',Diachi=N'" + txtDiachi.Text.Trim().ToString() +
               "',Dienthoai='" + txtDienthoai.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").ToString() + "',Email='" + txtEmail.Text.Trim().ToString() +
                "' WHERE Matacgia=N'" + txtMatacgia.Text + "'";
            Classes.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMatacgia.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblTacgia WHERE Matacgia=N'" + txtMatacgia.Text + "'";
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
            txtMatacgia.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn thoát ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
