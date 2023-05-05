using DoAnTracNghiem.DAO;
using DoAnTracNghiem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTracNghiem
{
    public partial class Home_page : Form
    {
        private Account loginthongtin;
        public Account Loginthongtin
        {
            get { return loginthongtin; }
            set { loginthongtin = value; }
            
        }
        public Home_page(Account acc,string group)
        {
            InitializeComponent();
            this.Loginthongtin = acc;
            load_thongtin();
            
            ChangeThongTin(group);
        }
      void ChangeThongTin(string group)
        {
            if (group == "Admin")
            {
                quantrivien.Enabled=true;
                taobode.Enabled = true;
            }
            else if (group == "Teacher")
            {
                quantrivien.Enabled = false;
                taobode.Enabled = true;
            }
            else
            {
                quantrivien.Enabled = false;
                taobode.Enabled = false;
            }
            
        }
        void load_thongtin()
        {
            lbTen.Text = loginthongtin.Name;
            lbNgaySinh.Text = loginthongtin.Ngaysinh;
        }
        private void thongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan(loginthongtin);
            f.Show();
        }
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void quảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanTriVien f = new QuanTriVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void NHDT_Click(object sender, EventArgs e)
        {
            ViewNganHangDe f = new ViewNganHangDe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        
        void loadcauhoi()
        {
            List<CauHoi> ListCauHoi = NganHangDeThiDAO.Instance.LoadCauHoiKiemTra();

            foreach (CauHoi item in ListCauHoi)
            {

                Label pen = new Label() { Width = 440 };
                pen.AutoSize = false;
                pen.Height = 2;
                pen.BorderStyle = BorderStyle.Fixed3D;
                Label stt = new Label() { Width = 20 };
                stt.Text = "" + item.Stt;
                Label noidungcauhoi = new Label();
                noidungcauhoi.Text = "Nội Dung Câu hỏi: " + item.Noidungcauhoi;
                Label a = new Label();
                a.Text = "Đáp Án A: " + item.A;
                Label b = new Label();
                b.Text = "Đáp Án B: " + item.B;
                Label c = new Label();
                c.Text = "Đáp Án C: " + item.C;
                Label d = new Label();
                d.Text = "Đáp Án D: " + item.D;
                QuizDe.Controls.Add(pen);
                QuizDe.Controls.Add(stt);
                QuizDe.Controls.Add(noidungcauhoi);
                QuizDe.Controls.Add(a);
                QuizDe.Controls.Add(b);
                QuizDe.Controls.Add(c);
                QuizDe.Controls.Add(d);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="De1")
            {
                loadcauhoi();
            }    
        }
    }
}
