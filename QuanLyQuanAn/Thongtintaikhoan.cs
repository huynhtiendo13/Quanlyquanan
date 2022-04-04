using QuanLyQuanAn.Class2;
using QuanLyQuanAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class Thongtintaikhoan : Form
    {
        private Taikhoan2 logintk;

        public Taikhoan2 Logintk
        {
            get { return logintk; }
            set { logintk = value; changeAcc(logintk); }
        }
        public Thongtintaikhoan(Taikhoan2 tk)
        {
            InitializeComponent();
            Logintk = tk;
        }
        void changeAcc(Taikhoan2 tk)
        {
            txbUserName.Text = Logintk.Username;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void updatetk()
        {
            string user = txbUserName.Text;
            string pass = txbPassWord.Text;
            string newpass = txbNewPass.Text;
            string repass = txbReEnterPass.Text;

            if(!newpass.Equals(repass))
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng!");
            }
            else
            {
                if(Taikhoan.Instance.updatetk(user, pass, newpass))
                {
                    MessageBox.Show("cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("vui lòng điền đúng mật khẩu");
                }
            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatetk();
        }
    }
}
