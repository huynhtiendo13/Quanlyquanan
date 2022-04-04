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
using System.Windows.Documents;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class Danhsachmonan : Form
    {
        BindingSource DSMonan = new BindingSource();
        public Danhsachmonan()
        {
            InitializeComponent();
            load();
            
        }
        void load()
        {
            dtgvFood.DataSource = DSMonan;
            loadDSfood();
            LoadCategorycb(cbFoodCategory);
            BingdingFood();
        }
        private void btnshowcategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadDSfood()
        {
            DSMonan.DataSource = FoodDAO.Instance.showfood();
            dtgvFood.Columns[0].HeaderText = "ID";
            dtgvFood.Columns[1].HeaderText = "Tên Món";
            dtgvFood.Columns[2].HeaderText = "ID Danh Mục";
            dtgvFood.Columns[3].HeaderText = "Đơn Giá";
        }
        void BingdingFood()
        {
            txbFoodname.DataBindings.Add(new Binding("text", dtgvFood.DataSource, "name", true, DataSourceUpdateMode.Never));
            txbFoodId.DataBindings.Add(new Binding("text", dtgvFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            nmFoodprice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategorycb(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCateGoRy();
            cb.DisplayMember = "name";
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            loadDSfood();
        }

        private void txbFoodId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0 && dtgvFood.SelectedCells[0].OwningRow.Cells["idCategory"].Value != null)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["idCategory"].Value;
                    Category category = CategoryDAO.Instance.Getcategorybyid(id);
                    cbFoodCategory.SelectedItem = category;
                    int index = -1;
                    int j = 0;
                    foreach (Category item in cbFoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = j;
                            break;
                        }
                        j++;
                    }
                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodname.Text;
            int idca = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodprice.Value;

            if (FoodDAO.Instance.Themmonan(name, idca, price))
            {
                MessageBox.Show("Thêm món thành công!");
                loadDSfood();
                if (themmonan != null)
                    themmonan(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Thêm món không thành công!");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodname.Text;
            int idca = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodprice.Value;
            int id = Convert.ToInt32(txbFoodId.Text);
            if (FoodDAO.Instance.Capnhatmonan(id, name, idca, price))
            {
                MessageBox.Show("Sửa món thành công!");
                loadDSfood();
                if (capnhatmonan != null)
                    capnhatmonan(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Sửa món không thành công!");
            }
        }

        private void btnDeteleFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodId.Text);
            if (FoodDAO.Instance.XoaMon(id))
            {
                MessageBox.Show("Xoá món thành công!");
                loadDSfood();
                if (xoaMon != null)
                    xoaMon(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Xoá món không thành công!");
            }
        }
        private event EventHandler themmonan;
        public event EventHandler Themmonan
        {
            add { themmonan += value; }
            remove { themmonan -= value; }
        }
        private event EventHandler capnhatmonan;
        public event EventHandler Capnhatmonan
        {
            add { capnhatmonan += value; }
            remove { capnhatmonan -= value; }
        }
        private event EventHandler xoaMon;
        public event EventHandler XoaMon
        {
            add { xoaMon += value; }
            remove { xoaMon -= value; }
        }
        List<Food> SearchFoodByName(string name)
        {
            List<Food> list = FoodDAO.Instance.SearchFoodByName(name);

            return list;
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            DSMonan.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportMenuAndFood r = new ReportMenuAndFood();
            r.Show();
        }
    }
}
