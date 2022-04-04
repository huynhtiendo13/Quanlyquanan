using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
    public class Hoadon
    {
        public Hoadon(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Hoadon(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["daycheckin"];


            var dataCheckOutTemp = row["daycheckout"];
            if(dataCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dataCheckOutTemp;
            this.Status = (int)row["status"];
            if(row["discount"].ToString() != "")
                this.Discount = (int)row["Discount"];
        }
        private int discount;
        private int status;
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        private int iD;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        public int Discount { get => discount; set => discount = value; }
    }
}
