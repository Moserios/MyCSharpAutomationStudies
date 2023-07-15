using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Application_Exam
{
    internal class SingleFamily : Housing
    {
        private decimal singleRentAmt;
        private double sizeInSqMeters;
        private int bedroomsNumber;
        private int bathroomsNumber;
        private bool isTherePorch;
        private bool isThereGarage;


        public SingleFamily(string address, string constructionType, int year, 
            decimal rentAmtSingle, double sqMeters, int bedrooms, int bathrooms, bool porch, bool garage)
            : base(address, constructionType, year)
        {
            singleRent = rentAmtSingle;
            sizeSqMeters = sqMeters;
            bedroomsNum = bedrooms;
            bathroomsNum = bathrooms;
            isPorch = porch;
            isGarage = garage;
        }

        public decimal singleRent
        {
            get { return singleRentAmt; }
            set { singleRentAmt = value; }
        }

        public double sizeSqMeters
        {
            get { return sizeInSqMeters; }
            set { sizeInSqMeters = value; }
        }

        public int bedroomsNum
        {
            get { return bedroomsNumber; }
            set { bedroomsNumber = value; }
        }
        public int bathroomsNum
        {
            get { return bathroomsNumber; }
            set { bathroomsNumber = value; }
        }
        public bool isPorch
        {
            get { return isTherePorch; }
            set { isTherePorch = value; }
        }
        public bool isGarage
        {
            get { return isThereGarage; }
            set { isThereGarage = value; }
        }


        public override decimal ProjectedRentalAmt()
        {
            decimal rentAmount = singleRentAmt * 12M;
            return rentAmount;
        }

        public override string ToString()
        {
            //return "Address: \t" + propertyAddress.ToString() +
            //   "\n Consrtuction type: \t" + propertyConstructionType.ToString() +
            //   "\n Year build: \t" + buildYear.ToString() +
            //   "\n Projected rental amount: \t" + ProjectRentalAmt().ToString();
            return base.ToString() +
            "\nHouse area sq.m.: \t" + sizeInSqMeters +
            "\nNumber ob bedrooms: \t" + bedroomsNumber +
            "\nNumber ob bathrooms: \t" + bathroomsNumber +
            "\nIs there a porch: \t" + isTherePorch +
            "\nIs there a garage: \t" + isThereGarage +
            "\nMonthly rental amount: \t" + singleRentAmt.ToString("C") + 
            "\nAnnual rental amount: \t" + ProjectedRentalAmt().ToString("C");

        }

    }

}
