using System;
using System.Collections.Generic;

namespace EmployeeManagementApplication
{
    class Salaried_Emp : Employee
    {
       public double _Salary{get; set;}
       public Salaried_Emp(int id, string name, string phone, string email ,Department department,string ssn,double Salary) : base(id, name, phone, email,department,ssn)
       {
         _Salary=_Salary;
       }
        public override void print()
        {
            base.print();
            Console.WriteLine($"Salary: {_Salary}, Payroll: {pay()}");
        }
        public override double pay()
        {
            return _Salary;
        }
    }  
}

      

      

