using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace QuanLyQuanAn.Class2
{
    public class Taikhoan2
    {
        public Taikhoan2(string username, int type, string password = null)
        {
            this.Username = username;
            this.Type = type;
            this.Password = password;
        }

        public Taikhoan2(DataRow row)
        {
            this.Username = row["username"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["password"].ToString();
        }
        private string username;
        private string password;
        private int type;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
