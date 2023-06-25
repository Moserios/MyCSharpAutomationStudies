using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{

    class ItemPrice

    {
        private decimal wholesalesItemPrice;

        public ItemPrice(decimal wholesalePrice)
        {

            WholesalePrice = wholesalePrice;
        
        }


        public decimal WholesalePrice
        {
            get 
            {
                return wholesalesItemPrice; 
            }

            set
            {
                if (value > 0)
                {
                    wholesalesItemPrice = value;
                }
                else 
                {
                    Console.WriteLine("Price can't be 0 or less");
                }

            }

        }

        public decimal WholesalesItemPrice()
        { 
            return wholesalesItemPrice; 
        }
    }


    


    
}
