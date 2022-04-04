using Microsoft.Reporting.WinForms;
using QuanLyQuanAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
            Loadlistviewbillonemonth();
            LoadListView(dtpkFromDate.Value,dtpkToday.Value);
            LoadTotalprice();
        }
        public void LoadListView(DateTime checkin, DateTime checkout)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkin, checkout);
            dtgvBill.Columns[0].HeaderText = "Tên bàn";
            dtgvBill.Columns[1].HeaderText = "Thành tiền";
            dtgvBill.Columns[2].HeaderText = "Ngày Vào";
            dtgvBill.Columns[3].HeaderText = "Ngày ra";
            dtgvBill.Columns[4].HeaderText = "Khuyến mãi(%)";
        }
        void LoadTotalprice()
        {
            int sc = dtgvBill.Rows.Count;
            float totalprice = 0;
            for (int i = 0; i < sc - 1; i++)
                totalprice += float.Parse(dtgvBill.Rows[i].Cells["totalprice"].Value.ToString());
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txbTotalPrice.Text = totalprice.ToString("c");
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            dtgvBill.DataSource = null;
            LoadListView(dtpkFromDate.Value, dtpkToday.Value);
            LoadTotalprice();
            
        }
        void Loadlistviewbillonemonth()
        {
            DateTime td = DateTime.Now;
            dtpkFromDate.Value = new DateTime(td.Year, td.Month, 1);
            dtpkToday.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetBillNumpage(dtpkFromDate.Value, dtpkToday.Value);
            int LastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
                LastPage++;
            txbPageNumber.Text = LastPage.ToString();
            LoadTotalprice();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetBillNumpage(dtpkFromDate.Value, dtpkToday.Value);
            int page = Convert.ToInt32(txbPageNumber.Text);
            if (page < sumRecord)
                page++;
            txbPageNumber.Text = page.ToString();
            LoadTotalprice();
        }

        private void btnReviousPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageNumber.Text);
            if (page > 1)
                page--;

            txbPageNumber.Text = page.ToString();
            LoadTotalprice();
        }

        private void btnFisrtPage_Click(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDateAndBage(dtpkFromDate.Value, dtpkToday.Value, 1);
            txbPageNumber.Text = "1";
            LoadTotalprice();
        }

        private void txbNumberPage_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDateAndBage(dtpkFromDate.Value, dtpkToday.Value, Convert.ToInt32(txbPageNumber.Text));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            frmReportBill f = new frmReportBill();
            f.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
