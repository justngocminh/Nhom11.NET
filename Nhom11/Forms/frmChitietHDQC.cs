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
    public partial class frmChitietHDQC : Form
    {
        DataTable table;
        public string MahopdongFromfrmHopdongquangcao;

        public frmChitietHDQC()
        {
            InitializeComponent();
        }
        public void ResetValues()
        {
            cboMaQC.Text = "";
            txtDongia.Text = "";
            txtThanhtien.Text = "";
            txtMaCTHD.Text = "";
            txtTenQC.Text = "";
            lblBangso.Text = Convert.ToString(Classes.Functions.GetFieldValues("SELECT Tongtien from Hopdongquangcao where Mahopdong =  N'" + MahopdongFromfrmHopdongquangcao + "'"));
            
            if (lblBangso.Text != "0")
            {
                decimal total = CalculateColumnTotal(DataGridViewCTHD, 6);
                lblBangso.Text = $"{total} đồng";
                lblBangchu.Text = $"{Functions.ConvertNumberToWords((long)total)} đồng";
            }
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
        private void frmChitietHDQC_Load(object sender, EventArgs e)
        {
            Load_DataGridViewCTHD();
            Functions.FillComboBox("select Maquangcao from tblQuangcao", cboMaQC, "Maquangcao", "Tenquangcao");
            cboMaQC.SelectedIndex = -1;
            txtDongia.Text = "0";
            txtThanhtien.Text = "0";
            lblBangso.Text = Convert.ToString(Classes.Functions.GetFieldValues("SELECT Tongtien from Hopdongquangcao where Mahopdong =  N'" + MahopdongFromfrmHopdongquangcao + "'"));
            if (lblBangso.Text != "0")
            {
                lblBangso.Text += " " + CalculateColumnTotal(DataGridViewCTHD, 6) + " đồng";
                lblBangchu.Text += " " + Classes.Functions.ConvertNumberToWords((long)CalculateColumnTotal(DataGridViewCTHD, 6)) + " đồng";
            }
            Load_DataGridViewCTHD();
            Functions.FillComboBox("select Maquangcao from tblQuangcao", cboMaQC, "Maquangcao", "Tenquangcao");
            cboMaQC.SelectedIndex = -1;
            ResetValues();
            txtMaCTHD.Enabled = false;
        }
        private void Load_DataGridViewCTHD()
        {
            string sql = "SELECT ctd.Machitiet, ctd.Maquangcao, qc.Noidung, hd.Ngaybatdau, hd.Ngayketthuc, qc.Dongia, qc.Dongia * DATEDIFF(day, hd.Ngaybatdau, hd.Ngayketthuc) AS Thanhtien " +
                         "FROM tblChitiethopdong ctd " +
                         "JOIN tblQuangcao qc ON ctd.Maquangcao = qc.Maquangcao " +
                         "JOIN tblHopdong hd ON ctd.Mahopdong = hd.Mahopdong " +
                         "WHERE ctd.Mahopdong = N'" + MahopdongFromfrmHopdongquangcao + "'";


            table = Functions.GetDataToTable(sql);
            DataGridViewCTHD.DataSource = table;
            DataGridViewCTHD.AllowUserToAddRows = false;
            DataGridViewCTHD.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewCTHD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DataGridViewCTHD.Columns[0].HeaderText = "Mã CTHD";
            DataGridViewCTHD.Columns[1].HeaderText = "Mã quảng cáo";
            DataGridViewCTHD.Columns[2].HeaderText = "Nội dung";
            DataGridViewCTHD.Columns[3].HeaderText = "Ngày bắt đầu";
            DataGridViewCTHD.Columns[4].HeaderText = "Ngày kết thúc";
            DataGridViewCTHD.Columns[5].HeaderText = "Đơn giá";
            DataGridViewCTHD.Columns[6].HeaderText = "Thành tiền";
            DataGridViewCTHD.Columns[0].Width = 120;
            DataGridViewCTHD.Columns[1].Width = 120;
            DataGridViewCTHD.Columns[2].Width = 120;
            DataGridViewCTHD.Columns[3].Width = 120;
            DataGridViewCTHD.Columns[4].Width = 120;
            DataGridViewCTHD.Columns[5].Width = 120;
            DataGridViewCTHD.Columns[6].Width = 120;
        }

        private void DataGridViewCTHD_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaQC.Focus();
                return;
            }

            if (DataGridViewCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DisplayData();
            btnBoqua.Enabled = true;
            btnLuu.Enabled = false;
        }
        private void DisplayData()
        {
            if (DataGridViewCTHD.CurrentRow == null) return;
                      
            txtMaCTHD.Text = DataGridViewCTHD.CurrentRow.Cells["Machitiet"].Value.ToString();
            txtThanhtien.Text = DataGridViewCTHD.CurrentRow.Cells["Thanhtien"].Value.ToString();

            string ma;
            ma = DataGridViewCTHD.CurrentRow.Cells["Maquangcao"].Value.ToString();
            cboMaQC.SelectedValue = ma;
            string tenQC = Functions.GetFieldValues("SELECT Tenquangcao FROM tblQuangcao WHERE Maquangcao = N'" + ma + "'");
            txtTenQC.Text = tenQC;
            string dongia = Functions.GetFieldValues("SELECT Dongia FROM tblQuangcao WHERE Maquangcao = N'" + ma + "'");
            txtDongia.Text = dongia;
        }

        private void cboMaQC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaQC.Text == "")
            {
                txtTenQC.Text = "";
            }
            else if (cboMaQC.Text != "" && cboMaQC.Text == "")
            {
                txtTenQC.Text = Classes.Functions.GetFieldValues("select Tenquangcao from tblQuangcao where Maquangcao ='" + cboMaQC.SelectedValue + "'");
                txtDongia.Text = "0";
            }
            else
            {
                txtTenQC.Text = Classes.Functions.GetFieldValues("select Tenquangcao from tblQuangcao where Maquangcao ='" + cboMaQC.SelectedValue + "'");
                txtDongia.Text = Classes.Functions.GetFieldValues("select Dongia from tblQuangcao where Maquangcao = '" + cboMaQC.SelectedValue + "' and Maquangcao = '" + cboMaQC.SelectedValue + "'");
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboMaQC.Text == "" && cboMaQC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "update tblchitiethopdong set Maquangcao = N'" + cboMaQC.SelectedValue.ToString() + "' where Machitiet = N'" + txtMaCTHD.Text + "'";
            
            Functions.RunSql(sql);
            Classes.Functions.RunSql(sql); //gọi phương thức Runsql từ Class Functions để thực hiện lệnh sql
            Load_DataGridViewCTHD(); //gọi phương thức load_data() để chạy lại dữ liệu
            ResetValues(); //gọi phương thức resetvalues() để làm mới giá trị trên form
            //btnCapnhat.Enabled = false; //vô hiệu hóa nút sửa
            //btnBoqua.Enabled = false; //vô hiệu hóa nút làm mới

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnBoqua.Enabled = true;
            btnDong.Enabled = true;
            cboMaQC.Enabled = true;
            ResetValues();
            txtMaCTHD.Enabled = true;
            Load_DataGridViewCTHD();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboMaQC.Text == "" && cboMaQC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //sql = "insert into tblchitiethopdong set Maquangcao = N'" + cboMaQC.SelectedValue.ToString() + "' where Machitiet = N'" + txtMaCTHD.Text + "'";




            sql = "INSERT INTO tblChitiethopdong(Mahopdong, Maquangcao, Machitiet) VALUES (N'" + MahopdongFromfrmHopdongquangcao + "', N'" + cboMaQC.SelectedValue.ToString() + "',N'" + txtMaCTHD.Text + "')";
            //Functions.RunSql(sql);

            ResetValues();
            Functions.RunSql(sql);
            Classes.Functions.RunSql(sql); //gọi phương thức Runsql từ Class Functions để thực hiện lệnh sql
            Load_DataGridViewCTHD(); //gọi phương thức load_data() để chạy lại dữ liệu
            ResetValues(); //gọi phương thức resetvalues() để làm mới giá trị trên form
        }

        private void DataGridViewCTHD_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ quảng cáo này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql;
                sql = "delete from chitietquangcao where machitiet = '" + txtMaCTHD.Text + "'";
                Classes.Functions.RunSqlDel(sql);
                Load_DataGridViewCTHD();
                ResetValues();
                btnBoqua.Enabled = false;
                btnCapnhat.Enabled = false;
            }
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
