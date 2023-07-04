using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          DateTime dob = new DateTime(2023, 7, 5, 17, 00, 00);
            MusicTickets myMusicTickets = new MusicTickets(0001, 005, 048, true, false, 150, dob, "Elton John", "Rock n Roll");
            Console.WriteLine(myMusicTickets.PurchaseConfirmation());
            Console.WriteLine(myMusicTickets);
            Console.WriteLine();


            LectureTickets myLectureTickets = new LectureTickets(0002, 005, 048, true, false, 200, dob, "Gordan Peterson", "12 rules of life");
            Console.WriteLine(myLectureTickets.PurchaseConfirmation());
            Console.WriteLine(myLectureTickets.ToString());
            Console.WriteLine();

            GameTickets myGameTickets = new GameTickets(0003, 005, 048, true, false, 100, dob, "Chicago Bulls", "Basketball");
            Console.WriteLine(myGameTickets.PurchaseConfirmation());
            Console.WriteLine(myGameTickets.ToString());
            Console.WriteLine();


            Console.ReadKey();



        }
    }
}
