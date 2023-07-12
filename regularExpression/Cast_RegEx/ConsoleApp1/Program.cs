using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;
using System.Security.Policy;

namespace UserDataValidation
{
    class Program
    {

        //if all fields validated with regex and corect
        //      > show all entered data to User
        //else > show a message with error 

        static void Main(string[] args)
        {
            string fName = FirstNameCheck();
            string lName = LastNameCheck();
            int age = Convert.ToInt32(AgeCheck());
            string dob = BirthDateMatch();
            string phoneNumber = PhoneMatch();
            
            Console.WriteLine(
              $"\nFirst name: {fName}" +
              $"\nLast name: {lName}" +
              $"\nAge: {age}" +
              $"\nDate of birth: {dob}" +
              $"\nPhone number: {phoneNumber}");


            //if (fName != null && lName != null && age != null && dob != null && phoneNumber != null)
            //{
            //    Console.WriteLine(
            //        $"\nFirst name: {fName}" +
            //        $"\nLast name: {lName}" +
            //        $"\nAge: {age}" +
            //        $"\nDate of birth: {dob}" +
            //        $"\nPhone number: {phoneNumber}");
            //}
            //else 
            //{
            //        Console.WriteLine(
            //        $"\nFirst name: {fName}" +
            //        $"\nLast name: {lName}" +
            //        $"\nAge: {age}" +
            //        $"\nDate of birth: {dob}" +
            //        $"\nPhone number: {phoneNumber}");
            //}


            Console.ReadKey();

        }



        public static string FirstNameCheck()
        {
            Console.WriteLine("Enter First name (letters only)");
            string fName = Console.ReadLine();
            bool fNameChecked = NameMatch(fName);
            if (fNameChecked == true)
            { return fName; }
            else { return fName+": is incorrect format"; }
        }

        public static string LastNameCheck()
        {
            Console.WriteLine("Enter Last name (letters only)");
            string lName = Console.ReadLine();
            bool lNameChecked = NameMatch(lName);
            if (lNameChecked == true)
            { return lName; }
            else { return lName + ": is incorrect format"; }
        }


        public static bool NameMatch(string name)
        {
            string pattern = @"^[a-zA-Z]+$";
            if (name != null)
            {
                return Regex.IsMatch(name, pattern);
            }
            else 
            {
                return false;
            }
        }

        public static string AgeCheck()
        {
            Console.WriteLine("Enter your age in years (numbers only)");
            string age = Console.ReadLine();
            string pattern = @"^[0-9]*$";
            bool ageChecked = Regex.IsMatch(age, pattern);
            
            if (ageChecked == true)
            { return age; }
            else { return age+ ": is incorrect format"; }
        }


        public static string BirthDateMatch()
        {
            int day = 0;
            int month = 0;
            int year = 0;
            
            Console.WriteLine("Enter the day of your birth in format \"dd\" (day number only)");
            string sDay = Console.ReadLine();
            while (day == 0 && int.TryParse(sDay, out day)==false)
            {
                Console.WriteLine("Enter the day of your birth in correct format: day numbers only.");
                sDay = Console.ReadLine();
            }
            day = Convert.ToInt32(sDay);

            Console.WriteLine("Enter the month of your birth in format \"mm\" (month numbers only)");
            string sMonth = Console.ReadLine();
            while (month == 0 && int.TryParse(sMonth, out month) == false)
            {
                Console.WriteLine("Enter the day of your birth in correct format: day numbers only.");
                sMonth = Console.ReadLine();
            }
            month = Convert.ToInt32(sMonth);

            Console.WriteLine("Enter the year of your birth in format \"yyyy\" (year numbers only)");
            string sYear = Console.ReadLine();
            while (year == 0 && int.TryParse(sYear, out year) == false)
            {
                Console.WriteLine("Enter the day of your birth in correct format: day numbers only.");
                sYear = Console.ReadLine();
            }
            year = Convert.ToInt32(sYear);
            
            string dob = day + "/" + month + "/" + year;
            string pattern = @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$";
            bool dobChecked = Regex.IsMatch(dob, pattern);
            //dobChecked = Regex.IsMatch(dob, pattern);
            if (dobChecked == true)
            { return dob; }
            else { return dob+ ": is incorrect format"; }
        }


        public static string PhoneMatch()
        {
            string phoneNumber;
            string pattern = @"(?:\(\d{3}\)|\d{3})[- ]?\d{3}[- ]?\d{4}";        //@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            Console.WriteLine("Enter phone number in format: (555)555-5555");
            phoneNumber = Console.ReadLine();
            bool phoneChecked = Regex.IsMatch(phoneNumber, pattern);
            if (phoneChecked == true)
            {
                return phoneNumber; 
            }
            else
            {
                return phoneNumber+ ": is incorrect format";
            }

            //do
            //{
            //    Console.WriteLine("Enter phone number in format: 555-555-5555");
            //    phoneNumber = Console.ReadLine();
            //    if (phoneChecked = Regex.IsMatch(phoneNumber, pattern) == true)
            //    {
            //        Console.WriteLine("You've entered correct phone format.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter phone number in proper format numbers only: 555-555-5555");
            //    }

            //}
            //while (phoneChecked == false);
            //return phoneNumber;

        }
        




    }
}
