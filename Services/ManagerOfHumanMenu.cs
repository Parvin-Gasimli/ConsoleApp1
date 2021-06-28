using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class ManagerOfHumanMenu
    {
        //managerOfhumanmenu My goal in creating this manager ofHuman  is to have less code capacity in the program cs and more selectable readable code.

        static ManagerOfHuman manager = new ManagerOfHuman();

        public static void AddDepartmentMenu()
        {

            Console.WriteLine("Enter the departmentName:");//cosnsole.readline user terefinden daxil olunmasin istediyimiz datalar ucun yazlb
            string departmentName = Console.ReadLine(); //string name, int workerlimit, double salarylimit
            Console.WriteLine("enter the workerlimit:");
            int workerLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the salaryLimit:");
            int salaryLimited = int.Parse(Console.ReadLine());
            try
            {
                manager.AddDepartment(departmentName, workerLimit, salaryLimited);
            }
            catch (Exception e)
            {

                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message);
            }
        }///tring fullname, string position, int salary, string departmentname
        public static void AddEmployee()
        {
            Console.WriteLine("Enter the fullname:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter the position:");
            string position = Console.ReadLine();
            Console.WriteLine("enter the salary:");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the department Name");
            string DepartmentName = Console.ReadLine();
            try
            {
                manager.AddEmployee(fullName, position, salary, DepartmentName);
            }
            catch (Exception e)
            {

                Console.WriteLine("Something went Wrong!!");
                Console.WriteLine(e.Message);
            }
        }
        //string name, string newName

        public static void EditDepartamentsMenu()
        {
            Console.WriteLine("Enter the Department:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the newDepartmentName:");
            string Newname = Console.ReadLine();
            try
            {
                manager.EditDepartaments(name, Newname);
            }
            catch (Exception e)
            {

                Console.WriteLine("wrong name!!! please enter the correct Name");
                Console.WriteLine(e.Message);
            }

        }
        //string no, string fullname , int salary, string position)

        public static void EditEmployee() //CHANGE THE SALARY POSITION 
        {     

          
            try
            {
                foreach (Department department in manager.Departments)
                {
                    foreach (Employee employee in department.Employees)
                    {
                        Console.WriteLine("Enter ID of the worker you want to edit.");
                        string NO = Console.ReadLine();
                        if (employee.No == NO)
                        {

                            Console.WriteLine($"ID: {employee.No} | Name: {employee.FullName} | Position: {employee.Position} | Salary: {employee.Salary}");
                            Console.WriteLine("Enter new Position");
                            string newposition = Console.ReadLine();
                            Console.WriteLine("Enter new Salary");
                            double newsalary = double.Parse(Console.ReadLine());

                            Console.WriteLine($"{NO}, New Salary: {newsalary}, New Position: {newposition}");

                        }
                        else
                        {
                            Console.WriteLine("Worker doesn't exist");
                        }

                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("wrong the edit employee");
                Console.WriteLine(e.Message);
            }

        }
        public static void GetDepartmentsMenu()
        {

            try
            {
                foreach (var item in manager.GetDepartments())
                {
                    Console.WriteLine($"  Department name: {item.DepartmentName} | Average salary: {item.CalcSalaryAverage()} | Number of employees: {item.Employees.Count}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message);
            }
        }
        //string no, string departmentname)
        public static void RemoveEmployeeMenu()
        {
            
                Console.WriteLine("Enter the No");
            string no = Console.ReadLine();
            Console.WriteLine("Enter the DepartmentName");
            string departmentname = Console.ReadLine();
           manager.RemoveEmployee(no, departmentname);
                  
            
        }
        public static void GetEmployees()
        {
            Console.WriteLine("Enter the name");
            try
            {
                foreach (var item in manager.GetEmployees())
                {
                    Console.WriteLine($"ID: {item.No} | Name: {item.FullName} | Position: {item.Position} | Salary: {item.Salary} | Department name: {item.DepartmentName}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("wrong the fullname");
                Console.WriteLine(e.Message);
            }


        }
        public static void GetEmployeesByDepartment()
        {
            Console.WriteLine("Enter the name of the department");
            string departmentname = Console.ReadLine();
            try
            {
                foreach (var item in manager.GetEmployeesByDepartment(departmentname))
                {
                    Console.WriteLine($"ID: {item.No} | Name: {item.FullName} | Position: {item.Position} | Salary: {item.Salary}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
    
