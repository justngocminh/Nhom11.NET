using Nhom11.Forms;
using System;
using System.Windows.Forms;

namespace Nhom11
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
    }
}
