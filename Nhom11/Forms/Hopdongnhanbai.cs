using Nhom11.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Nhom11.Forms
{
    public partial class Hopdongnhanbai : Form
    {
        DataTable table;
        public Hopdongnhanbai()
        {
            InitializeComponent();
        }

        public string ManhanbaiFromNhanBai;

        private void Hopdongnhanbai_Load(object sender, EventArgs e)
        {
            txtNhanbai.Text = ManhanbaiFromNhanBai;
            txtNhuanbut.Text = Functions.GetFieldValues("SELECT Nhuanbut FROM tblNhanbai WHERE MaNhanBai = N'" + txtNhanbai.Text + "'");
            txtMaNV.Text = Functions.GetFieldValues("SELECT Manhanvien FROM tblNhanbai WHERE MaNhanBai = N'" + txtNhanbai.Text + "'");
            txtMabaibao.Text = Functions.GetFieldValues("SELECT Mabaibao FROM tblNhanbai WHERE MaNhanBai = N'" + txtNhanbai.Text + "'");
            txtMatacgia.Text = Functions.GetFieldValues("SELECT Matacgia FROM tblNhanbai WHERE MaNhanBai = N'" + txtNhanbai.Text + "'");
            txtNgay.Text = Functions.GetFieldValues("SELECT Ngaynhanbai FROM tblNhanbai WHERE MaNhanBai = N'" + txtNhanbai.Text + "'");
            txtNV.Text = Functions.GetFieldValues("SELECT Tennhanvien FROM tblNhanvien WHERE Manhanvien = N'" + txtMaNV.Text + "'");
            txtTacgia.Text = Functions.GetFieldValues("SELECT Tentacgia FROM tblTacgia WHERE Matacgia = N'" + txtMatacgia.Text + "'");
            txtBaibao.Text = Functions.GetFieldValues("SELECT Tieude FROM tblBaibao WHERE Mabaibao = N'" + txtMabaibao.Text + "'");
            txtNhanbai.Enabled = false;
            txtBaibao.Enabled = false;
            txtNhuanbut.Enabled = false;
            txtMabaibao.Enabled = false;
            txtMatacgia.Enabled = false;
            txtMaNV.Enabled = false;
            txtNgay.Enabled = false;
            txtTacgia.Enabled = false;
            txtNV.Enabled = false;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // Tạo tài liệu PDF mới
            Document document = new Document(PageSize.A4);
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);

            document.Open();

            // Định nghĩa font
            string fontPath = @"C:\Users\giaba\source\repos\Nhom11.NET\Nhom11\Font\ARIALUNI.TTF"; //Điền lại đường dẫn font trong mục Font 
            BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 13);

            // Thêm tiêu đề vào tài liệu PDF
            Paragraph title = new Paragraph("HỢP ĐỒNG NHẬN BÀI", fontTitle);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 70; // Khoảng cách sau tiêu đề
            document.Add(title);

            // Thêm các thông tin vào tài liệu PDF, mỗi thông tin là một dòng
            AddInfoParagraph(document, "Mã nhận bài: " + txtNhanbai.Text, font);
            AddInfoParagraph(document, "Mã tác giả: " + txtMatacgia.Text, font);
            AddInfoParagraph(document, "Tên tác giả: " + txtTacgia.Text, font);
            AddInfoParagraph(document, "Mã nhân viên: " + txtMaNV.Text, font);
            AddInfoParagraph(document, "Tên nhân viên: " + txtNV.Text, font);
            AddInfoParagraph(document, "Mã bài báo: " + txtMabaibao.Text, font);
            AddInfoParagraph(document, "Tên bài báo: " + txtBaibao.Text, font);
            AddInfoParagraph(document, "Nhuận bút: " + txtNhuanbut.Text, font);
            AddInfoParagraph(document, "Ngày nhận bài: " + txtNgay.Text, font);                      

            // Thêm chữ ký nhân viên và tác giả
            Paragraph chuKyNhanVien = new Paragraph("Chữ ký nhân viên: ___________________", font);
            Paragraph chuKyTacGia = new Paragraph("Chữ ký tác giả: ___________________", font);
            chuKyNhanVien.SpacingBefore = 100;
            chuKyTacGia.SpacingBefore = 100;
            chuKyNhanVien.IndentationLeft = 130;
            chuKyTacGia.IndentationLeft = 140;
            document.Add(chuKyNhanVien);
            document.Add(chuKyTacGia);

            document.Close();

            // Lưu tài liệu PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Lưu file PDF";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, memoryStream.ToArray());
                MessageBox.Show("Xuất file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddInfoParagraph(Document document, string text, iTextSharp.text.Font font)
        {
            Paragraph paragraph = new Paragraph(text, font);
            paragraph.SpacingAfter = 15; // Khoảng cách sau đoạn
            paragraph.IndentationLeft = 20; // Lùi đầu dòng
            document.Add(paragraph);
        }
    }
    }
