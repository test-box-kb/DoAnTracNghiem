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
    public partial class ViewNganHangDe : Form
    {
        public ViewNganHangDe()
        {
            InitializeComponent();
            LoadNganHangDeThi();
        }
        void LoadNganHangDeThi()
        {
            List<CauHoi> ListCauHoi = NganHangDeThiDAO.Instance.LoadCauHoi();
            
            foreach(CauHoi item in ListCauHoi)
            {
                Label pen = new Label() { Width = 440}; 
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
                Label d= new Label();
                d.Text = "Đáp Án D: " + item.D;
                Label answer = new Label();
                answer.Text = "Đáp Án Đúng: " + item.Answer;
                fltNganHangDe.Controls.Add(pen);
                fltNganHangDe.Controls.Add(stt);
                fltNganHangDe.Controls.Add(noidungcauhoi);
                fltNganHangDe.Controls.Add(a);
                fltNganHangDe.Controls.Add(b);
                fltNganHangDe.Controls.Add(c);
                fltNganHangDe.Controls.Add(d);
                fltNganHangDe.Controls.Add(answer);
            }
        }
        private void ViewNganHangDe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
