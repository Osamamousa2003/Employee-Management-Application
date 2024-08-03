using System;
using System.Collections.Generic;


namespace EmployeeManagementApplication
{
    class Project
    {
         public int projectID {get; set; }
         public string _location { get; set; }
         public Employee Manager{get; set;}
         public double _currentCost{get; set;}
         public List<Budget>Budgets{get; set; }
        public Project(int id, string location, double currentCost, Employee manager)
        {
             projectID= id;
            _location = location;
            _currentCost = currentCost;
            Manager = manager;
            Budgets = new List<Budget>();
        }
        public  void addBudget(Budget value)
        {
          Budgets.Add(value);
        }
        public double getTotalBudget()
        {
                double total=0; 
                foreach(var item in Budgets)
                {
                    total+=item._value; 
                }
                return total; 
        }
         public void Print()
        {
            Console.WriteLine($"Project ID: {projectID}, Location: {_location}, Current Cost: {_currentCost}, Manager: {Manager._name}");
            Console.WriteLine("Budgets:");
            foreach (var budget in Budgets)
            {
                Console.WriteLine(budget);
            }
    }  
}
}

      

      

