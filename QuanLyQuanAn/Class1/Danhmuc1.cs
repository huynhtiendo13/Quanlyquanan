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
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance 
        {
            get
            {
                if (instance == null) instance = new CategoryDAO();
                return CategoryDAO.instance;
            }
            private set
            {
                CategoryDAO.instance = value;
            }
        }
        private CategoryDAO() { }

        public List<Category> GetListCateGoRy()
        {
            List<Category> list = new List<Category>();
            string query = "SELECT * FROM FOODCATEGORY";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }
        public Category Getcategorybyid(int id)
        {
            Category category = null;
            string query = "SELECT * FROM FOODCATEGORY where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }
        public bool Thedanhmuc(string name)
        {
            string query = string.Format("INSERT INTO FOODCATEGORY(name) VALUES(N'{0}')", name);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool Capnhatdanhmuc(int idcategory, string name)
        {
            string query = string.Format("UPDATE dbo.FOODCATEGORY SET name = N'{0}' where id = {1}", name, idcategory);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool Xoadanhmuc(int idcategory)
        {
            FoodDAO.Instance.XoaMonTheodanhmuc(idcategory);
            string query = string.Format("Delete FOODCATEGORY where id = {0}", idcategory);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
    }
}
