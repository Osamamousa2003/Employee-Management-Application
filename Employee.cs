using System;
using System.Collections.Generic;


namespace EmployeeManagementApplication
{
    class Employee : StaffMember
    {  
         public string SocialSecurityNumber { get; set; }
        public Employee(int id, string name, string phone, string email ,Department department,string ssn) : base(id, name, phone, email,department)
        {
             SocialSecurityNumber = ssn;
        }
        public override void print()
        {
            base.print();
            Console.WriteLine($"Social Security Number: {SocialSecurityNumber}");
        }
        
    }  
}

      

      

