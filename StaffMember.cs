using System;
using System.Collections.Generic;

namespace EmployeeManagementApplication
{
    class StaffMember
    {
       public int _employeeiD {get; set;}
       public string _name {get; set;}
       public string _phone {get; set;}
       public string _email {get; set;}
        public Department Department { get; set; }

       public StaffMember(int id , string name , string phone ,string email,Department department)
       {
                _employeeiD=id; 
                _name=name; 
                _phone=phone;
                _email=email;
       }
        public virtual  void print()
        {
            Console.WriteLine( $" iD: {_employeeiD} Name: {_name} , phone: {_phone} , email: {_email}");
        }
        public virtual double pay()
        {
            return 0;
        }
       
    }  
}

      

      

