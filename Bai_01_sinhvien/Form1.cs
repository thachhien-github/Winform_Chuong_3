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

namespace Bai_01_sinhvien
{
    public partial class Form1: Form
    {
        List<SINHVIEN> SINHVIENs = new List<SINHVIEN>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc_du_lieu();
            Khoitaolistbox();
        }

        private void Khoitaolistbox()
        {
            lstSV.DataSource = null;
            lstSV.ValueMember = "MaSV";
            lstSV.DisplayMember = "HoTen";
            lstSV.DataSource = SINHVIENs;
        }

        private void doc_du_lieu()
        {
            string duong_dan = @"..\..\DULIEU\SINHVIEN.txt";
            string[] mang_dong = File.ReadAllLines(duong_dan);
            SINHVIENs.Clear();
                foreach (string chuoi_khoa in mang_dong)
                {
                    string[] mang_thanh_phan = chuoi_khoa.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                        SINHVIEN sv = new SINHVIEN();
                        sv.MaSV = int.Parse(mang_thanh_phan[0]);
                        sv.HoTen = mang_thanh_phan[1];
                        sv.HocBong = int.Parse(mang_thanh_phan[2]);
                        SINHVIENs.Add(sv);
                }
        }

        private void lstSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSV.SelectedIndex == -1) return;
            //lấy thông tin được chọn trong listbox
            SINHVIEN sv = lstSV.SelectedItem as SINHVIEN;
            gandulieu(sv);
        }

        private void gandulieu(SINHVIEN sv)
        {
            txtMaSV.Text = sv.MaSV.ToString();
            txtHoTen.Text = sv.HoTen;
            txtHocBong.Text = sv.HocBong.ToString("#,##0 đ");
        }
    }
}
