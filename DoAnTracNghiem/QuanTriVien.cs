using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAnTracNghiem.DAO;
using DoAnTracNghiem.DTO;

namespace DoAnTracNghiem
{
    public partial class QuanTriVien : Form
    {
        private Account loginthongtin;

        public Account Loginthongtin
        {
            get { return loginthongtin; }
            set { loginthongtin = value; }

        }
        public QuanTriVien()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {      
            string qery = "SELECT * FROM dbo.Users";
            dtgvAccount.DataSource =    DataProvider.Instance.ExecuteQuery(qery);
        }    
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void XemDanhSachGiangVien_Click(object sender, EventArgs e)
        {
            
            string qery = "SELECT * FROM dbo.Users where Chucvu = 'Teacher'";
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(qery);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string qery = "SELECT * FROM dbo.Users where Chucvu = 'Student'";
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(qery);
        }
    }
}
