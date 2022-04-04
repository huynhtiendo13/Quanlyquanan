using QuanLyQuanAn.Class2;
using QuanLyQuanAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản hoặc mật khẩu!");
            }
            else
            {
                if (login(username, password))
                {
                    Taikhoan2 logintk = Taikhoan.Instance.GetAccount(username);
                    Quanly f = new Quanly(logintk);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài đăng nhập hoặc mật khẩu!");
                }
            }
        }
        bool login(string username, string password)
        {
            return Taikhoan.Instance.Login(username,password);
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
