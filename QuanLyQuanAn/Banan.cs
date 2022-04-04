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
    public partial class Banan : Form
    {
        BindingSource ListTable = new BindingSource();
        public Banan()
        {
            InitializeComponent();
            dtgvTable.DataSource = ListTable;
            LoadListTable();
            BindingTable();
        }
        void BindingTable()
        {
            txbTableID.DataBindings.Add(new Binding("text", dtgvTable.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbTableName.DataBindings.Add(new Binding("text", dtgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        void LoadListTable()
        {
            ListTable.DataSource = TableDAO.Instance.loadtablelist();
        }
        
        private void btnExitTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            try
            {
                if (TableDAO.Instance.Themban(name))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadListTable();
                    if (themban != null)
                        themban(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Lỗi! Thêm không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("ID Bàn đã tồn tại!");
            }
        }
        private event EventHandler themban;
        public event EventHandler Themban
        {
            add { themban += value; }
            remove { themban -= value; }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            int id = Convert.ToInt32(txbTableID.Text);
            if (TableDAO.Instance.Capnhatban(name, id))
            {
                MessageBox.Show("Sửa thành công!");
                LoadListTable();
                if (capnhatban != null)
                    capnhatban(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Sửa không thành công!");
            }
        }
        private event EventHandler capnhatban;
        public event EventHandler Capnhatban
        {
            add { capnhatban += value; }
            remove { capnhatban -= value; }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            if (MessageBox.Show(string.Format("Xóa Bàn sẽ Xóa hết hóa đơn của bàn này! \n bạn có thực sự muốn xóa?"), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.Xoaban(id);
                LoadListTable();
                if (xoaban != null)
                    xoaban(this, new EventArgs());
            }
        }
        private event EventHandler xoaban;
        public event EventHandler Xoaban
        {
            add { xoaban += value; }
            remove { xoaban -= value; }
        }
    }
}
