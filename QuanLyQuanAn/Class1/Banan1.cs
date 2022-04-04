using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance 
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set{TableDAO.instance = value;}
        }
        public static int TableWidth = 90;
        public static int TableHeight = 90;
        private TableDAO() { }


        public  void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("usp_SwitchTable @idtable1 , @idtable2 ", new object[] {id1, id2});
        }
        public List<Table> loadtablelist()
        {
            List<Table> tablelist = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public bool Themban(String name)
        {
            string query = string.Format("INSERT INTO TABLEFOOD(name) VALUES(N'{0}')", name);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }

        public bool Capnhatban(string name, int id)
        {
            string query = string.Format("UPDATE dbo.TABLEFOOD SET name = N'{0}' where id = {1}", name, id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public void Xoaban(int id)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_deleteTableFood @idtable ", new object[] {id});
        }

    }
}
