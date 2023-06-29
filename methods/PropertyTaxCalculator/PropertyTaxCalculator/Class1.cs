using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTaxCalculator
{
    internal class PropertyTax
    {
        private string pAddress;
        private decimal lyAssessedValue;
        private decimal incrementAssessedValue;
        private decimal millageRate;
        int exemptionValue = 25000;

        public PropertyTax(string cpAddress, decimal clyAssessedValue, decimal cincrementAssessedValue, decimal cmillageRate)
        {
            PAddress = cpAddress;
            LyAssessedValue = clyAssessedValue;
            IncrementAssessedValue = cincrementAssessedValue;
            MillageRate = cmillageRate;
        }

        public string PAddress
        {
            get { return pAddress; } set { pAddress = value; }
        }

        public decimal LyAssessedValue
        {
            get { return lyAssessedValue; } set { lyAssessedValue = value; }
        }

        public decimal IncrementAssessedValue
        {
            get { return incrementAssessedValue; }
            set { incrementAssessedValue = value; }
        }

        public decimal MillageRate
        {
            get { return millageRate; } set { millageRate = value; }
        }

        // Methods

        public decimal CYAssessedValue()
        {
            decimal cyAssessed;
            return cyAssessed = lyAssessedValue / 100 * (100 + incrementAssessedValue);
        }

        public decimal TaxCalculation()
        {
            //int exemptionvalue = 25000;
            decimal taxValue;
            return taxValue = (CYAssessedValue() - exemptionValue) / 1000 * millageRate; 
        }

        public override string ToString()
        {
            return "Property address: " + pAddress + 
                "\n Last Year Assessed value: " + lyAssessedValue.ToString("c") +
                "\n Current Assessed value: " + CYAssessedValue().ToString("c") + 
                "\n Exemption: " + exemptionValue.ToString("c") + 
                "\n Taxable value: " + (CYAssessedValue() - exemptionValue).ToString("c") + 
                "\n Millage rate (per $1000): " + millageRate.ToString("c") +
                "\n Taxes Due: " + TaxCalculation().ToString("c");

        }


    }
}
