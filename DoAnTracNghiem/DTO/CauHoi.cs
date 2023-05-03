using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTracNghiem.DTO
{
    public class CauHoi
    {
        private int stt;
        private string noidungcauhoi;
        private string a;
        private string b;
        private string c;
        private string d;
        private string answer;
        public CauHoi(DataRow row)
        {
            this.stt = (int)row["stt"];
            this.noidungcauhoi = row["NoiDung"].ToString();
            this.a = row["a"].ToString();
            this.b = row["b"].ToString();
            this.c = row["c"].ToString();
            this.d = row["d"].ToString();
            this.answer = row["answer"].ToString();
        }
       public CauHoi(string noidungcauhoi,string a,string b, string c, string d, string answer)
        {
            stt += 1;
            this.noidungcauhoi = noidungcauhoi;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.answer = answer;
        }
        public string Noidungcauhoi { get => noidungcauhoi; set => noidungcauhoi = value; }
        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public string C { get => c; set => c = value; }
        public string D { get => d; set => d = value; }
        public string Answer { get => answer; set => answer = value; }
        public int Stt { get => stt; set => stt = value; }
    }
}
