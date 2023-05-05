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
        public Home_page(Account acc, string group)
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
                quantrivien.Enabled = true;
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
            List<TraLoiCauHoi> ListCauHoi = NganHangDeThiDAO.Instance.LoadCauHoiKiemTra();


            foreach (TraLoiCauHoi item in ListCauHoi)
            {

                Label pen = new Label() { Width = 440 };
                pen.AutoSize = false;
                pen.Height = 2;
                pen.BorderStyle = BorderStyle.Fixed3D;
                Label stt = new Label() { Width = 20 };
                stt.Text = "" + item.Stt;
                Label noidungcauhoi = new Label();
                noidungcauhoi.Text = "Nội Dung Câu hỏi: " + item.Noidungcauhoi;
                Label a = new Label() { Width = 440 };
                a.Text = "Đáp Án A: " + item.A;
                Label b = new Label() { Width = 440 };
                b.Text = "Đáp Án B: " + item.B;
                Label c = new Label() { Width = 440 };
                c.Text = "Đáp Án C: " + item.C;
                Label d = new Label() { Width = 440 };
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
            if (comboBox1.Text == "De1")
            {
                loadcauhoi();
            }
        }
        List<TraLoiCauHoi> ListCauHoikho = NganHangDeThiDAO.Instance.LoadCauHoiKiemTra();
        private void check_cauhoi()
        {
            
            int stt = Int32.Parse(tbstt.Text) - 1;
            if (stt > 0 && stt <= 10)
            {
                TraLoiCauHoi hientai = ListCauHoikho[stt-1];
                if (radioButton1.Checked == true)
                {
                    if (hientai.A == hientai.Answer)
                        hientai.Dachon = true;

                }
                else if (radioButton2.Checked == true)
                {
                    if (hientai.B == hientai.Answer)
                        hientai.Dachon = true;

                }
                else if (radioButton3.Checked == true)
                {
                    if (hientai.C == hientai.Answer)
                        hientai.Dachon = true;

                }
                else if (radioButton4.Checked == true)
                {
                    if (hientai.D == hientai.Answer)
                        hientai.Dachon = true;
                }
            }
        }
        private double check_diem()
        {
            double diem = 0;
            foreach(TraLoiCauHoi item in ListCauHoikho)
            {
                if (item.Dachon)
                    diem++;
            }
            return diem;
        }

        private void chondapan_Click(object sender, EventArgs e)
        {
            check_cauhoi();
            MessageBox.Show("Chon Dap An Thanh Cong");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = check_diem().ToString();
           label10.Text = check_diem().ToString();
        }
    }
}
