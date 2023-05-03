using DoAnTracNghiem.DAO;
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
        public Home_page()
        {
            InitializeComponent();
            load_tt();
        }
        private void load_tt()
        {

           
        }
        private void Home_page_Load(object sender, EventArgs e)
        {

        }

        private void thongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan();
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
