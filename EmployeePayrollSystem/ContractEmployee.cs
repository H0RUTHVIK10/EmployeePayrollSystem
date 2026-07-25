using System;

namespace EmployeePayrollSystem
{
    public class ContractEmployee : Employee, IPayable
    {
        private double basicSalary;

        public ContractEmployee(int id, string name, double basicSalary)
            : base(id, name)
        {
            this.basicSalary = basicSalary;
        }

        public void CalculateSalary()
        {
            double da = basicSalary * 0.15;
            double hra = basicSalary * 0.10;
            double ma = basicSalary * 0.05;
            double pf = basicSalary * 0.08;

            double netSalary = basicSalary + da + hra + ma - pf;

            DisplayEmployee();

            Console.WriteLine();
            Console.WriteLine("Salary Details");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Basic Salary : " + basicSalary);
            Console.WriteLine("DA (20%)     : " + da);
            Console.WriteLine("HRA (15%)    : " + hra);
            Console.WriteLine("MA (10%)     : " + ma);
            Console.WriteLine("PF (12%)     : " + pf);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Net Salary   : " + netSalary);
        }
    }
}