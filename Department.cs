using System;
using System.Collections.Generic;

namespace EmployeeManagementApplication
{
    class Department
    {
      public  int _departiD {get; set;}
      public  string _departName {get; set;}
      public Department(int departiD , string departName)
      {
       _departiD=departiD;
       _departName=departName;
      }
        public override string ToString()
        {
            return $"Department ID: {_departiD} , Name: {_departName }";
        }
    }  
}

      

      

