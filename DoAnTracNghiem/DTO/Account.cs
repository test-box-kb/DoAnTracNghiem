using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTracNghiem.DTO
{
    public class Account
    {
        
        private string name;
        private string email;
        private string ngaysinh;
        private string chucvu;
        public Account() { }
        public Account(DataRow row)
        {
            
            name = row["name"].ToString();
            email = row["email"].ToString();
            ngaysinh = row["ngaysinh"].ToString();
            chucvu = row["ChucVu"].ToString();  
        }
        public Account(string name, string email, string ngaysinh,  string chucvu) 
        {
            this.name = name;
            this.email = email;
            this.ngaysinh = ngaysinh;
            this.chucvu = chucvu;
        }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
    }
}
