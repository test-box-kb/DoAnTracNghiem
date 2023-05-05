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
            string password = MaHoa.Instance.HashCodeEnCryp(ttcnMatKhauCu.Text);
            string newpassword = ttcnMatKhauMoi.Text;
            string confirmpassword = ttcnNhapLaiMatKhau.Text;
            string email = loginthongtin.Email;
            if(!confirmpassword.Equals(newpassword))
            {
                label6.Text = "mat khau moi khong trung khop";
                label6.ForeColor = Color.Red;
            }else  
            if (AccountDAO.Instance.UpdateAccount(email, name, password, MaHoa.Instance.HashCodeEnCryp(newpassword)))
                {
                    label6.Text = "cap nhat thanh cong";
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.Text = "vui long dien dung mat khau";
                label6.ForeColor = Color.Red;
            }
        }
        private void ttcncapnhat_Click(object sender, EventArgs e)
        {
            updateAccount();
        }
    }
}
