using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Application_Exam
{
    class MultiUnit : Housing, IUnits
    {
        private string mUnitComplexName;
        private int mUnitNumberOfUnits;
        private decimal mUnitRentAmtPerUnit;


        public MultiUnit(string address, string constructionType, int year, 
            string complexName, int numberOfUnits, decimal rentAmtPerUnit)
            : base(address, constructionType, year)
        {
            muComplexName = complexName;
            numOfUnits = numberOfUnits;
            RentPeUnit = rentAmtPerUnit;
        }

        public string muComplexName
        {
            get { return mUnitComplexName; }
            set { mUnitComplexName = value; }
        }

        public int numOfUnits
        {
            get { return mUnitNumberOfUnits; }
            set { mUnitNumberOfUnits = value; }
        }

        public decimal RentPeUnit
        {
            get { return mUnitRentAmtPerUnit; }
            set { mUnitRentAmtPerUnit = value; }
        }


        public int NumberOfUnits()
        {
            int numberOfUnits = mUnitNumberOfUnits;
            return numberOfUnits;
        }

        public override decimal ProjectedRentalAmt()
        {
            decimal rentAmount = mUnitRentAmtPerUnit * mUnitNumberOfUnits * 12;
            return rentAmount;
        }

        public override string ToString()
        {
            //return "Address: \t" + propertyAddress.ToString() +
            //   "\n Consrtuction type: \t" + propertyConstructionType.ToString() +
            //   "\n Year build: \t" + buildYear.ToString() +
            //   "\n Projected rental amount: \t" + ProjectRentalAmt().ToString();
            return base.ToString() + 
            "\nMultiUnit complex name: \t" + mUnitComplexName +
            "\nTotal number of units: \t" + mUnitNumberOfUnits +
            "\nUnit rent per month: \t" + mUnitRentAmtPerUnit.ToString("C") + 
            "\nAnnual rental amount of all units: \t" + ProjectedRentalAmt().ToString("C");

        }

    }
}
