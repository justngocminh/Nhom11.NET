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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Nhom11.Forms
{
    public partial class frmHopdongquangcao : Form
    {
        DataTable table;
        public frmHopdongquangcao()
        {
            InitializeComponent();
        }

        private void frmHopdongquangcao_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            cboTimHD.DropDownStyle = ComboBoxStyle.DropDownList;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = true;

            txtMaHD.ReadOnly = true;
            mskNgayKK.Enabled = false;
            mskNgayBD.Enabled = false;
            mskNgayKT.Enabled = false;
            cboMaNV.Enabled = false;
            txtTenNV.ReadOnly = true;
            cboMaKH.Enabled = false;
            txtTenKH.ReadOnly = true;
            txtDienthoai.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtEmail.ReadOnly = true;
            cboMaBB.Enabled = false;
            txtTenBB.ReadOnly = true;
            txtTongtien.ReadOnly = true;

            Functions.FillComboBox("select Manhanvien from tblNhanvien", cboMaNV, "Manhanvien", "Tennhanvien");
            cboMaNV.SelectedIndex = -1;
            Functions.FillComboBox("select Makhachhang from tblKhachhang", cboMaKH, "Makhachhang", "Tenkhachhang");
            cboMaKH.SelectedIndex = -1;
            Functions.FillComboBox("select Mahopdong from tblHopdong", cboTimHD, "Mahopdong", "Ngaykyket");
            cboTimHD.SelectedIndex = -1;
            Functions.FillComboBox("select Mabaibao from tblHopdong", cboMaBB, "Mabaibao", "Tieude");
            cboMaBB.SelectedIndex = -1;

            Load_DataGridViewHD();
        }
        private void Load_DataGridViewHD()
        {
            string sql;
            if (cboTimHD.Text == "")
            {
                sql = "select * from Hopdong";
            }
            else
            {
                sql = "select * from Hopdong where Mahopdong = N'" + cboTimHD.Text + "'";
            }
            //sql = "select * from Hopdongquangcao";
            table = Functions.GetDataToTable(sql);
            DataGridViewHD.DataSource = table;
            DataGridViewHD.AllowUserToAddRows = false;
            DataGridViewHD.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewHD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DataGridViewHD.Columns[0].HeaderText = "Mã hợp đồng";
            DataGridViewHD.Columns[1].HeaderText = "Mã bài báo";
            DataGridViewHD.Columns[2].HeaderText = "Ngày ký kết";
            DataGridViewHD.Columns[3].HeaderText = "Mã nhân viên";
            DataGridViewHD.Columns[4].HeaderText = "Mã khách hàng";
            DataGridViewHD.Columns[5].HeaderText = "Tổng tiền";

            DataGridViewHD.Columns[0].Width = 120;
            DataGridViewHD.Columns[1].Width = 120;
            DataGridViewHD.Columns[2].Width = 120;
            DataGridViewHD.Columns[3].Width = 120;
            DataGridViewHD.Columns[4].Width = 120;
            DataGridViewHD.Columns[5].Width = 120;
        }
        private void DisplayData()
        {
            if (DataGridViewHD.CurrentRow == null) return;

            mskNgayKK.Text = DataGridViewHD.CurrentRow.Cells["Ngaykyket"].Value.ToString();

            txtTongtien.Text = DataGridViewHD.CurrentRow.Cells["Tongtien"].Value.ToString();

            txtMaHD.Text = DataGridViewHD.CurrentRow.Cells["Mahopdong"].Value.ToString();

            string ma;
            ma = DataGridViewHD.CurrentRow.Cells["Mabaibao"].Value.ToString();
            cboMaBB.SelectedValue = ma;
            string tenBB = Functions.GetFieldValues("SELECT Tieude FROM tblBaibao WHERE Mabaibao = N'" + ma + "'");
            txtTenBB.Text = tenBB;

        }

        private void DataGridViewHD_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHD.Focus();
                return;
            }

            if (DataGridViewHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DisplayData();
            btnBoqua.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void DataGridViewHD_DoubleClick(object sender, EventArgs e)
        {          

            if (DataGridViewHD.CurrentRow != null)
            {
                string Mahopdong = DataGridViewHD.CurrentRow.Cells["Mahopdong"].Value.ToString();
                frmChitietHDQC frm = new frmChitietHDQC();
                frm.MahopdongFromfrmHopdongquangcao = Mahopdong;
                frm.Show();
            }
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (txtMaHD.Text == "")
            {
                mskNgayKK.Text = "";
                mskNgayBD.Text = "";
                mskNgayKT.Text = "";
                cboMaKH.Text = "";
                cboMaNV.Text = "";
                cboMaBB.Text = "";
                txtTongtien.Text = "";
                ResetValues();
                return;
            }
            str = "select Ngaykyket from tblHopdong where Mahopdong = N'" + txtMaHD.Text + "'";
            mskNgayKK.Text = Functions.GetFieldValues(str);
            str = "select Ngaybatdau from tblHopdong where Mahopdong = N'" + txtMaHD.Text + "'";
            mskNgayBD.Text = Functions.GetFieldValues(str);
            str = "select Ngayketthuc from tblHopdong where Mahopdong = N'" + txtMaHD.Text + "'";
            mskNgayKT.Text = Functions.GetFieldValues(str);
            str = "select Makhachhang from tblHopdong where Mahopdong = N'" + txtMaHD.Text + "'";
            cboMaKH.Text = Functions.GetFieldValues(str);
            str = "select Manhanvien from tblHopdong where Mahopdong = N'" + txtMaHD.Text + "'";
            cboMaNV.Text = Functions.GetFieldValues(str);
            str = "select Mabaibao from tblHopdong where Mahopdong = N'" + txtMaHD.Text + "'";
            cboMaBB.Text = Functions.GetFieldValues(str);
            str = "select Tongtien from Hopdong where Mahopdong = N'" + txtMaHD.Text + "'";
            txtTongtien.Text = Functions.GetFieldValues(str);
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
            {
                txtTenNV.Text = "";
            }
            str = "select Tennhanvien from tblNhanvien where Manhanvien = N'" + cboMaNV.Text + "'";
            txtTenNV.Text = Functions.GetFieldValues(str);
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaKH.Text == "")
            {
                txtTenKH.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
                txtEmail.Text = "";
            }
            str = "select Tenkhachhang from tblKhachhang where Makhachhang = N'" + cboMaKH.Text + "'";
            txtTenKH.Text = Functions.GetFieldValues(str);
            str = "select Diachi from tblKhachhang where Makhachhang = N'" + cboMaKH.Text + "'";
            txtDiachi.Text = Functions.GetFieldValues(str);
            str = "select Dienthoai from tblKhachhang where Makhachhang = N'" + cboMaKH.Text + "'";
            txtDienthoai.Text = Functions.GetFieldValues(str);
            str = "select Email from tblKhachhang where Makhachhang = N'" + cboMaKH.Text + "'";
            txtEmail.Text = Functions.GetFieldValues(str);
        }
        private void ResetValues()
        {
            txtMaHD.Text = "";
            mskNgayKK.Text = "";
            cboMaKH.Text = null;
            cboMaNV.Text = null;
            cboMaBB.Text = null;
            txtTenBB.Text = "";
            txtTenKH.Text = "";
            txtTenNV.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtEmail.Text = "";
            txtTongtien.Text = "";
            Load_DataGridViewHD();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnTimHD_Click(object sender, EventArgs e)
        {
            if (cboTimHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một Mã hợp đồng để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTimHD.Focus();
                return;
            }
            txtMaHD.Text = cboTimHD.Text;
            Load_DataGridViewHD();
            btnBoqua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            cboTimHD.SelectedIndex = -1;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn thoát ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnDong.Enabled = true;
            mskNgayKK.Enabled = true;
            cboMaKH.Enabled = true;
            cboMaNV.Enabled = true;
            cboMaBB.Enabled = true;
            cboMaKH.Enabled = true;
            mskNgayBD.Enabled = true;
            mskNgayKT.Enabled = true;
            mskNgayKK.Enabled = true; 
            txtTongtien.Enabled = true;
            ResetValues();
            txtMaHD.Text = Functions.CreateKey("HD");
            Load_DataGridViewHD();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (mskNgayKK.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayKK.Focus();
                return;
            }
            if (!Classes.Functions.Isdate(mskNgayKK.Text))
            {
                MessageBox.Show("Sai định dạng ngày ký, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayKK.Focus();
                mskNgayKK.Text = "";
                return;
            }
            if (cboMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }
            if (cboMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaKH.Focus();
                return;
            }

          
            sql = "INSERT INTO tblHopdong(Mahopdong, Ngaykyket, Manhanvien, Makhachhang, Mabaibao, Ngaybatdau, Ngayketthuc) " +
                  "VALUES (N'" + txtMaHD.Text + "', N'" + Classes.Functions.ConvertDateTime(mskNgayKK.Text) + "', N'" + cboMaNV.SelectedValue.ToString() + "', N'" + cboMaKH.SelectedValue.ToString() + "', N'" + cboMaBB.SelectedValue.ToString() + "','" + Classes.Functions.ConvertDateTime(mskNgayBD.Text) + "','" + Classes.Functions.ConvertDateTime(mskNgayKT.Text) + "')";
            Functions.RunSql(sql);
            /*Load_DataGridViewHD(); //gọi phương thức load_data() để chạy lại dữ liệu*/
            ResetValues(); //gọi phương thức resetvalues() để làm mới giá trị trên form
            btnLuu.Enabled = false; //vô hiệu hóa nút lưu
            btnThem.Enabled = true; //kích hoạt nút thêm hợp đồng viết bài
            btnBoqua.Enabled = false; //vô hiệu hóa nút làm mới


        }

        private void cboMaBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaBB.Text == "")
            {
                txtTenBB.Text = "";
            }
            str = "select Tieude from tblBaibao where Mabaibao = N'" + cboMaBB.Text + "'";
            txtTenBB.Text = Functions.GetFieldValues(str);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (mskNgayKK.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayKK.Focus();
                return;
            }
            if (!Classes.Functions.Isdate(mskNgayKK.Text))
            {
                MessageBox.Show("Sai định dạng ngày ký, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayKK.Focus();
                mskNgayKK.Text = "";
                return;
            }
            if (cboMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }
            if (cboMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaKH.Focus();
                return;
            }
            if (cboMaBB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã bài báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBB.Focus();
                return;
            }
                 
            sql = "update tblHopdong set Manhanvien = N'" + cboMaNV.SelectedValue.ToString() + "', Makhachhang  = N'" + cboMaKH.SelectedValue.ToString() +
                "', Ngaykyket ='" + Classes.Functions.ConvertDateTime(mskNgayKK.Text) + "', Ngaybatdau ='" + Classes.Functions.ConvertDateTime(mskNgayBD.Text) +
                "', Ngayketthuc ='" + Classes.Functions.ConvertDateTime(mskNgayKT.Text) + "', Mabaibao ='" + cboMaBB.SelectedValue.ToString() + "' where Mahopdong = N'" + txtMaHD.Text + "'";
            Functions.RunSql(sql);
            /*Load_DataGridViewHD(); //gọi phương thức load_data() để chạy lại dữ liệu*/
            ResetValues(); //gọi phương thức resetvalues() để làm mới giá trị trên form
            btnSua.Enabled = false; //vô hiệu hóa nút sửa
            btnXoa.Enabled = false; //vô hiệu hóa nút hủy
            btnBoqua.Enabled = false; //vô hiệu hóa nút làm mới

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hợp đồng " + txtMaHD.Text + " khỏi bảng?", "Thông báo",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "DELETE FROM tblHopdong WHERE Mahopdong = N'" + txtMaHD.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridViewHD();
                ResetValues();
                //btnSua.Enabled = false;
                //btnXoa.Enabled = false;
            }
        }
    }
}



