using System;

namespace BethanysPieShopHR
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingStruct();

        }

        private static void UsingStruct()
        {
            Employee employee;
            employee.Name = "Bethany";
            employee.Wage = 35;
            employee.Work();
        }

    }

    struct Employee
    {
        public string Name;
        public int Wage;

        public void Work()
        {
            Console.WriteLine($"{Name} is doing work for {Wage} an hour.");
        }
    }

    enum EmployeeType
    {
        Sales,
        Manager,
        Research,
        StoreManager
    }

    enum StoreType
    {
        PieCorner = 10,
        Seating = 20,
        FullPieRestaurant = 100,
        Undefined = 99
    }
}
