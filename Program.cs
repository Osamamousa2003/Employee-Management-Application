
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var staff_Service=new Staff();
            bool key=true; 
            while(key)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Department");
                Console.WriteLine("2. Staff");
                Console.WriteLine("3. Project");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                 switch (choice)
                 {
                    case 1:
                    MangerDepartments(staff_Service);
                    break;
                    case 2: 
                    MangerStaff(staff_Service);
                    break;
                    case 3:
                    ManageProjects(staff_Service);
                    break; 
                    case 4:
                        key = false;
                        break;
                    default: 
                    Console.WriteLine("Invalid choice. Please try again.");
                        return;
                 }
            }
        }
        static void MangerDepartments(Staff staff_service)
        {
            Console.WriteLine("\nDepartment Management:");
            Console.WriteLine("1. Add New Department");
            Console.WriteLine("2. Print All Departments");

            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
             case 1:
             Console.Write("Enter Department ID: ");
             int id = int.Parse(Console.ReadLine());
             Console.Write("Enter Department Name: ");
             string name  = Console.ReadLine();
         
             var _department=new Department(id , name);
             staff_service.AddDepartment(_department);
             break;

             case 2:
             staff_service.PrintAllDepartment();
              break;
              default:
               Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        static void  MangerStaff(Staff staff_service)
        { 

            Console.WriteLine("\nStaff Management:");
            Console.WriteLine("1. Add New Members");
            Console.WriteLine("2. Print All Members");
            Console.WriteLine("3. Calculate Payroll");
            Console.WriteLine("4. Delete Member");
            
               int choice = int.Parse(Console.ReadLine());

               switch(choice)
            {
             case 1:

             Console.Write("Enter Member ID: ");
             int _id = int.Parse(Console.ReadLine());
             Console.Write("Enter Member Name: ");
             string _name  = Console.ReadLine();
             Console.Write("Enter Member Phone: ");
             string _phone  = Console.ReadLine();
             Console.Write("Enter DMember email: ");
             string _email  = Console.ReadLine();
              Console.Write("Enter Department ID: ");
             int deptId = int.Parse(Console.ReadLine());
             var _department = new Department(deptId, "");
             Console.Write("Enter Member Type (Employee/Volunteer): ");
             string type = Console.ReadLine();
              StaffMember member = null;
                    if (type.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter Social Security Number: ");
                        string ssn = Console.ReadLine();
                        Console.Write("Enter Employee Type (Hourly/Salary/Commission): ");
                        string empType = Console.ReadLine();
                        switch (empType.ToLower())
                        {
                            case "hourly":
                                Console.Write("Enter Hourly Rate: ");
                                double rate = double.Parse(Console.ReadLine());
                                Console.Write("Enter Hours Worked: ");
                                int hours = int.Parse(Console.ReadLine());
                                member = new Hourlay_Emp(_id, _name,_phone, _email, _department, ssn, rate, hours);
                                break;
                            case "salary":
                                Console.Write("Enter Salary: ");
                                double salary = double.Parse(Console.ReadLine());
                                member = new Salaried_Emp(_id, _name, _phone, _email, _department, ssn, salary);
                                break;
                            case "commission":
                                Console.Write("Enter Salary: ");
                                double commSalary = double.Parse(Console.ReadLine());
                                Console.Write("Enter Bonus: ");
                                double bonus = double.Parse(Console.ReadLine());
                                member = new Commission_Emp(_id, _name, _phone, _email, _department, ssn, commSalary, bonus);
                                break;
                            
                            default:
                                Console.WriteLine("Invalid employee type.");
                                break;
                        }
                    }
                    else if (type.Equals("Volunteer", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter Value: ");
                        double value = double.Parse(Console.ReadLine());
                        member = new Volunteer(_id, _name, _phone, _email, _department, value);
                    }
                    staff_service.add_Member(member);
                    break;
                case 2:
                    staff_service.PrintAllMembers();
                    break;
                case 3:
                  staff_service.CalculatePayroll();
                    break;
                case 4:
                    Console.Write("Enter Member ID to Delete: ");
                    int memberId = int.Parse(Console.ReadLine());
                   staff_service.del_Member(memberId);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;   
            }
        }


        static void ManageProjects(Staff staff_service)
        {
            Console.WriteLine("\nProject Management:");
            Console.WriteLine("1. Add New Project");
            Console.WriteLine("2. Print All Projects");
            Console.WriteLine("3. Add Budget to Existing Project");
            Console.WriteLine("4. Increase Budget to Existing Project");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Project ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Location: ");
                    string location = Console.ReadLine();
                    Console.Write("Enter Current Cost: ");
                    double currentCost = double.Parse(Console.ReadLine());
                    Console.Write("Enter Manager ID: ");
                    int managerId = int.Parse(Console.ReadLine());
                    var manager = new Employee(managerId, "", "", "", new Department(0, ""), ""); 
                    var project = new Project(id, location, currentCost, manager);
                    staff_service.Add_project(project);
                    break;
                case 2:
                   staff_service.PrintAllProjects();
                    break;
                case 3:
                    Console.Write("Enter Project ID: ");
                    int projId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Budget Value: ");
                    double _value = double.Parse(Console.ReadLine());
                    var budget = new Budget(1, _value); 
                    staff_service.AddBudgetToProject(projId, budget);
                    break;
                case 4:
                    Console.Write("Enter Project ID: ");
                    int pId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Budget ID: ");
                    int bId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Budget Increase Amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    staff_service.IncreaseBudgetToProject(pId, bId, amount);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
     }
}