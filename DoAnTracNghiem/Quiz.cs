using DoAnTracNghiem.DAO;
using DoAnTracNghiem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private void Home_page_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NHDT_Click(object sender, EventArgs e)
        {
            ViewNganHangDe f = new ViewNganHangDe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
