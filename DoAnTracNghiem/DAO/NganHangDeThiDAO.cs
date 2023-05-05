using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnTracNghiem.DTO;

namespace DoAnTracNghiem.DAO
{
    public class NganHangDeThiDAO
    {
        private static NganHangDeThiDAO instance;
        public static NganHangDeThiDAO Instance
        {
            get { if(instance == null) instance = new NganHangDeThiDAO(); return instance; }
            private set { NganHangDeThiDAO.instance = value; }
        }
        private NganHangDeThiDAO() { }
        public List<CauHoi> LoadCauHoi()
        {
            List<CauHoi> ListCauHoi = new List<CauHoi>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetCauHoi");

            foreach ( DataRow item in data.Rows)
            {
                CauHoi cauhoi = new CauHoi(item);
                ListCauHoi.Add(cauhoi);
            }
            return ListCauHoi;
        }
        public List<TraLoiCauHoi> LoadCauHoiKiemTra()
        {
            List<TraLoiCauHoi> ListCauHoi = new List<TraLoiCauHoi>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from De1");

            foreach (DataRow item in data.Rows)
            {
                TraLoiCauHoi cauhoi = new TraLoiCauHoi(item);
                ListCauHoi.Add(cauhoi);
            }
            return ListCauHoi;
        }
    }
}
