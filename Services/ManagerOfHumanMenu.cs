using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class ManagerOfHumanMenu
    {
        static ManagerOfHuman manager = new ManagerOfHuman();
        public static void AddDepartmentMenu()
        {
            Console.WriteLine("Enter the departmentName:");
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

        public static void EditDepartaments()
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

        public static void EditEmployee()
        {

            Console.WriteLine("Enter the  No:");
            string no = Console.ReadLine();
            Console.WriteLine("Enter the FullName:");
            string fullname = Console.ReadLine();
            Console.WriteLine("Enter the salary:");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position:");
            string position = Console.ReadLine();
            try
            {
                manager.EditEmployee(no, fullname, salary, position);
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
                    Console.WriteLine(item.DepartmentName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message);
            }
        }
        //tring no, string departmentname)
        public static void RemoveEmployeeMenu()
        {
            Console.WriteLine("Enter the Name");
            string no = Console.ReadLine();
            Console.WriteLine("Enter the DepartmentName");
            string departmentname = Console.ReadLine();
            try
            {
                manager.RemoveEmployee(no, departmentname);
            }
            catch (Exception e)
            {

                Console.WriteLine("dont remove the employee");
                Console.WriteLine(e.Message);
            }
        }
        public static void GetEmployees()
        {
            Console.WriteLine("Get the name");
            try
            {
                foreach (var item in manager.GetEmployees())
                {
                    Console.WriteLine(item.FullName);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("wrong the fulname");
                Console.WriteLine(e.Message);
            }


        }
    }
}
