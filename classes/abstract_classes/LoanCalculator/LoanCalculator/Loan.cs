using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    abstract class Loan
    {
        private int loanNumber;
        private string firstName;
        private string lastName;
        private decimal loanAmount;
        private int numberOfYears;
        private double intRate;


        public Loan(int lNumber, string fName, string lName, decimal lAmount, int nOfyears, double interestRate)
        {
            loanN = lNumber;
            firstN = fName;
            lastN = lName;
            loanAm = lAmount;
            numberOfY = nOfyears;
            interestR = interestRate;
        }

        public int loanN
        {
            get { return loanNumber; }
            set { loanNumber = value; }
        }

        public string firstN
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string lastN
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public decimal loanAm
        {
            get { return loanAmount; }
            set { loanAmount = value; }
        }
        public int numberOfY
        {
            get { return numberOfYears; }
            set { numberOfYears = value; }
        }

        public double interestR
        {
            get { return intRate; }
            set { intRate = value; }
        }


        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            return "Loan number: :\t" + loanNumber +
                "\n name: :\t" + lastName + " " + firstName +
                "\n loan amount: :\t" + loanAmount.ToString("C") +
                "\n loan length (months): :\t" + (numberOfYears * 12) +
                "\n Interest rate (per year): :\t" + intRate.ToString("p2") +
                "\n Interest Total amount: :\t" + CalculateInterest().ToString("C");
        }


    }

}
