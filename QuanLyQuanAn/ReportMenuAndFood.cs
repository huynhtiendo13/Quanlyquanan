using Microsoft.Reporting.WinForms;
using QuanLyQuanAn.Class2;
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
    public partial class ReportMenuAndFood : Form
    {
        public ReportMenuAndFood()
        {
            InitializeComponent();
            LoadCategogyName();
            ReportMenuAndFood_Load();
        }
        void LoadCategogyName()
        {
            List<Category> ListCategory = CategoryDAO.Instance.GetListCateGoRy();
            cbFoodcategory.DataSource = ListCategory;
            cbFoodcategory.DisplayMember = "name";
        }
        void ReportMenuAndFood_Load()
        {
            string name = "";
            Category selected = cbFoodcategory.SelectedItem as Category;
            name = selected.Name;
            List<ReportFood> ListReport = new List<ReportFood>();
            List<ReportFood2> list = FoodDAO.Instance.GetlistFoodByCategoryName(name);
            foreach (ReportFood2 item in list)
            {
                ReportFood temp = new ReportFood();
                temp.ID = item.ID;
                temp.FoodName = item.FoodName;
                temp.CategoryName = item.CategoryName;
                temp.Price = item.Price;
                ListReport.Add(temp);

            }
            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("CategoryFood", string.Format("Món ăn Theo danh mục " + name));
            this.reportViewer1.LocalReport.ReportPath = "ReportFood.rdlc";
            this.reportViewer1.LocalReport.SetParameters(param);
            var reportDataSource = new ReportDataSource("ReportFoodDataSet", ListReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void cbFoodcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            string name = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            name = selected.Name;
            List<ReportFood> ListReport = new List<ReportFood>();
            List<ReportFood2> list = FoodDAO.Instance.GetlistFoodByCategoryName(name);
            foreach (ReportFood2 item in list)
            {
                ReportFood temp = new ReportFood();
                temp.ID = item.ID;
                temp.FoodName = item.FoodName;
                temp.CategoryName = item.CategoryName;
                temp.Price = item.Price;
                ListReport.Add(temp);

            }
            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("CategoryFood", string.Format("Món ăn Theo danh mục " + name));
            this.reportViewer1.LocalReport.ReportPath = "ReportFood.rdlc";
            this.reportViewer1.LocalReport.SetParameters(param);
            var reportDataSource = new ReportDataSource("ReportFoodDataSet", ListReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                List<ReportFood> ListReport = new List<ReportFood>();
                List<ReportFood2> list = FoodDAO.Instance.GetAlllistFood();
                foreach (ReportFood2 item in list)
                {
                    ReportFood temp = new ReportFood();
                    temp.ID = item.ID;
                    temp.FoodName = item.FoodName;
                    temp.CategoryName = item.CategoryName;
                    temp.Price = item.Price;
                    ListReport.Add(temp);

                }
                ReportParameter[] param = new ReportParameter[1];
                param[0] = new ReportParameter("CategoryFood", string.Format("Danh Sách Tất Cả Món ăn"));
                this.reportViewer1.LocalReport.ReportPath = "ReportFood.rdlc";
                this.reportViewer1.LocalReport.SetParameters(param);
                var reportDataSource = new ReportDataSource("ReportFoodDataSet", ListReport);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                ReportMenuAndFood_Load();
            }
        }
    }
}