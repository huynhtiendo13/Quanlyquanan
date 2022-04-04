using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    public class BillinfoDAO
    {
        private static BillinfoDAO instance;

        internal static BillinfoDAO Instance
        {
            get { if (instance == null) instance = new BillinfoDAO(); return BillinfoDAO.instance; }
            private set { BillinfoDAO.instance = value; }
        }

        private BillinfoDAO() { }

        public List<billinfoDTO> Getlistbillinfo(int id)
        {
            List<billinfoDTO> listbillinfo = new List<billinfoDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select *from dbo.BILLINFO where idBill =" + id);
            foreach(DataRow item in data.Rows)
            {
                billinfoDTO info = new billinfoDTO(item);
                listbillinfo.Add(info);
            }

            return listbillinfo;
        }
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec dbo.USP_InsertBillInfo @idBill , @idFood , @count ", new object[] { idBill, idFood, count });
        }
        public void DeleteBillInfoByFoodID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("delete dbo.BILLINFO where idFood =" + id);
        }
    }
}
