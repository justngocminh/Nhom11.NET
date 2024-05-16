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
    }
}
