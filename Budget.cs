using System;
using System.Collections.Generic;

namespace EmployeeManagementApplication
{
    class Budget 
    {
       public int _id {get; set;}
       public double _value{get; set; }
       
       public Budget(int id , double value) 
       {
         _id=id; 
         _value=value; 
       }
        public void IncreaseBudget(double amount)
        {
            _value += amount;
        }

        public override string ToString()
        {
            return $"Budget ID: {_id}, Value: {_value}";
        }

    }  
}

      

      

