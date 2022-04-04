using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class2
{
    public class ReportFood2
    {
        public ReportFood2(int id, string foodname, string categoryname, float price)
        {
            this.ID = id;
            this.FoodName = foodname;
            this.CategoryName = categoryname;
            this.Price = price;
        }
        public ReportFood2(DataRow row)
        {
            this.ID = (int)row["id"];
            this.FoodName = row["name"].ToString();
            this.CategoryName = row["namecategory"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        private int iD;
        private string foodName;
        private string categoryName;
        private float price;

        public int ID { get => iD; set => iD = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public float Price { get => price; set => price = value; }
    }
}
