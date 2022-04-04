using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
    public class Menu
    {
        public Menu(string foodname, int count, float price, float totalprice = 0)
        {
            this.FoodName = foodname;
            this.Count = count;
            this.Price = price;
            this.Totalprice = totalprice;
        }

        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Totalprice = (float)Convert.ToDouble(row["totalprice"].ToString());
        }



        private string foodName;
        public string FoodName { get => foodName; set => foodName = value; }

        private int count;
        public int Count { get => count; set => count = value; }

        private float price;
        public float Price { get => price; set => price = value; }

        private float totalprice;
        public float Totalprice { get => totalprice; set => totalprice = value; }
    }
}
