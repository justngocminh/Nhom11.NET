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
using Nhom11.Classes;

namespace Nhom11.Forms
{
    public partial class frmQuangcao : Form
    {
        DataTable tblQC;
        public frmQuangcao()
        {
            InitializeComponent();
        }

        private void frmQuangcao_Load(object sender, EventArgs e)
        {
            txtMaQC.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Maquangcao, Tenquangcao, Noidung, Dongia FROM tblQuangcao";
            tblQC = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblQC;
            DataGridView.Columns[0].HeaderText = "Mã quảng cáo";
            DataGridView.Columns[1].HeaderText = "Tên quảng cáo";
            DataGridView.Columns[2].HeaderText = "Nội dung";
            DataGridView.Columns[3].HeaderText = "Đơn giá";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 120;
            DataGridView.Columns[2].Width = 150;
            DataGridView.Columns[3].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaQC.Text = "";
            txtTenQC.Text = "";
            txtNoidung.Text = "";
            txtDongia.Text = "";
            txtAnh.Text = "";
            picAnh.Image = null;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaQC.Focus();
                return;
            }
            if (tblQC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaQC.Text = DataGridView.CurrentRow.Cells["Maquangcao"].Value.ToString();
            txtTenQC.Text = DataGridView.CurrentRow.Cells["Tenquangcao"].Value.ToString();
            txtNoidung.Text = DataGridView.CurrentRow.Cells["Noidung"].Value.ToString();
            txtDongia.Text = DataGridView.CurrentRow.Cells["Dongia"].Value.ToString();
            txtAnh.Text = Functions.GetFielbValues("SELECT Hinhanh FROM tblQuangcao WHERE Maquangcao = N'" + txtMaQC.Text + "'");
            picAnh.Image = Image.FromFile(txtAnh.Text);
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
            txtMaQC.Enabled = true;
            txtMaQC.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaQC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã quảng cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaQC.Focus();
                return;
            }
            if (txtTenQC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên quảng cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenQC.Focus();
                return;
            }
            if (txtNoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoidung.Focus();
                return;
            }
            if (txtDongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoidung.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho quảng cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }
            sql = "SELECT Maquangcao FROM tblQuangcao WHERE Maquangcao = N'" + txtMaQC.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã quảng cáo này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaQC.Focus();
                txtMaQC.Text = "";
                return;
            }
            sql = "INSERT INTO tblQuangcao (Maquangcao, Tenquangcao, Noidung, Dongia, Hinhanh) " + "VALUES (N'" + txtMaQC.Text.Trim() + "', N'" + txtTenQC.Text.Trim() + "', N'" + txtNoidung.Text.Trim() + "', " + txtDongia.Text.Trim() + ", N'" + txtAnh.Text.Trim() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaQC.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblQC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaQC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenQC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên quảng cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenQC.Focus();
                return;
            }
            if (txtNoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoidung.Focus();
                return;
            }
            if (txtDongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDongia.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho quảng cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE tblQuangcao SET  Tenquangcao=N'" + txtTenQC.Text.Trim().ToString() +
                "',Noidung=N'" + txtNoidung.Text.Trim().ToString() +
                "',Dongia=N'" + txtDongia.Text.Trim().ToString() +
                "',Hinhanh=N'" + txtAnh.Text +
                "' WHERE Maquangcao=N'" + txtMaQC.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblQC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaQC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblQuangcao WHERE Maquangcao=N'" + txtMaQC.Text + "'";
                Functions.RunSqlDel(sql);
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
            txtMaQC.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
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