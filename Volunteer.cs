using System;
using System.Collections.Generic;

namespace EmployeeManagementApplication
{
    class Volunteer : StaffMember
    {
        public double Value { get; set; }
        public Volunteer(int id, string name, string phone, string email ,Department department, double value) : base(id, name, phone, email,department)
        {
            Value = value;
        }

        public override void  print()
        {
            base.print();
            Console.WriteLine($"Value: {Value}");

        }
    }  
}

      

      

