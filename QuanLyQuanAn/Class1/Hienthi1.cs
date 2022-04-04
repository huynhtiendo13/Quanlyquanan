using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get
            {
                if (instance == null) instance = new MenuDAO(); return MenuDAO.instance;
            }
            private set
            {
                MenuDAO.instance = value;
            }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listmenu = new List<Menu>();
            string query = "select FOOD.name , BILLINFO.count, FOOD.price, FOOD.price*count as [totalprice] from BILLINFO, FOOD, BILL where BILLINFO.idbill = BILL.id and BILLINFO.idfood = FOOD.id and BILL.status = 0 and BILL.idtable = "+id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listmenu.Add(menu);
            }
            return listmenu;
        }
    }
}
