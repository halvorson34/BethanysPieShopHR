using System;

namespace BethanysPieShopHR
{
    class Program
    {
        static void Main(string[] args)
        {
            //int monthlyWage = 1234;
            //int months = 12, bonus = 1000;

            //bool isActive = true;
            //double rating = 99.25;

            //double ratePerHour = 12.34;
            //int numberOfHoursWorked = 165;

            //long veryLongMonth = numberOfHoursWorked;


            //double currentMonthWage = ratePerHour * numberOfHoursWorked;

            //Console.WriteLine(currentMonthWage);

            //ratePerHour += 3;

            //if(currentMonthWage > 2000)
            //{
            //    Console.WriteLine("Top paid employee");
            //}

            //int numberOfEmployees = 15;
            //numberOfEmployees--;

            //int intMaxValue = int.MaxValue;
            //int intMinValue = int.MinValue;

            //char userSelection = 'a';
            //char upperVersion = char.ToUpper(userSelection);

            //DateTime hireDate = new DateTime(2021, 3, 28, 14, 30, 0);

            //Console.WriteLine(hireDate);

            //DateTime exitDate = new DateTime(2021, 12, 11);

            //DateTime startDate = hireDate.AddDays(15);

            //Console.WriteLine(startDate);

            //string firstName = "Bethany";
            //string lastName = "Smith";

            //string fullName = firstName + " " + lastName;

            //Console.WriteLine(fullName);

            //string formatFullName = string.Format("Full name is {0} {1}.", firstName, lastName);

            //Console.WriteLine(formatFullName);

            //string interpolationFullName = $"Full name is {firstName} {lastName}.";

            //Console.WriteLine(interpolationFullName);

            //Console.WriteLine("Enter a wage:");
            //string wage = Console.ReadLine();

            //int wageValue = int.Parse(wage);

            //Console.WriteLine($"Wage Value is: {wageValue}");

            int monthlyWage = 1234;
            int months = 12;
            int bonus = 1000;

            Console.WriteLine($"{monthlyWage}, {months}, {bonus}");

            CalculateYearlyWage(monthlyWage, months);

            //Console.ReadLine();
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            Console.WriteLine($"Yearly wage A: {monthlyWage * numberOfMonthsWorked}");
            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"Yearly wage B: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}
