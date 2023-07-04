using TicketsReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation
{
    class LectureTickets : Tickets
    {
        private string LecturerName;
        private string lectureTheme;

        public LectureTickets(int tNum, int rNum, int sNum, bool mHall, bool balc, decimal price, DateTime doe, string lName, string lTheme)
    : base(tNum, rNum, sNum, mHall, balc, price, doe)
        {
            LecturerN = lName;
            lectureT = lTheme;

        }
        public string LecturerN
        {
            get { return LecturerName; }
            set { LecturerName = value; }
        }

        public string lectureT
        {
            get { return lectureTheme; }
            set { lectureTheme = value; }
        }


        public override string ToString()
        {
            return "Ticket purchased" +
                "\n Ticket number: " + ticketNum +
                "\n Row number: " + rowNum +
                "\n Seat number: " + seatNum +
                "\n Date of event: " + dayTimeOfEv +
                "\n Ticket price: " + ticketPr.ToString("c") +
                "\n Lecture of : " + LecturerName +
                "\n Lecture theme : " + lectureTheme;
        }
        public override string PurchaseConfirmation()
        {
            return "Lecture Ticket purchased";
        }
    }
}
