using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class MyBooking
    {
        private string bookingNo, typeID, customerNo, paymentTypeID;
        private int partySize;
        private DateTime checkInDate, checkOutDate, bookingTime;

        public MyBooking()
        {
            this.bookingNo = ""; this.typeID = ""; this.customerNo = ""; this.paymentTypeID = ""; this.partySize = 0;
            this.checkInDate = DateTime.Now; this.checkOutDate = DateTime.Now; this.bookingTime = DateTime.Now;
        }

        public MyBooking(string bookingNo, string typeID, string customerNo, string paymentTypeID, int partySize, DateTime checkInDate, DateTime checkOutDate, DateTime bookingTime)
        {
            this.bookingNo = bookingNo; this.typeID = typeID; this.customerNo = customerNo; this.paymentTypeID = paymentTypeID; this.partySize = partySize;
            this.checkInDate = checkInDate; this.checkOutDate = checkOutDate; this.bookingTime = bookingTime;
        }

        public string BookingNumber
        {
            get { return customerNo; }
            set { customerNo = value; }
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
        public DateTime BookingTime
        {
            get { return bookingTime; }
            set { bookingTime = value; }
        }
    }


}
