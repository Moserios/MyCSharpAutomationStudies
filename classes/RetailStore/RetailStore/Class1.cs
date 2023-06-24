using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
 
        class Receipt
        { 
            // local variables

            private int id;
            private string date;
            private int customerNumber;
            private string customerName;
            private string customerAddress;
            private string customerPhone;
            private int itemNumber;
            private string itemDescription;
            private decimal itemUnitPrice;
            private decimal itemQuantityPurchased;

            //Constructor

            public Receipt(int _id, string _date, int _customerNumber, string _customerName, string _customerAddress, 
                string _customerPhone, int _itemNumber, string _itemDescription, decimal _itemUnitPrice, 
                decimal _itemQuantityPurchased) 
            {
                Id = _id;
                Date = _date;
                CustomerNumber = _customerNumber;
                CustomerName = _customerName;
                CustomerAddress = _customerAddress;
                CustomerPhone = _customerPhone;
                ItemNumber = _itemNumber;
                ItemDescription = _itemDescription;
                ItemUnitPrice = _itemUnitPrice;
                ItemQuantityPurchased = _itemQuantityPurchased;
            }

            //Get Set

            public int Id
            { 
                get { return id; }
                set 
                { 
                    if (value <= 0)
                    {
                        Console.WriteLine("ID can't be 0 or less");
                    }
                    else
                    id = value; 
                }
            }

            public string Date
            {
                get { return date; }
                set { date = value; }
            }

            public int CustomerNumber
            {
                get { return customerNumber; }
                set {
                        if (value <= 0)
                        {
                        Console.WriteLine("Customer Number can't be 0 or less");
                        }
                        else
                            customerNumber = value;
                    }
                
            }

            public string CustomerName
            {
                get { return customerName; }
                set { customerName = value; }
            }

            public string CustomerAddress
            {
                get { return customerAddress; }
                set { customerAddress = value; }
            }

            public string CustomerPhone
            {
                get { return customerPhone; }
                set { customerPhone = value; }
            }

            public int ItemNumber
            {
                get { return itemNumber; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Item Number can't be 0 or less");
                    }
                
                    else if (value > 9999)
                    {
                        Console.WriteLine("Item Number can't be more than 9999");
                    }

                    else
                        itemNumber = value;
                }
            }

            public string ItemDescription
            {
                get { return itemDescription; }
                set { itemDescription = value; }
            }

            public decimal ItemUnitPrice
            {
                get { return itemUnitPrice; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Item price can't be 0 or less");
                    }
                    else if (value > 9999)
                    {
                        Console.WriteLine("Item price can't be more than 9999");
                    }

                    else
                        itemUnitPrice = value;
                }
            }

            public decimal ItemQuantityPurchased
            {
                get { return itemQuantityPurchased; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Item quantity can't be 0 or less");
                    }
                    else
                        itemQuantityPurchased = value;
                }
            }


            // Metods

            public decimal TotalCost()
            { 
            decimal totalPrice = Convert.ToDecimal(itemQuantityPurchased) * Convert.ToDecimal(ItemUnitPrice);
                return totalPrice;
            }
            public override string ToString()
            {
               return "Customer: " + customerName + 
                    "\nPhone: " + customerPhone +
                    "\nCustomer Address: " + customerAddress + 
                    "\nItem description: " + itemDescription + 
                    "\nItem unit price: " + itemUnitPrice +
                    "\nItem quantity: " + itemQuantityPurchased + 
                    "\nTotal price: " + TotalCost().ToString("c");
            }
        }


    
}
