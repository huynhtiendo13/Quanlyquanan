using QuanLyQuanAn.DAO;
using QuanLyQuanAn.DTO;
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
    public partial class Danhmucmonan : Form
    {
        BindingSource DSCategory = new BindingSource();
        public Danhmucmonan()
        {
            InitializeComponent();
            dtgvCategory.DataSource = DSCategory;
            loadDSCategory();
            BingdingCategoryFood();
        }
        void BingdingCategoryFood()
        {
            txbCategoryID.DataBindings.Add(new Binding("text", dtgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtNameCategory.DataBindings.Add(new Binding("text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        void loadDSCategory()
        {
            DSCategory.DataSource = CategoryDAO.Instance.GetListCateGoRy();
            dtgvCategory.Columns[1].HeaderText = "Tên danh Mục";
        }
        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            loadDSCategory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
             string name = txtNameCategory.Text;
             if (CategoryDAO.Instance.Thedanhmuc(name))
             {
                 MessageBox.Show("Thêm thành công!");
                loadDSCategory();
                 if (themdanhmuc != null)
                 themdanhmuc(this, new EventArgs());
             }
             else
             {
                    MessageBox.Show("Lỗi! Thêm không thành công!");
             }
        }
        private event EventHandler themdanhmuc;
        public event EventHandler Themdanhmuc
        {
            add { themdanhmuc += value; }
            remove { themdanhmuc -= value; }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txtNameCategory.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);
            if (CategoryDAO.Instance.Capnhatdanhmuc(id,name))
            {
                MessageBox.Show("Sửa thành công!");
                loadDSCategory();
                if (capnhatdanhmuc != null)
                    capnhatdanhmuc(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Sửa không thành công!");
            }
        }
        private event EventHandler capnhatdanhmuc;
        public event EventHandler Capnhatdanhmuc
        {
            add { capnhatdanhmuc += value; }
            remove { capnhatdanhmuc -= value; }
        }

        private void btnDeleteCateGory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            if (CategoryDAO.Instance.Xoadanhmuc(id))
            {
                MessageBox.Show("Xoá thành công!");
                loadDSCategory();
                if (xoadanhmuc != null)
                    xoadanhmuc(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Xoá không thành công!");
            }
        }
        private event EventHandler xoadanhmuc;
        public event EventHandler Xoadanhmuc
        {
            add { xoadanhmuc += value; }
            remove { xoadanhmuc -= value; }
        }

        private void btnExitCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
