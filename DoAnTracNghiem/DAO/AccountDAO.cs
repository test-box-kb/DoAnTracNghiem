using DoAnTracNghiem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTracNghiem.DAO
{
   public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO();  return instance; }
           private set { instance = value; }
        }
        public bool login(string email, string password)
        {
            string query = "USP_Login @email , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {email , password });
            return result.Rows.Count > 0;
            
        }
     
       private AccountDAO() { }

        public List<Account> LoadAccount()
        {
            List<Account> ListUsers = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetUsers");

            foreach (DataRow item in data.Rows)
            {
                Account users = new Account(item);
                ListUsers.Add(users);
            }
            return ListUsers;
        }
        public Account GetThongTinByUserName(string email)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from users where email = '" + email +"'");
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public bool UpdateAccount(string email , string name , string password , string newpassword)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @email , @name , @password , @newpassword",new object[]{email,name,password,newpassword });
            return result > 0;
        }
    }
}
