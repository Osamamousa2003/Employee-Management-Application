using System;
using System.Collections.Generic;

namespace EmployeeManagementApplication
{
    class Hourlay_Emp :Employee
    {
       public double _Hours_Worked {get; set;}
       public double _rate {get; set;}
       public Hourlay_Emp(int id, string name, string phone, string email ,Department department,  string ssn,double Hours_Worked , double rate): base(id, name, phone, email, department, ssn)
       {
        _Hours_Worked=Hours_Worked ;
        _rate=rate;
       }
       public override void print()
       {
           base.print();
           Console.WriteLine($"Hourly Rate: {_rate}, Hours Worked: {_Hours_Worked}, Payroll: {pay()}");
       }
       public override double pay()
       {
          return _rate * _Hours_Worked;
       }

    }  
}

      

      

