namespace CompanyInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string website = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber == string.Empty ? "(no fax)" : faxNumber);
            Console.WriteLine("Web site: " + website);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", 
                                managerFirstName, managerLastName, managerAge, managerPhone);            
        }
    }
}