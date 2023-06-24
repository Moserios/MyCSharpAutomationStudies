using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TripCalculator
{
    [TestClass]
    public class UnitTest1
    {
        //private object costPerKm;

        [TestMethod]
        public void KmPerLiter()
        {

            TripStats myTrip = new TripStats("Belgrade", "PalmCoast", 8578, 15000, 1.25f, 8000);
            myTrip.KilometersPerLiter();

        }

        [TestMethod]
        public void CostPerKm()
        {

            TripStats myTrip = new TripStats("Belgrade", "PalmCoast", 8578, 15000, 1.25f, 8000);
            myTrip.CostPerKilometer();
           
        }


        [TestMethod]
        public void To_String_Obj()
        {

            TripStats myTrip = new TripStats("Belgrade", "PalmCoast", 8578, 15000, 1.25f, 8000);
            Console.WriteLine(myTrip);

        }


        [TestMethod]
        public void TripInMiles()
        {

            TripStats myTrip = new TripStats("Belgrade", "PalmCoast", 8578, 15000, 1.25f, 8000);
            myTrip.TripMiles();

        }
       


        [TestMethod]
        public void TripStat()
        {

            TripStats myTrip = new TripStats("Belgrade", "PalmCoast", 8578, 15000, 1.25f, 8000);
            myTrip.TripStatistics();

        }


    }
}
