using TicketsReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation
{
    class GameTickets : Tickets
    {
        private string teamName;
        private string gameType;

        public GameTickets(int tNum, int rNum, int sNum, bool mHall, bool balc, decimal price, DateTime doe, string tName, string gType)
: base(tNum, rNum, sNum, mHall, balc, price, doe)
        {
            teamN = tName;
            gameT = gType;

        }

        public string teamN
        {
            get { return teamName; }
            set { teamName = value; }
        }

        public string gameT
        {
            get { return gameType; }
            set { gameType = value; }
        }


        public override string ToString()
        {
            return "Ticket purchased" +
                "\n Ticket number: " + ticketNum +
                "\n Row number: " + rowNum +
                "\n Seat number: " + seatNum +
                "\n Date of event: " + dayTimeOfEv +
                "\n Ticket price: " + ticketPr.ToString("c") +
                "\n Game of : " + teamName +
                "\n Game type : " + gameType;
        }

        public override string PurchaseConfirmation()
        {
            return "Game Ticket purchased";
        }



    }
}
