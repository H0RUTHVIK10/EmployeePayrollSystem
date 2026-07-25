using System;

namespace EmployeePayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("     EMPLOYEE PAYROLL SYSTEM");
            Console.WriteLine("======================================");
            Console.WriteLine();
            // Permanent Employee
            IPayable emp1 = new PermanentEmployee(101, "Hruthvik", 30000);

            Console.WriteLine("===== Permanent Employee =====");
            emp1.CalculateSalary();

            Console.WriteLine();

            // Contract Employee
            IPayable emp2 = new ContractEmployee(102, "Rahul", 20000);

            Console.WriteLine("===== Contract Employee =====");
            emp2.CalculateSalary();

            Console.WriteLine();
            Console.WriteLine("Press Enter to Exit...");
            Console.ReadLine();
        }
    }
}