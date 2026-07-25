using System;

namespace EmployeePayrollSystem
{
    public class Employee
    {
        // Private variables
        private int employeeId;
        private string employeeName;

        // Constructor
        public Employee(int id, string name)
        {
            employeeId = id;
            employeeName = name;
        }

        // Method to display employee details
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee ID   : " + employeeId);
            Console.WriteLine("Employee Name : " + employeeName);
        }
    }
}