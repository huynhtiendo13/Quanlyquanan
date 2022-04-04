using Microsoft.Reporting.WinForms;
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
    public partial class frmReportBill : Form
    {
        public frmReportBill()
        {
            InitializeComponent();
            frmReportBill_Load();
        }
        void Loadlistonemonth()
        {
            DateTime td = DateTime.Now;
            dtpkFromdateForReport.Value = new DateTime(td.Year, td.Month, 1);
            dtpkTodateForReport.Value = dtpkFromdateForReport.Value.AddMonths(1).AddDays(-1);
        }
        void frmReportBill_Load()
        {
            Thongke t = new Thongke();
            List<ReportBill> ListReport = new List<ReportBill>();
            ListReport.Clear();
            t.dtgvBill.DataSource = null;
            t.dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(dtpkFromdateForReport.Value, dtpkTodateForReport.Value);
            for (int i = 0; i < t.dtgvBill.Rows.Count - 1; i++)
            {
                ReportBill r = new ReportBill()
                {
                    DateCheckIn = DateTime.Parse(t.dtgvBill.Rows[i].Cells[2].Value.ToString()),
                    DateCheckOut = DateTime.Parse(t.dtgvBill.Rows[i].Cells[3].Value.ToString()),
                    Tablenam = t.dtgvBill.Rows[i].Cells[0].Value.ToString(),
                    Totalprice = float.Parse(t.dtgvBill.Rows[i].Cells[1].Value.ToString()),
                    Discount = int.Parse(t.dtgvBill.Rows[i].Cells[4].Value.ToString()),

                };
                ListReport.Add(r);
            }
            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("Fromdate", string.Format("Từ ngày " + dtpkFromdateForReport.Value.ToString("dd/MM/yyyyy")));
            param[1] = new ReportParameter("Todate", string.Format("Đến ngày " + dtpkTodateForReport.Value.ToString("dd/MM/yyyyy")));
            this.rpvReportBill.LocalReport.ReportPath = "ReportBill.rdlc";
            this.rpvReportBill.LocalReport.SetParameters(param);
            var reportDataSource = new ReportDataSource("ReportBillDataSet", ListReport);
            this.rpvReportBill.LocalReport.DataSources.Clear();
            this.rpvReportBill.LocalReport.DataSources.Add(reportDataSource);
            this.rpvReportBill.RefreshReport();
        }
        private void cbShowonemonth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowonemonth.Checked == true)
            {
                Loadlistonemonth();
                frmReportBill_Load();
            }
            else
            {
                DateTime td = DateTime.Now;
                dtpkFromdateForReport.Value = new DateTime(td.Year, td.Month, td.Day);
                dtpkTodateForReport.Value = new DateTime(td.Year, td.Month, td.Day);
                frmReportBill_Load();
            }
        }
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            frmReportBill_Load();
        }
    }
}
