using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string fullName;
        private string department;
        private double annualSalary;

        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                lastName = value;
            }
        }
        public string FullName
        {
            get
            { 
                return $"{LastName}, {FirstName}";
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            private set
            {
                department = value;
            }
        }
        public double AnnualSalary
        {
            get
            {
                return annualSalary;
            }
            private set
            {
                annualSalary = value;
            }
        }
        public Employee(int employeeID, string firstName, string lastName, double salary) //constructor 
        {
            this.firstName = firstName;
            annualSalary = salary;
            this.employeeId = employeeID;
            this.lastName = lastName;
        }
        public void RaiseSalary(double percent)
        {
            double amountOfRaise = annualSalary * Math.Abs(percent / 100.0);
            annualSalary += amountOfRaise;
        }
    }

}
