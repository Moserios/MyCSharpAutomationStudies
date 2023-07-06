using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class HomeLoan : Loan
    {
        private string homeAddress;
        private int yearOfBuilt;
        private string homeModel;
        private string homeMaterial;
        private double homeArea;

        public HomeLoan(int lNumber, string fName, string lName, decimal lAmount, int nOfYears, double interestR, string homeA, int yearOfB, string homeMod, string homeMat, double homeAr)
            : base(lNumber, fName, lName, lAmount, nOfYears, interestR)

        {
            hAddress = homeA;
            yOfBuilt = yearOfB;
            hModel = homeMod;
            hMaterial = homeMat;
            hArea = homeAr;
        }

        public string hAddress
        { 
            get { return homeAddress; } 
            set {  homeAddress = value; }
        }

        public int yOfBuilt
        {
            get { return yearOfBuilt; }
            set { yearOfBuilt = value; }
        }

        public string hModel
        {
            get { return homeModel; }
            set { homeModel = value; }
        }

        public string hMaterial
        {
            get { return homeMaterial; }
            set { homeMaterial = value; }
        }

        public double hArea
        {
            get { return homeArea; }
            set { homeArea = value; }
        }

        //methods

        public override decimal CalculateInterest()
        {
            decimal result;
            double coefficient = interestR / (Convert.ToDouble(numberOfY) / Convert.ToDouble(12));
            double loanPrincipal = Convert.ToDouble(loanAm + 5000);
            result = Convert.ToDecimal((coefficient) * loanPrincipal);
            return result;

            //return Convert.ToDecimal((interestR / Convert.ToDouble(numberOfY / 12)) * Convert.ToInt16(loanAm + 5000));
        }

        public override string ToString()
        {
            return base.ToString() +
                "\n Home Address: :\t" + homeAddress +
                "\n Year of built: :\t" + yearOfBuilt +
                "\n Home model: :\t" + homeModel +
                "\n Home material: :\t" + homeMaterial +
                "\n Home area (sq.m.): :\t" + homeArea;
        }

    }
}
