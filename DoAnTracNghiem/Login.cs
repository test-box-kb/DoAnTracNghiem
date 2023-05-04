using DoAnTracNghiem.DAO;
using DoAnTracNghiem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            string pass = tpass.Text;
            string password = "kieubao";
            byte[] iv = new byte[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            SHA256 sHA256 = SHA256Managed.Create();
            byte[] key = sHA256.ComputeHash(Encoding.ASCII.GetBytes(password));
            string hashcode = MaHoa.Instance.hashstring(pass, "SHA512");
            MaHoa.Instance.hashstring(password, "SHA512");
            string encrypted = MaHoa.Instance.EncryptString(hashcode, key, iv);
            hashcode = encrypted;
            
            if (login(email, hashcode ))
            {
                Account loginthongtin = AccountDAO.Instance.GetThongTinByUserName(email);
                Home_page f = new Home_page(loginthongtin, connectgroup(email, hashcode));
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
        string connectgroup (string email , string hashcode)
        {
            string connectionSTR = "Data Source = .\\sqlexpress; Initial Catalog = TracNghiem; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionSTR);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@email", email));
            cmd.Parameters.Add(new SqlParameter("@hashcode", hashcode));
            string sql = "select ChucVu from users where email = @email and password = @hashcode";
            cmd.CommandText = sql;
            var reader = cmd.ExecuteReader();
           
            string group = "";
            int c = 0;
            while (reader.Read())
            {
                group = reader[0].ToString();
                c++;
            }
            return group.Trim();
        }
    }
}
