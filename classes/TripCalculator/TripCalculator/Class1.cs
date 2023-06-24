using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TripCalculator
{
    
        class TripStats
        {
            private string tripStartPoint;
            private string tripEndPoint;
            private float tripKilometers;
            private int tripGasUsed;
            private float gasCostLitre;
            private int gasCostTotal;

            public TripStats(string ctripStartPoint, string ctripEndPoint,
            float ctripKilometers, int ctripGasLitresUsed, float cgasCostLitre, int cgasCostTotal)
            {
            TripStartPoint = ctripStartPoint;
            TripEndPoint = ctripEndPoint;
            TripKilometers = ctripKilometers;
            TripGasUsed = ctripGasLitresUsed;
            GasCostLitre = cgasCostLitre;
            GasCostTotal = cgasCostTotal;
            }

            public string TripStartPoint 
            { get
                { return tripStartPoint; }
                set
                { tripStartPoint = value; }
            }
            public string TripEndPoint
            {
                get
                { return tripEndPoint; }
                set
                { tripEndPoint = value; }
            }

            public float TripKilometers
            {
                get
                { return tripKilometers; }
                set
                { tripKilometers = value; }
            }

            public int TripGasUsed
            {
                get
                { return tripGasUsed; }
                set
                { tripGasUsed = value; }
            }

            public float GasCostLitre
            {
                get
                { return gasCostLitre; }
                set
                { Convert.ToDouble(gasCostLitre = value); }
            }

            public int GasCostTotal
            {
                get
                { return gasCostTotal; }
                set
                { gasCostTotal = value; }
            }



            
            public void TripMiles()
            {
                var tripMiles = ((float)tripKilometers) / 1.60934;
                Console.WriteLine($"Distance in miles is {tripMiles}");
            }

            public void KilometersPerLiter()
            {
                float kmPerLiter = tripKilometers / tripGasUsed;
                Console.WriteLine($"Distance/Liters ratio is {tripKilometers} % {tripGasUsed} = {kmPerLiter}");
            }

            public void CostPerKilometer()
            {
                double costPerKm = gasCostTotal / tripKilometers;
                Console.WriteLine($"Cost per Km is {costPerKm}");
             
            }

        public void TripStatistics()
        {
            Console.WriteLine($"Trip from {tripStartPoint} to {tripEndPoint} with distance of {tripKilometers} " +
                $" took {tripGasUsed} liters of gas with total gas price {gasCostTotal} " +
                $"or average cost {gasCostLitre} per liter.");
        }


        public override string ToString()
            {
                return "Trip between" + tripStartPoint + " and " + tripEndPoint + " with distance of " + tripKilometers + " took " + tripGasUsed + " liters of gas with total gas price " + gasCostTotal + " or average cost " + gasCostLitre + " per liter.";
            }


       

        }

    
}
