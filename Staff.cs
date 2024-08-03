using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace EmployeeManagementApplication
{
    class Staff
    {
         private List<StaffMember> Staff_list=new List<StaffMember>();
        private List<Department> departments = new List<Department>();
         private List<Project> projects = new List<Project>();
        public void AddDepartment(Department department)
        {
            departments.Add(department);
            Console.WriteLine("Department added successfully.");
        }
        public void PrintAllDepartment()
        {  
             Console.WriteLine("Departments: ");
             foreach(var item in  departments)
             { 
                Console.WriteLine(item);
             }

        }
            public void add_Member(StaffMember  staffmember )
        { 
         Staff_list.Add(staffmember);
         Console.WriteLine("Member added successfully.");
        }
        public void PrintAllMembers()
        {
            Console.WriteLine("Staff Members:");
            foreach (var member in  Staff_list)
            {
                member.print();
            }
        }
        public void CalculatePayroll()
        {
            double totalPayroll = 0;
            foreach (var member in Staff_list)
            {
                totalPayroll += member.pay();
            }
            Console.WriteLine($"Total Payroll: {totalPayroll}");
        }
        public  void del_Member(int id)
        { 
            var member=Staff_list.Find(m=>m._employeeiD==id);
            if(member!=null)
            {
                 Staff_list.Remove(member);
                 Console.WriteLine("Member deleted successfully.");
            }
            else
            {
                Console.WriteLine("Member not found.");
            }
        }

        public void Add_project(Project _project)
        {
            projects.Add(_project);
            Console.WriteLine("Project added successfully.");
        }

        public void PrintAllProjects()
        {
            Console.WriteLine("Projects:");
            foreach (var project in projects)
            {
                project.Print();
            }   
        }
          public void AddBudgetToProject(int _projectId, Budget budget)
        {
            var project = projects.Find(p => p.projectID == _projectId);
            if (project != null)
            {
                project.addBudget(budget);
                Console.WriteLine("Budget added successfully.");
            }
            else
            {
               Console.WriteLine("Budget not found.");
            }

    }  
     public void IncreaseBudgetToProject(int _projectId, int budgetId, double amount)
    {
        var project = projects.Find(p => p.projectID== _projectId);
        if (project != null)
        {
            var budget = project.Budgets.Find(b => b._id == budgetId);
            if (budget != null)
            {
                budget.IncreaseBudget(amount);
                Console.WriteLine("Budget increased successfully.");
            }
            else
            {
                Console.WriteLine("Budget not found.");
            }
        }
        else
        {
            Console.WriteLine("Project not found.");
        }
    }
    }
}


      

      

