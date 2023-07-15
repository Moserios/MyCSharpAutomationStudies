using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Application_Exam
{
   class Housing : IEquatable<Housing>
    {
        private string propertyAddress;
        private string propertyConstructionType;
        private int buildYear;



        public Housing(string address, string constructionType, int year)
        {
            prAddress = address;
            prConstructionType = constructionType;
            bYear = year;
        }

        public string prAddress
        { 
            get { return propertyAddress; } 
            set { propertyAddress = value; }
        }

        public string prConstructionType
        {
            get { return propertyConstructionType; }
            set { propertyConstructionType = value; }
        }

        public int bYear
        {
            get { return buildYear; }
            set { buildYear = value; }
        }

        public virtual decimal ProjectedRentalAmt()
        {
            return 0M;
        }

        public override string ToString()
        {
            return "Address: \t" + propertyAddress.ToString() +
                "\nConsrtuction type: \t" + propertyConstructionType.ToString() +
                "\nYear build: \t" + buildYear.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Housing objAsHousing = obj as Housing;
            if (objAsHousing == null) return false;
            else return Equals(objAsHousing);
        }

        //public bool Equals(Housing other)
        //{
        //    throw new NotImplementedException();
        //}
        //public override int GetHashCode()
        //{
        //    return HousingId;
        //}
        public bool Equals(Housing other)
        {
            if (other == null) return false;
            return (this.prAddress.Equals(other.prAddress));
        }
    }
}
