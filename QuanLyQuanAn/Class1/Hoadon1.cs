using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    class BillDAO
    {
        private static BillDAO instance;

        internal static BillDAO Instance
        { get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set {BillDAO.instance = value; } 
        }

        private BillDAO() { }

        public int GetUnCheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.BILL where idtable = " +id+ "  and status = 0");
            if(data.Rows.Count > 0)
            {
                Hoadon bill = new Hoadon(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void checkOut(int id, int discount, float totalprice)
        {
            string query = "UPDATE dbo.BILL SET daycheckout = GETDATE(), status = 1," + "Discount = " + discount + ", totalprice = " + totalprice + " where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec dbo.USP_InsertBill @idTable", new object[] { id});
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.Executescalar("select MAX(id) from dbo.BILL");
            }
            catch
            {
                return 1;
            }
        }
        public DataTable GetBillListByDate(DateTime checkin, DateTime checkout)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_Getlistbillbydate @checkin , @checkout", new object[] { checkin, checkout });
        }
        public DataTable GetBillListByDateAndBage(DateTime checkin, DateTime checkout, int pageNum)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateAndPage @checkin , @checkout , @page", new object[] { checkin, checkout, pageNum });
        }
        public int GetBillNumpage(DateTime checkin, DateTime checkout)
        {
            return (int)DataProvider.Instance.Executescalar("exec USP_GetNumBillByDate @checkin , @checkout", new object[] { checkin, checkout });
        }
    }
}
