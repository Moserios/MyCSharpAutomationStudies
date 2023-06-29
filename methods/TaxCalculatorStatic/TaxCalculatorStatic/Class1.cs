using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTaxCalculator
{
    class PropertyTax
    {
        //private string pAddress;
        //private decimal lyAssessedValue;
        //private decimal incrementAssessedValue;
        //private decimal millageRate;
        //int exemptionValue = 25000;

        //public PropertyTax(string cpAddress, decimal clyAssessedValue, decimal cincrementAssessedValue, decimal cmillageRate)
        //{
        //    PAddress = cpAddress;
        //    LyAssessedValue = clyAssessedValue;
        //    IncrementAssessedValue = cincrementAssessedValue;
        //    MillageRate = cmillageRate;
        //}

        //public string PAddress
        //{
        //    get { return pAddress; }
        //    set { pAddress = value; }
        //}

        //public decimal LyAssessedValue
        //{
        //    get { return lyAssessedValue; }
        //    set { lyAssessedValue = value; }
        //}

        //public decimal IncrementAssessedValue
        //{
        //    get { return incrementAssessedValue; }
        //    set { incrementAssessedValue = value; }
        //}

        //public decimal MillageRate
        //{
        //    get { return millageRate; }
        //    set { millageRate = value; }
        //}

        // Methods

        //public decimal CYAssessedValue()
        //{
        //    decimal cyAssessed;
        //    return cyAssessed = lyAssessedValue / 100 * (100 + incrementAssessedValue);
        //}
        public static decimal TaxableValue(decimal lyAssessed, decimal incrementAssessedValue, decimal exemptionValue)
        {
            decimal taxableValue;
            decimal cyAssessed = lyAssessed / 100 * (100 + incrementAssessedValue);
            return taxableValue = (cyAssessed - exemptionValue);
        }



        public static decimal TaxSize(decimal lyAssessed, decimal incrementAssessedValue, decimal exemptionValue, decimal millageRate)
        {
            decimal taxValue;
            decimal cyAssessed = lyAssessed / 100 * (100 + incrementAssessedValue);
            return taxValue = (cyAssessed - exemptionValue) / 1000 * millageRate;
        }

        public static string TaxSpecification(string pAddress, decimal lyAssessed, decimal incrementAssessedValue, decimal exemptionValue, decimal millageRate)
        {
            
            decimal cyAssessed = lyAssessed / 100 * (100 + incrementAssessedValue);
            decimal taxValue = (cyAssessed - exemptionValue) / 1000 * millageRate;

            return "Property address: " + pAddress +
                "\n Last Year Assessed value: " + lyAssessed.ToString("c") +
                "\n Current Assessed value: " + cyAssessed.ToString("c") +
                "\n Exemption: " + exemptionValue.ToString("c") +
                "\n Taxable value: " + (cyAssessed - exemptionValue).ToString("c") +
                "\n Millage rate (per $1000): " + millageRate.ToString("c") +
                "\n Taxes Due: " + taxValue.ToString("c") + 
                "\n";

        }


    }
}
