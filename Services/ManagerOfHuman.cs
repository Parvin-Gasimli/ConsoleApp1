using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    class ManagerOfHuman : IHumanResourceManager
    {
        public List<Department> Departments { get ; set ; }
        public List<Employee> Employees { get; set; }
        public List<Department> department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ManagerOfHuman() 
        {
            
            Departments = new List<Department>();
        }
        public void AddDepartment(string name, int workerlimit, double salarylimit)
        {
            Department department = new Department(name, workerlimit, salarylimit);
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name is empty");
            if (workerlimit<=0)
                throw new ArgumentNullException("Worker limit is less than zero");
            if (salarylimit <= 250)
                throw new ArgumentNullException("salarylimit is less than  250");
            Departments.Add(department);
        }
        public void AddEmployee(string name, string surname, string position, int salary, string departmentname)
        {
            Employee employee = new Employee(name, surname, position, salary, departmentname);
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(" name can not be empty or null");
            if (string.IsNullOrEmpty(surname))
                throw new ArgumentNullException(" surname can not be empty or null");
            if (string.IsNullOrEmpty(position))
                throw new ArgumentNullException("Position can not be empty or null");
            if (salary < 250)
                throw new ArgumentOutOfRangeException("Salary can not be less than 250 AZN");
            if (string.IsNullOrEmpty(departmentname))
                throw new ArgumentNullException("Department name can not be empty or null");
            var department = Departments.Find(s => s.Name == departmentname);
            if (department == null)
                throw new ArgumentNullException("There is no such department");
           
            department.Employees.Add(employee);
        }
        public void EditDepartaments(string name, string newName)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(newName))
                throw new ArgumentNullException("Department name can not be empty or null");
            var department = Departments.Find(s => s.Name == name);
            if (department == null)
                throw new ArgumentNullException("There is no such department");
            department.Name = newName;
        }
        public void EditEmployee(string no, string name,string surname, int salary, string position)
        {
            if (salary <= 250)
                throw new ArgumentOutOfRangeException("salary is less than 250");
           var employee= Employees.Find(a => a.No == no);
            employee.Name = name;
            employee.Surname = surname;
            employee.Salary = salary;
            employee.Position = position;
        }
        public List<Department> GetDepartments()
        {
            
        }
        public void RemoveEmployee(string no, string departmentname)
        {
            throw new NotImplementedException();
        }
        public string[] SearchEmployee(string search)
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(string fullname, string position, int salary, string departmentname)
        {
            throw new NotImplementedException();
        }
    }
}
