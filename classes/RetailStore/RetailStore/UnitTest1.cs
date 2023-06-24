using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;

namespace RetailStore
{
    [TestClass]
    public class ReceiptSmokeTest
    {
        [TestMethod]
        
        public void TestID()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);     
            Assert.AreEqual(1, myReceipt.Id);  
            
        }

        [TestMethod]

        public void TestCustomerNumber()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Assert.AreEqual(15, myReceipt.CustomerNumber);

        }

        [TestMethod]

        public void TestItemNumber()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Assert.AreEqual(1415, myReceipt.ItemNumber);

        }

        [TestMethod]

        public void TestItemUnitPrice()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Assert.AreEqual(3650, myReceipt.ItemUnitPrice);

        }

        [TestMethod]

        public void TestItemQuantityPurchased()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Assert.AreEqual(2, myReceipt.ItemQuantityPurchased);

        }

        [TestMethod]

        public void TestTotalCost()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Assert.AreEqual(7300, myReceipt.TotalCost());
            Console.WriteLine(myReceipt.TotalCost());
        }

        [TestMethod]

        public void To_String_Test()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Console.WriteLine(myReceipt.ToString());

        }

    }

    [TestClass]
    public class ReceiptSanityTest
    {
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestIDMoreThanZero()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Assert.AreEqual(-1, myReceipt.Id);

        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestCustomerNumberMoreThanZero()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Assert.AreEqual(-15, myReceipt.CustomerNumber);

        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestItemNumberMoreThanZero()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Assert.AreEqual( -1415, myReceipt.ItemNumber);

        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestItemUnitPriceMoreThanZero()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Assert.AreEqual( -3650, myReceipt.ItemUnitPrice);

        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestItemQuantityPurchasedMoreThanZero()
        {
            Receipt myReceipt = new Receipt(1, "2023.06.24", 15, "Sergey Molchun", "Belgrade, Losinjska 1-10", "810381611492416", 1415, "Laptop Gigabyte AORUS 17X AZF RTX4090", 3650, 2);
            Assert.AreEqual(-2, myReceipt.ItemQuantityPurchased);
            

        }
    }
}



//Id = _id;
//CustomerNumber = _customerNumber;
//ItemNumber = _itemNumber;
//ItemUnitPrice = _itemUnitPrice;
//ItemQuantityPurchased = _itemQuantityPurchased;


//Date = _date;
//CustomerName = _customerName;
//CustomerAddress = _customerAddress;
//CustomerPhone = _customerPhone;
//ItemDescription = _itemDescription;

