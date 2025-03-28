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
        List<KHOA> KHOAs = new List<KHOA>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc_khoa();
            Khoi_Tao_listbox();
        }

        private void Khoi_Tao_listbox()
        {
            lstKhoa.ValueMember = "MaKH";
            lstKhoa.DisplayMember = "TenKH";
            lstKhoa.DataSource = KHOAs;
        }

        private void doc_khoa()
        {
            string duong_dan = @"..\..\DULIEU\KHOA.txt";
            string[] mang_dong = File.ReadAllLines(duong_dan);
            KHOAs.Clear();
            foreach (string chuoi_khoa in mang_dong)
            {
                string[] mang_thanh_phan = chuoi_khoa.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                KHOA kh = new KHOA();
                kh.MaKH = mang_thanh_phan[0];
                kh.TenKH = mang_thanh_phan[1];
                KHOAs.Add(kh);
            }    
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

        private void btnDirectoryInfoExists_Click(object sender, EventArgs e)
        {
            DirectoryInfo Myfolder = new DirectoryInfo(@"C:\Windows\Boot\DVD");
            if (Myfolder.Exists == true)
                MessageBox.Show("Đường dẫn Myfolder tồn tại");
            else
                MessageBox.Show("Đường dẫn Myfolder không tồn tại");
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string Chuoi = "A01:Thạch Hiền:Giáo viên:Khoa CNTT";
            string[] Chuoi_thanh_phan = Chuoi.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
