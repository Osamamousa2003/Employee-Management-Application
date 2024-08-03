using System;
using System.Collections.Generic;

namespace EmployeeManagementApplication
{
    class Commission_Emp: Employee
    {
        public double Salary { get; set; }
        public double Bonus { get; set; }
       public Commission_Emp(int id, string name, string phone, string email ,Department department,string ssn, double salary, double bonus) : base(id, name, phone, email,department,ssn)
       {
          Salary = salary;
          Bonus = bonus;
       }
        public override void print()
        {
            base.print();
            Console.WriteLine($"Salary: {Salary}, Bonus: {Bonus}, Payroll: {pay()}");
        }
        public override double pay()
        {
           return Salary + Bonus;
        }
    }  
}

      

      

