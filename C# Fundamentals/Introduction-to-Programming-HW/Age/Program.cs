namespace Age
{
    using System;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string format = "MM.dd.yyyy";
            DateTime birthDay = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
            int age = DateTime.Now.Year - birthDay.Year;
            if (DateTime.Now.AddYears(-age) < birthDay)
            {
                --age;
            } 
                
            int ageAfterTenYears = age + 10;
            Console.WriteLine(age);
            Console.WriteLine(ageAfterTenYears);
        }
    }
}
