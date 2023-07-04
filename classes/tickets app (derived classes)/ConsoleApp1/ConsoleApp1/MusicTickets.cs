using TicketsReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation
{
    class MusicTickets : Tickets
    {
        private string bandName;
        private string musicStyle;

        public MusicTickets(int tNum, int rNum, int sNum, bool mHall, bool balc, decimal price, DateTime doe, string bName, string mStyle)
            :base( tNum,  rNum,  sNum,  mHall,  balc,  price, doe)
        {
            bandN = bName;
            musicS = mStyle;
        }


        public string bandN
        {
            get { return bandName; }
            set { bandName = value; }
        }

        public string musicS
        {
            get { return musicStyle; }
            set { musicStyle = value; }
        }


        public override string ToString()
        {
            return "Ticket purchased" +
                "\n Ticket number: " + ticketNum +
                "\n Row number: " + rowNum +
                "\n Seat number: " + seatNum +
                "\n Date of event: " + dayTimeOfEv +
                "\n Ticket price: " + ticketPr.ToString("c") +
                "\n Concert of : " + bandName +
                "\n Music style : " + musicStyle;
        }

        public override string PurchaseConfirmation()
        {
            return "Music Ticket purchased";
        }

    }





  


}
