using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class MyBooking
    {
        private string bookingNo, typeID, customerNo, paymentTypeID, bookingTime, roomNo, tableNo;
        private int partySize;
        private DateTime checkInDate, checkOutDate;        

        public MyBooking()
        {
            this.bookingNo = ""; this.typeID = ""; this.customerNo = ""; this.paymentTypeID = ""; this.partySize = 0;
            this.checkInDate = DateTime.Now; this.checkOutDate = DateTime.Now; this.bookingTime = "";
            this.roomNo = ""; this.tableNo = "";
        }

        public MyBooking(string bookingNo, string typeID, string customerNo, string paymentTypeID, int partySize, DateTime checkInDate, DateTime checkOutDate, string bookingTime, string roomNo, string tableNo)
        {
            this.bookingNo = bookingNo; this.typeID = typeID; this.customerNo = customerNo; this.paymentTypeID = paymentTypeID; this.partySize = partySize;
            this.checkInDate = checkInDate; this.checkOutDate = checkOutDate; this.bookingTime = bookingTime;
            this.roomNo = roomNo; this.tableNo = tableNo;
        }

        public string BookingNumber
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }
        public string TypeID
        {
            get { return typeID; }
            set { typeID = value; }
        }
        public string CustomerNumber
        {
            get { return customerNo; }
            set { customerNo = value; }
        }

        public string PaymentTypeID
        {
            get { return paymentTypeID; }
            set { paymentTypeID = value; }
        }
        public int PartySize
        {
            get { return partySize; }
            set { partySize = value; }
        }
        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }
        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }
        public string BookingTime
        {
            get { return bookingTime; }
            set { bookingTime = value; }
        }

        public string RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }

        public string TableNo
        {
            get { return tableNo; }
            set { tableNo = value; }
        }
    }


}
