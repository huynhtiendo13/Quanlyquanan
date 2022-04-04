using QuanLyQuanAn.Class2;
using QuanLyQuanAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class DSTaikhoan : Form
    {
        BindingSource listaccount = new BindingSource();
        public Taikhoan2 loginAcc;
        public DSTaikhoan()
        {
            InitializeComponent();
            dtgvListAccount.DataSource = listaccount;
            loadDSAccount();
            BingdingAcc();
        }

        private void btnExitListAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadDSAccount()
        {
            listaccount.DataSource = Taikhoan.Instance.ShowAccount();
        }
        void BingdingAcc()
        {
            txbUserName.DataBindings.Add(new Binding("text", dtgvListAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            nmTypeAccount.DataBindings.Add(new Binding("Value", dtgvListAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            int type = (int)(nmTypeAccount.Value);

            try
            {
                if(username != "")
                {
                    if (Taikhoan.Instance.ThemTK(username, type))
                    {
                        MessageBox.Show("Thêm tài khoản thành công!");
                        loadDSAccount();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi! Thêm tài khoản không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }    
            }
            catch { MessageBox.Show("Tên Tài Khoản Đã Tồn Tại!"); }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            int type = (int)(nmTypeAccount.Value);
            if (Taikhoan.Instance.CapnhatTk(username, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
                loadDSAccount();
            }
            else
            {
                MessageBox.Show("Không được phép sửa tên tài khoản!");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            if(loginAcc.Username.Equals(username))
            {
                MessageBox.Show("Không được xóa tài khoản đang đăng nhập!");
                return;
            }    
            if (Taikhoan.Instance.XoaTK(username))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                loadDSAccount();
            }
            else
            {
                MessageBox.Show("Lỗi! Xóa tài khoản không thành công!");
            }
        }
    }
}
