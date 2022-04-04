using QuanLyQuanAn.Class2;
using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance 
        {
            get
            {
                if (instance == null) instance = new FoodDAO();
                return FoodDAO.instance;
            }
            private set
            {
                FoodDAO.instance = value;
            }
        }
        private FoodDAO() { }

        public List<Food> GetFoodByIDCateGoRy(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from FOOD where idCategory = " +id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public List<Food> showfood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public bool Themmonan(string name, int id, float price)
        {
            string query = string.Format("INSERT INTO FOOD(name, idCategory, price) VALUES(N'{0}', {1}, {2})",name , id, price);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }

        public bool Capnhatmonan(int idFood, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.FOOD SET name = N'{0}', idcategory = {1}, price = {2} where id = {3}", name, id, price, idFood);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool XoaMon(int idFood)
        {
            BillinfoDAO.Instance.DeleteBillInfoByFoodID(idFood);
            string query = string.Format("Delete Food where id = {0}", idFood);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool XoaMonTheodanhmuc(int idcategory)
        {
            BillinfoDAO.Instance.DeleteBillInfoByFoodID(idcategory);
            string query = string.Format("Delete Food where idcategory = {0}", idcategory);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }

        public List<Food> SearchFoodByName(String name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("select *from dbo.FOOD where dbo.GetUnsignString(name) LIKE N'%' + dbo.GetUnsignString(N'{0}') + N'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<ReportFood2> GetlistFoodByCategoryName(string namecategory)
        {
            List<ReportFood2> list = new List<ReportFood2>();
            string query = string.Format("select f.id, f.name, fo.name as namecategory, f.price from FOOD as f, FOODCATEGORY fo where f.idCategory = fo.id and fo.name = N'{0}'", namecategory);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ReportFood2 rp = new ReportFood2(item);
                list.Add(rp);
            }
            return list;
        }
        public List<ReportFood2> GetAlllistFood()
        {
            List<ReportFood2> list = new List<ReportFood2>();
            string query = string.Format("select f.id, f.name, fo.name as namecategory, f.price from FOOD as f, FOODCATEGORY fo where f.idCategory = fo.id");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ReportFood2 rp = new ReportFood2(item);
                list.Add(rp);
            }
            return list;
        }
    }
}
