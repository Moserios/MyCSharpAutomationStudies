using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    internal class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string dateOfHire;
        private string jobDescription;
        private string department;
        private int salary;
        private string salaryCurrency;

        public Employee (int nemployeeId, string nfirstName, string nlastName, string ndateOfHire, string njobDescription, string ndepartment, int nsalary, string nsalaryCurrency)
        {
            EmployeeId = nemployeeId;
            FirstName = nfirstName;
            LastName = nlastName;
            DateOfHire = ndateOfHire;
            JobDescription = njobDescription;
            Department = ndepartment;
            Salary = nsalary;
            SalaryCurrency = nsalaryCurrency;
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; } 
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string DateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        }

        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string SalaryCurrency
        {
            get { return salaryCurrency; }
            set { salaryCurrency = value; }
        }

        //methods

        public string SortingOrder()
        {
            return lastName + ", " + firstName + " " + employeeId + " " + dateOfHire + " " + department + " " + jobDescription + " " + salary + " " + salaryCurrency;      
        }

        public string RegularOrder()
        {
            return employeeId + " " + firstName + " " + lastName + " " + dateOfHire + " " + department + " " + jobDescription + " " + salary + " " + salaryCurrency;
        }
    }
}
