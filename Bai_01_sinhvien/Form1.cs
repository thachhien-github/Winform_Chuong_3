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
                foreach (string chuoi_sv in mang_dong)
                {
                    string[] mang_thanh_phan = chuoi_sv.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
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

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtHocBong.Clear();
            txtMaSV.ReadOnly = false;
            txtMaSV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaSV.ReadOnly == false) //thêm mới
            {
                //tạo đôi tượng kiểu sinh viên
                SINHVIEN sv = new SINHVIEN();
                sv.MaSV = int.Parse(txtMaSV.Text);
                sv.HoTen = txtHoTen.Text;
                sv.HocBong = int.Parse(txtHocBong.Text);
                //thêm đối tượng
                SINHVIENs.Add(sv);
                Khoitaolistbox();
                //quy định lại dòng được chọn
                lstSV.SelectedIndex = lstSV.Items.IndexOf(sv);
                txtMaSV.ReadOnly = true;

            }    
            else //sau khi sửa
            {
                SINHVIEN sv_sua = tim_sinhvien(int.Parse(txtMaSV.Text));
                sv_sua.MaSV = int.Parse(txtMaSV.Text);
                sv_sua.HoTen = txtHoTen.Text;
                sv_sua.HocBong = int.Parse(txtHocBong.Text.Replace(",", "").Replace("đ", ""));
                Khoitaolistbox();

            }    
        }

        private SINHVIEN tim_sinhvien(int msv)
        {
            SINHVIEN kq = null;
            foreach (SINHVIEN sv in SINHVIENs)
            {
                if (sv.MaSV == msv)
                    return sv;
            }
            return kq;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSV.SelectedIndex == -1) return;

            DialogResult tl = MessageBox.Show("Bạn có muốn xoá sinh viên: " + txtHoTen.Text + " không (Y/N)?", "Xóa sinh viên",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (tl == DialogResult.Yes)
            {
                SINHVIEN sv_xoa = tim_sinhvien(int.Parse(txtMaSV.Text));
                SINHVIENs.Remove(sv_xoa);
                Khoitaolistbox();
            }

            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ghi_file();
        }

        private void ghi_file()
        {
            string duong_dan = @"..\..\DULIEU\SINHVIEN.txt";
            List<string> danh_sach_chuoi_sv = new List<string>();
            foreach(SINHVIEN sv in SINHVIENs)
            {
                string chuoi_sv = sv.MaSV.ToString() + ":" + sv.HoTen + ":" + sv.HocBong.ToString();
                danh_sach_chuoi_sv.Add(chuoi_sv);
            }    
            File.WriteAllLines(duong_dan, danh_sach_chuoi_sv);
            MessageBox.Show("Ghi tệp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
