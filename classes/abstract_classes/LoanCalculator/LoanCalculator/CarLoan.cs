using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class CarLoan : Loan
    {
        private int carMilage;
        private int yearOfBuilt;
        private string carModel;
        private string carBrand;
        private string gasType;

        public CarLoan(int lNumber, string fName, string lName, decimal lAmount, int nOfYears, double interestR, string brand, int yearOfB, 
            string carMod, string gas, int milage)
            : base(lNumber, fName, lName, lAmount, nOfYears, interestR)

        {
            cBrand = brand;
            yOfBuilt = yearOfB;
            model = carMod;
            gasT = gas;
            cMilage = milage;
        }

        public string cBrand
        {
            get { return carBrand; }
            set { carBrand = value; }
        }

        public int yOfBuilt
        {
            get { return yearOfBuilt; }
            set { yearOfBuilt = value; }
        }

        public string model
        {
            get { return carModel; }
            set { carModel = value; }
        }

        public string gasT
        {
            get { return gasType; }
            set { gasType = value; }
        }

        public int cMilage
        {
            get { return carMilage; }
            set { carMilage = value; }
        }

        //methods

        public override decimal CalculateInterest()
        {
            decimal result;
            double coefficient = interestR / (Convert.ToDouble(numberOfY) / Convert.ToDouble(12));
            double loanPrincipal = Convert.ToDouble(loanAm + 1000);
            result = Convert.ToDecimal((coefficient) * loanPrincipal);
            return result;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\n Car brand: :\t" + carBrand +
                "\n Car model: :\t" + carModel +
                "\n Year of built: :\t" + yearOfBuilt +
                "\n Gas type: :\t" + gasType +
                "\n Car milage (km): :\t" + carMilage;
        }

    }
}
