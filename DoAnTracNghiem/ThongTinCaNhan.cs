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
    public partial class ThongTinCaNhan : Form
    {
        private Account loginthongtin;

        public Account Loginthongtin
        {
            get { return loginthongtin; }
            set { loginthongtin = value; ChangeThongTin(loginthongtin); }

        }
        public ThongTinCaNhan(Account acc)
        {
            InitializeComponent();
            loginthongtin = acc;
            ChangeThongTin(acc);
        }
        void ChangeThongTin(Account acc)
        {
            tnd.Text = acc.Name;
            email.Text = acc.Email;
        }
        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }

        private void ttcnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void updateAccount()
        {
            string name = tnd.Text;
            string password = ttcnMatKhauCu.Text;
        }
        private void ttcncapnhat_Click(object sender, EventArgs e)
        {

        }
    }
}
