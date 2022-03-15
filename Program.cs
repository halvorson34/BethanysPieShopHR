using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;
using System;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------\n");

            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), EmployeeType.Manager, 25);
            Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), EmployeeType.Research, 30);

            Employee.DisplayTaxRate();

            #region First run Bethany

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();

            #endregion


            #region First run George

            george.DisplayEmployeeDetails();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();

            #endregion

            Employee.taxRate = 0.02;

            #region Second run Bethany

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();

            #endregion


            #region Second run George

            george.DisplayEmployeeDetails();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();

            #endregion

            Customer customer = new Customer();

            Console.ReadLine();
        }
    }
}
