using System;

namespace CompanyInfo
{
    class Program
    {
        static void Main()
        {
            string FaxNumber = null;

            Console.Write("Company name: ");
            string CompanyName = Console.ReadLine();
            Console.Write("Company Address: ");
            string CompanyAddress = Console.ReadLine();
            Console.Write("Phone Number: ");
            string PhoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            FaxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string WebSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string mFName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string mLName = Console.ReadLine();
            Console.Write("Manager age: ");
            string mAge = Console.ReadLine();
            Console.Write("Manager phone: ");
            string mPhone = Console.ReadLine();

            Console.WriteLine("\n\n\n\n" + CompanyName);
            Console.WriteLine("Address: " + CompanyAddress);
            Console.WriteLine("Tel. " + PhoneNumber);
            if(FaxNumber == "" || FaxNumber == null)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: " + FaxNumber);
            }
            Console.WriteLine("Web Site: " + WebSite);
            Console.WriteLine("Manager: " + mFName + " " + mLName + " (age: " + mAge + ", tel. " + mPhone + ")");
        }
    }
}
