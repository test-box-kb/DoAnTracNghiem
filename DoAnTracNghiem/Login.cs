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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            register l = new register();
            this.Hide();
            l.ShowDialog();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                e.Cancel = true;
                
            }
        }

        private void tuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string email = tuser.Text;
            string password = tpass.Text;
            if (login(email, password))
            {
                Home_page f = new Home_page();
                this.Hide();
                f.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Sai email hoặc mật khẩu!");
            }
        }
        private bool login(string email, string password)
        {
          
            return AccountDAO.Instance.login(email,password);
        }
    }
}
