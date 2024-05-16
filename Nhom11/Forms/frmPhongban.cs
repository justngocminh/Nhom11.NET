using System;
using System.Data;
using System.Windows.Forms;

namespace Nhom11.Forms
{
    public partial class frmPhongban : Form
    {
        DataTable table;
        public frmPhongban()
        {
            InitializeComponent();
        }
        private void frmPhongban_Load(object sender, EventArgs e)
        {
            txtMaphongban.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from tblPhongban";
            table = Classes.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = table;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns[0].HeaderText = "Mã phòng ban";
            dataGridView1.Columns[1].HeaderText = "Tên phòng ban";
            dataGridView1.Columns[2].HeaderText = "Số điện thoại";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            //dataGridView1.Columns[2].Width = 150;
            //dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaphongban.Enabled = true;
            txtMaphongban.Focus();
        }
        private void ResetValues()
        {
            txtMaphongban.Text = "";
            txtTenphongban.Text = "";
            txtDienthoai.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaphongban.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenphongban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDienthoai.Text.Length != txtDienthoai.Mask.Length)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaphongban.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã phong ban không được vượt quá 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaphongban.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên phòng ban không được vượt quá 50 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string phonenum = txtDienthoai.Text.Trim();
            phonenum = phonenum.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            sql = "update tblPhongban set Tenphongban = N'" + txtTenphongban.Text.Trim().ToString() + "', Dienthoai = N'" + phonenum + "'where Maphongban = N'" + txtMaphongban.Text + "'";
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
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
                return;
            }
            if (txtMaphongban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy chọn một bản ghi!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblPhongban where Maphongban = N'" + txtMaphongban.Text + "'";
                Classes.Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaphongban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập mã phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaphongban.Focus();
                return;
            }
            if (txtTenphongban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập tên phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenphongban.Focus();
                return;
            }
            if (txtDienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienthoai.Focus();
                return;
            }
            sql = "select Maphongban from tblPhongban where Maphongban = N'" + txtMaphongban.Text.Trim() + "'";
            if (Classes.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã phòng ban này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaphongban.Focus();
                txtMaphongban.Text = "";
                return;
            }
            if (txtMaphongban.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã phong ban không được vượt quá 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaphongban.Focus();
                txtMaphongban.Text = "";
                return;
            }
            if (txtMaphongban.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên phòng ban không được vượt quá 50 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenphongban.Focus();
                txtTenphongban.Text = "";
                return;
            }
            string phonenum = txtDienthoai.Text.Trim();
            phonenum = phonenum.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            sql = "insert into tblPhongban (Maphongban, Tenphongban, Dienthoai) values (N'" + txtMaphongban.Text.Trim() + "', N'" + txtTenphongban.Text.Trim() + "',  N'" + phonenum + "')";
            Classes.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaphongban.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = false;
            txtMaphongban.Enabled = false;
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaphongban.Focus();
                return;
            }
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtMaphongban.Text = dataGridView1.CurrentRow.Cells["Maphongban"].Value.ToString();
            txtTenphongban.Text = dataGridView1.CurrentRow.Cells["Tenphongban"].Value.ToString();
            txtDienthoai.Text = dataGridView1.CurrentRow.Cells["Dienthoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
