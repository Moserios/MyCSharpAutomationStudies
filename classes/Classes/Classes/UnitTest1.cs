using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace People
{
    [TestClass]
    public class EmployeesNames
    {

        

        [TestMethod]
        public void Class_New_Employee()
        {
            Employee NewEmployeePortugal = new Employee(1, "Sergey", "Molchun", "15.07.2023", "QA+automation", "Intapp Walls", 5000, "EUR");

            Assert.AreEqual(NewEmployeePortugal.EmployeeId, 1);
            Assert.AreEqual(NewEmployeePortugal.FirstName, "Sergey");
            Assert.AreEqual(NewEmployeePortugal.LastName, "Molchun");
            Assert.AreEqual(NewEmployeePortugal.DateOfHire, "15.07.2023");
            Assert.AreEqual(NewEmployeePortugal.JobDescription, "QA+automation");
            Assert.AreEqual(NewEmployeePortugal.Department, "Intapp Walls");
            Assert.AreEqual(NewEmployeePortugal.Salary, 5000);
            Assert.AreEqual(NewEmployeePortugal.SalaryCurrency, "EUR");

        }
        
        [TestMethod]
        public void RegularOrderRequest()
        {
            Employee NewEmployeePortugal2 = new Employee(1, "Sergey", "Molchun", "15.07.2023", "QA+automation", "Intapp Walls", 5000, "EUR");
            string regOrder = NewEmployeePortugal2.RegularOrder();
            Assert.AreEqual(regOrder, "1 Sergey Molchun 15.07.2023 Intapp Walls QA+automation 5000 EUR");
            //NewEmployeePortugal2.SortingOrder();
        }
        
        [TestMethod]
        public void SortingOrderRequest()
        {
            Employee NewEmployeePortugal3 = new Employee(1, "Sergey", "Molchun", "15.07.2023", "QA+automation", "Intapp Walls", 5000, "EUR");
            string sortOrder = NewEmployeePortugal3.SortingOrder();
            Assert.AreEqual(sortOrder, "Molchun, Sergey 1 15.07.2023 Intapp Walls QA+automation 5000 EUR");

        }

    }
}
