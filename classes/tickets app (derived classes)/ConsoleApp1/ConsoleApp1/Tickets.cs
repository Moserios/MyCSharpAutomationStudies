using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation
{
    abstract class Tickets
    {
        private int ticketNumber;
        private int rowNumber;
        private int seatNumber;
        private bool mainHall;
        private bool balcony;
        private decimal ticketPrice;
        private DateTime dayTimeOfEvent;



        public Tickets(int tNum, int rNum, int sNum, bool mHall, bool balc, decimal price, DateTime doe)

        {
            ticketNum = tNum;
            rowNum = rNum;
            seatNum = sNum;
            mainH = mHall;
            ticketPr = price;
            dayTimeOfEv = doe;

        }
        public int ticketNum
        {
            get { return ticketNumber; }
            set { ticketNumber = value; }
        }

        public int rowNum
        {
            get { return rowNumber; }
            set { rowNumber = value; }
        }

        public int seatNum
        {
            get { return seatNumber; }
            set { seatNumber = value; }
        }

        public decimal ticketPr
        {
            get { return ticketPrice; }
            set { ticketPrice = value; }
        }

        public bool mainH
        {
            get { return mainHall; }
            set { mainHall = value; }
        }

        public DateTime dayTimeOfEv
        {
            get { return dayTimeOfEvent; }
            set { dayTimeOfEvent = value; }
        }

        public abstract string PurchaseConfirmation();

    }



}



