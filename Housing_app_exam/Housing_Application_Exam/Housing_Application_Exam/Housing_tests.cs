using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;

namespace Housing_Application_Exam
{
    [TestClass]
    public class HousingTests
    {
        [TestMethod]
        public void SingleFamilyTest()
        {            
            List<SingleFamily> singleFamilyList = new List<SingleFamily>();
           
            singleFamilyList.Add(new SingleFamily("Seattle, WA, Rusvelt str.110", "Blocks + termoisolation", 2001, (decimal)2100.00, 210, 2, 1, true, false));
            singleFamilyList.Add(new SingleFamily("Palo Alto, CA, Napoleon str.220", "PVH panels", 2002, (decimal)2200.00, 220, 2, 2, true, false));
            singleFamilyList.Add(new SingleFamily("New York, NY, Long Island 330", "Monolith concreet + blocks", 2003, (decimal)2300.00, 230, 2, 2, true, true));
            singleFamilyList.Add(new SingleFamily("Palm Coast, FL, Cabana str.440", "Blocks + PVH panels", 2004, (decimal)2400.00, 240, 3, 2, true, false));
            singleFamilyList.Add(new SingleFamily("Charlotte, NC, Wingrave Dr.800", "Blocks + termoisolation", 2005, (decimal)2500.00, 250, 3, 2, true, true));

            //Call override ToSring method for each element
            Console.WriteLine();
            foreach (SingleFamily aHousing in singleFamilyList)
            {
                Console.WriteLine(aHousing + "\n");
            }
        }

        [TestMethod]
        public void MultiunitTest()
        {
            
            List<MultiUnit> MultiUnitsList = new List<MultiUnit>();

            MultiUnitsList.Add(new MultiUnit("Seatle, WA, Rusvelt str.110", "Blocks + termoisolation", 2001, "Seattle pines", 100, (decimal)1100.00));
            MultiUnitsList.Add(new MultiUnit("Palo Alto, CA, Napoleon str.220", "PVH panels", 2002, "Valley Oaks", 200, (decimal)1200.00));
            MultiUnitsList.Add(new MultiUnit("New York, NY, Long Island 330", "Monolith concreet + blocks", 2003, "Bushy tailes", 300, (decimal)1300.00));
            MultiUnitsList.Add(new MultiUnit("Palm Coast, FL, Cabana str.440", "Blocks + PVH panels", 2004, "Coco Palms", 400, (decimal)1400.00));
            MultiUnitsList.Add(new MultiUnit("Charlotte, NC, Wingrave Dr.800", "Blocks + termoisolation", 2005, "CArolina Creaks", 500, (decimal)1500.00));

            //Call override ToSring method for each element
            Console.WriteLine();
            foreach (MultiUnit aHousing in MultiUnitsList)
            {
                Console.WriteLine(aHousing + "\n");
            }
        }

        [TestMethod]
        public void CombinedTest()
        {
            List<Housing> CombinedList = new List<Housing>();

            CombinedList.Add(new SingleFamily("Seattle, WA, Rusvelt str.110", "Blocks + termoisolation", 2001, (decimal)2100.00, 210, 2, 1, true, false));
            CombinedList.Add(new SingleFamily("Palo Alto, CA, Napoleon str.220", "PVH panels", 2002, (decimal)2200.00, 220, 2, 2, true, false));
            CombinedList.Add(new SingleFamily("New York, NY, Long Island 330", "Monolith concreet + blocks", 2003, (decimal)2300.00, 230, 2, 2, true, true));
            CombinedList.Add(new SingleFamily("Palm Coast, FL, Cabana str.440", "Blocks + PVH panels", 2004, (decimal)2400.00, 240, 3, 2, true, false));
            CombinedList.Add(new SingleFamily("Charlotte, NC, Wingrave Dr.800", "Blocks + termoisolation", 2005, (decimal)2500.00, 250, 3, 2, true, true));

            CombinedList.Add(new MultiUnit("Seatle, WA, Rusvelt str.110", "Blocks + termoisolation", 2001, "Seattle pines", 100, (decimal)1100.00));
            CombinedList.Add(new MultiUnit("Palo Alto, CA, Napoleon str.220", "PVH panels", 2002, "Valley Oaks", 200, (decimal)1200.00));
            CombinedList.Add(new MultiUnit("New York, NY, Long Island 330", "Monolith concreet + blocks", 2003, "Bushy tailes", 300, (decimal)1300.00));
            CombinedList.Add(new MultiUnit("Palm Coast, FL, Cabana str.440", "Blocks + PVH panels", 2004, "Coco Palms", 400, (decimal)1400.00));
            CombinedList.Add(new MultiUnit("Charlotte, NC, Wingrave Dr.800", "Blocks + termoisolation", 2005, "CArolina Creaks", 500, (decimal)1500.00));

            //Call override ToSring method for each element
            Console.WriteLine();
            foreach (Housing aHousing in CombinedList)
            {
                Console.WriteLine($"\nAddress: \t" + aHousing.prAddress + $"\nProjected annual rental amont: \t" + aHousing.ProjectedRentalAmt().ToString("C") + $"\n");
            }
        }
    }
}
