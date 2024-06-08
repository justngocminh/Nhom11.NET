using Nhom11.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nhom11
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Size = new Size(816, 489);
            MinimumSize = new Size(816, 489);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Classes.Functions.Connect();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongban form = new frmPhongban();
            form.Show();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaocaodoanhthu form = new frmBaocaodoanhthu();
            form.Show();
        }

        private void hóaĐơnNhậnBàiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.frmNhanBai f = new Forms.frmNhanBai();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
        private void báoCáoLợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaocaoloinhuan form = new frmBaocaoloinhuan();
            form.Show();
        }

        private void bàiQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachhang form = new frmKhachhang();
            form.Show();
        }

        private void quảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuangcao form = new frmQuangcao();
            form.Show();
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien form = new frmNhanvien();
            form.Show();
        }
        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacgia form = new frmTacgia();
            form.Show();
        }

        private void hóaĐơnNhậnBàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaibao form = new frmBaibao();
            form.Show();
        }

        // Ngắt kết nối đến cơ sỏ dữ liệu khi form đ
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Classes.Functions.Close();
        }

        private void hợpĐồngQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHopdongquangcao form = new frmHopdongquangcao();
            form.Show();  
        }
    }
}
