using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using DoAnTracNghiem.DTO;
using DoAnTracNghiem.DAO;

namespace DoAnTracNghiem
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            
        }



        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked) rgpass.PasswordChar = '\0';
            else rgpass.PasswordChar = '*';
        }

        private void rgcancel_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
        private string hashstring(string mess, string algo)
        {
            string hashcode = "";
            byte[] x_message_data = Encoding.Default.GetBytes(mess);
            HashAlgorithm x_hash_alg = HashAlgorithm.Create(algo);
            byte[] x_hash_code = x_hash_alg.ComputeHash(x_message_data);
            hashcode = BitConverter.ToString(x_hash_code);
            return hashcode;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string hoten = rguser.Text;
            string pass = rgpass.Text;
            string email = rgemail.Text;
            string date = rgdob.Text;
            string ChucVu = cbposition.Text;
           
            string hashcode = hashstring(pass, "SHA512");
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.connectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            cmd.Connection = conn;
            cmd2.Connection = conn;

            string sql = "Select email from users where email = '" + email + "'";
            cmd.CommandText = sql;
           // string eemail = rgemail.Text;

            Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                rp.Text = "email da dang ky. xin nhap email khac";
                rp.ForeColor = Color.Red;
            }
            else if(rgpass.Text==cfpass.Text&&expr.IsMatch(email))
            {
                conn.Close();
                conn.Open();
                sql = "insert into Users (name,password,email,ngaysinh,ChucVu) values " + "(N'" + hoten + "',N'" + hashcode + "',N'" + email + "',N'"+ date + "',N'" + ChucVu + "')";
                cmd2.Connection = conn;
                cmd2.CommandText = sql;
                cmd2.ExecuteNonQuery();
                rguser.Text = "";
                rgpass.Text = "";
                rgemail.Text = "";
                rgdob.Text = "";
                rp.Text = "username da dang ky thanh cong";
                rp.ForeColor = Color.Red;
            }else
            {
                rp.Text = "sai thong tin dang ky";
                rp.ForeColor = Color.Red;
            }
            conn.Close();
            conn.Dispose();
            conn = null;
        }
       
    }
}
