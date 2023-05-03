using DoAnTracNghiem.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTracNghiem.DTO
{
  public  class ThongTin
    {
     
        private string name;
        private string ngaysinh;
        private string tuser;
        private string tpass;
        
        public ThongTin(string tuser, string tpass)
        {
            this.tuser = tuser;
            this.tpass = tpass;
        }
       public void load()
        {
            string query = "USP_Login @email , @passWord";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tuser, tpass });
            Account users;
            foreach (DataRow item in data.Rows)
            {
                 users = new Account(item);
                name = users.Name;
                ngaysinh = users.Ngaysinh;
            }
        }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Name { get => name; set => name = value; }
    }
}
