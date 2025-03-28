using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_Vidu
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDirectoryExists_Click(object sender, EventArgs e)
        {
            // Có thêm thư viện System.IO
            string duongdan = @"C:\Windows\Boot\DVD";
            if (Directory.Exists(duongdan) == true)
                MessageBox.Show("Đường dẫn: " + duongdan + " tồn tại", "Test Directory Exists");
            else
                MessageBox.Show("Đường dẫn: " + duongdan + " không tồn tại", "Test Directory Exists");
        }

        private void btnDirectoryGetFiles_Click(object sender, EventArgs e)
        {
            // Phương thức này sẽ trả về mảng chuỗi các phần tử là đường dẫn đến tập tin trong Folder
            // string duong_dan_hinh = @"..\..\danhsachhinh\";
            string duong_dan_hinh = @"E:\danhsachhinh\";
            string[] danh_sach_duong_dan = Directory.GetFiles(duong_dan_hinh, "*.jpg");
            foreach (string duong_dan in danh_sach_duong_dan)
                MessageBox.Show(duong_dan);
        }
    }
}
