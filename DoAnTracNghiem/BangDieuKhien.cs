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
    public partial class BangDieuKhien : Form
    {
        public BangDieuKhien()
        {
            InitializeComponent();
        }

        private void bdkQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bdkKiemTra_Click(object sender, EventArgs e)
        {
            List<CauHoi> ListCauHoi = NganHangDeThiDAO.Instance.LoadCauHoi();

            foreach (CauHoi item in ListCauHoi)
            {
                
                if(Int32.Parse(bdkSTT.Text.Trim())==(item.Stt))
                {
                    bdkCauHoi.Text = item.Noidungcauhoi;
                    bdkA.Text = item.A;
                    bdkB.Text = item.B;
                    bdkC.Text = item.C;
                    bdkD.Text = item.D;
                    bdkAnswer.Text = item.Answer;
                    break;
                }
            }
        }

        private void bdkSua_Click(object sender, EventArgs e)
        {
            

           
        }
    }
}
