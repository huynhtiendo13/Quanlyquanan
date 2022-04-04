using QuanLyQuanAn.Class2;
using QuanLyQuanAn.DAO;
using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Menu = QuanLyQuanAn.DTO.Menu;
using Table = QuanLyQuanAn.DTO.Table;

namespace QuanLyQuanAn
{
    public partial class Quanly : Form
    {
        private Taikhoan2 logintk;

        public Taikhoan2 Logintk
        {
            get { return logintk; }
            set { logintk = value; changeAcc(logintk.Type); }
        }

        public Quanly(Taikhoan2 tk)
        {
            InitializeComponent();
            this.Logintk = tk;
            LoadTable();
            LoadCategogy();
            LoadcbTable(cbSwitchTable);
        }
        #region Method
        void changeAcc(int type)
        {
            AdminToolStripMenu.Enabled = type == 1;
            xemBáoCáoToolStripMenuItem.Enabled = type == 1;
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.loadtablelist();
            foreach (Table item in tablelist)
            {
                Button btn = new Button()
                {
                    Width = TableDAO.TableWidth,
                    Height = TableDAO.TableHeight
                };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Yellow;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        void LoadCategogy()
        {
            List<Category> ListCategory = CategoryDAO.Instance.GetListCateGoRy();
            cbCategory.DataSource = ListCategory;
            cbCategory.DisplayMember = "name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> ListFood = FoodDAO.Instance.GetFoodByIDCateGoRy(id);
            cbFood.DataSource = ListFood;
            cbFood.DisplayMember = "name";
        }
        void showbill(int id)
        {
            lsvBill.Items.Clear();

            List<Menu> listbillinfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listbillinfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Totalprice.ToString());
                totalPrice += item.Totalprice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            int discount = (int)nmdiscount.Value;
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            txbTotalPrice.Text = finalTotalPrice.ToString("c");
        }
        void LoadcbTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.loadtablelist();
            cb.DisplayMember = "name";
        }
        #endregion


        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            showbill(tableID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtintaikhoan f = new Thongtintaikhoan(Logintk);
            f.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Danhsachmonan m = new Danhsachmonan();
            m.Themmonan += M_Themmonan;
            m.Capnhatmonan += M_Capnhatmonan;
            m.XoaMon += M_XoaMon;
            m.ShowDialog();
        }

        private void M_XoaMon(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                showbill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void M_Capnhatmonan(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                showbill((lsvBill.Tag as Table).ID);
        }

        private void M_Themmonan(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                showbill((lsvBill.Tag as Table).ID);
        }

        private void bànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banan b = new Banan();
            b.Themban += B_Themban;
            b.Capnhatban += B_Capnhatban;
            b.Xoaban += B_Xoaban;
            b.ShowDialog();
        }

        private void B_Xoaban(object sender, EventArgs e)
        {
            LoadTable();
            LoadcbTable(cbSwitchTable);
        }

        private void B_Capnhatban(object sender, EventArgs e)
        {
            LoadTable();
            LoadcbTable(cbSwitchTable);
        }

        private void B_Themban(object sender, EventArgs e)
        {
            LoadTable();
            LoadcbTable(cbSwitchTable);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để thanh toán!");
                return;
            }
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int discount = (int)nmdiscount.Value;
            double totalprice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho " + table.Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.checkOut(idBill, discount, (float)totalprice);
                    showbill(table.ID);
                    LoadTable();
                    MessageBox.Show("Đã thanh toán thành công!");
                }
            }
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodcount.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillinfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillinfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            showbill(table.ID);
            LoadTable();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if(table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để sử dụng khuyến mãi");
                return;
            }    
            showbill(table.ID);
        }
        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke r = new Thongke();
            r.ShowDialog();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !");
                return;
            }
            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thực sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }

        }
        #endregion

        private void danhSáchMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Danhmucmonan d = new Danhmucmonan();
            d.Themdanhmuc += D_Themdanhmuc;
            d.Capnhatdanhmuc += D_Capnhatdanhmuc;
            d.Xoadanhmuc += D_Xoadanhmuc;
            Danhsachmonan m = new Danhsachmonan();
            m.Themmonan += M_Themmonan;
            m.Capnhatmonan += M_Capnhatmonan;
            m.XoaMon += M_XoaMon;
            d.ShowDialog();
        }
        private void D_Xoadanhmuc(object sender, EventArgs e)
        {
            LoadCategogy();
            if (lsvBill.Tag != null)
                showbill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void D_Capnhatdanhmuc(object sender, EventArgs e)
        {
            LoadCategogy();
            if (lsvBill.Tag != null)
                showbill((lsvBill.Tag as Table).ID);
        }

        private void D_Themdanhmuc(object sender, EventArgs e)
        {
            LoadCategogy();
            if (lsvBill.Tag != null)
                showbill((lsvBill.Tag as Table).ID);
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSTaikhoan ds = new DSTaikhoan();
            ds.loginAcc = Logintk;
            ds.ShowDialog();
        }

        private void báoCáoMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportMenuAndFood r = new ReportMenuAndFood();
            r.ShowDialog();
        }

        private void báoCáoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportBill r = new frmReportBill();
            r.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = string.Format("Hôm nay là Ngày {0} - Bây Giờ là {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheckOut_Click(this, new EventArgs());
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFood_Click(this, new EventArgs());
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSwitchTable_Click(this, new EventArgs());
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
