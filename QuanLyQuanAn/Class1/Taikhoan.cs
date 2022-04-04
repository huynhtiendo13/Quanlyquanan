using QuanLyQuanAn.Class2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    class Taikhoan
    {
        private static Taikhoan instance;

        public static Taikhoan Instance 
        {
            get
            {
                if (instance == null) instance = new Taikhoan(); return instance;
            }
            private set { instance = value; }
        }
        private Taikhoan() { }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{username, password});
            return result.Rows.Count > 0;
        }
        public bool updatetk(string username, string password, string newpass)
        {
            int rs =  DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateTK @username , @password , @newpassword ", new object[] { username, password, newpass });
            return rs > 0;
        }
        public Taikhoan2 GetAccount(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from account where username = '" +username+ "'");
            foreach(DataRow item in data.Rows)
            {
                return new Taikhoan2(item);
            }
            return null;
        }
        public DataTable ShowAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select UserName, Type from ACCOUNT");
        }
        public bool ThemTK(string username, int type)
        {
            string query = string.Format("INSERT INTO ACCOUNT(username, type) VALUES(N'{0}',{1})", username, type);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }

        public bool CapnhatTk(string username, int type)
        {
            string query = string.Format("UPDATE dbo.ACCOUNT SET type = {0} where username = N'{1}'", type, username);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool XoaTK(String username)
        {
            string query = string.Format("Delete ACCOUNT where username = N'{0}'", username);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
    }
}