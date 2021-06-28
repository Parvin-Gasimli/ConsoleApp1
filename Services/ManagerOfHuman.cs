using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ManagerOfHuman : IHumanResourceManager
{

          //This class inherits all the data from the interface because it is not possible to write the body in the interface,
         //so in this class the body of the methods in the interface is written.
        //where we implement all the methods in the interface and write the bodies
    public List<Department> Departments { get; set; }
    public List<Employee> Employees { get; set; }

    public ManagerOfHuman()
    {
        Employees = new List<Employee>();// emplotyers add the employers list

        Departments = new List<Department>();//Departmetns data add the departments list 
    }
    public void AddDepartment(string name, int workerlimit, int salarylimit)// using isNullorEmpty //using type of exception    
    {
        Department department = new Department(name, workerlimit, salarylimit);
        if (string.IsNullOrEmpty(name))
            throw new ArgumentNullException("Name is empty");
        if (workerlimit <= 0)
            throw new ArgumentNullException("Worker limit is less than zero");
        if (salarylimit <= 250)
            throw new ArgumentNullException("salarylimit is less than  250");
        Departments.Add(department);
    }
    public void AddEmployee(string fullname, string position, double salary, string departmentname)

    {

        Employee employee = new Employee(fullname, position, salary, departmentname);
        if (string.IsNullOrEmpty(fullname))
            throw new ArgumentNullException(" fullname can not be empty or null");

        if (string.IsNullOrEmpty(position))
            throw new ArgumentNullException("Position can not be empty or null");
        if (salary <= 250)

            throw new ArgumentOutOfRangeException("Salary can not be less than 250 AZN");
        if (string.IsNullOrEmpty(departmentname))
            throw new ArgumentNullException("Department name can not be empty or null");
        var department = Departments.Find(s => s.DepartmentName == departmentname);
        if (department == null)
            throw new ArgumentNullException("There is no such department");
        


        department.Employees.Add(employee);
    }
    public void EditDepartaments(string name, string newName)   //old name turn the NewNAME
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(newName))
            throw new ArgumentNullException("Department name can not be empty or null");
        var department = Departments.Find(s => s.DepartmentName == name);
        if (department == null)
            throw new ArgumentNullException("There is no such department");
        department.DepartmentName = newName;
    }
    public void EditEmployee(string no, string fullname, double salary, string position)
    {
        if (salary < 250)
            throw new ArgumentOutOfRangeException("salary is less than 250");
        var employee = Employees.Find(a => a.No == no);
        

        employee.Salary = salary;
        employee.Position = position;
        employee.FullName = fullname;
    }
    public List<Department> GetDepartments()
    {
        if (Departments.Count == 0)
            throw new KeyNotFoundException("List is empty");
        return Departments.ToList();
    }
    public void RemoveEmployee(string no, string departmentname)//remove the employye the no and the departmentname
    {
        if (string.IsNullOrEmpty(no))
            throw new ArgumentNullException("No can not be empty or null");
        List<int> tempcheck = new List<int>() { };
        foreach (var item in Departments)
        {
            int index = item.Employees.FindIndex(s => s.No == no && s.DepartmentName == departmentname);//check the equals
            tempcheck.Add(index);
            if (index > -1)
            {
                item.Employees.RemoveAt(index);
            }
        }
        if (tempcheck.Sum() / tempcheck.Count == -1)
        {
            throw new KeyNotFoundException("There is no such employee with a given no");
        }
        RemoveEmployee(no, departmentname);
    }
    public List<Employee> GetEmployees()
    {
        List<Employee> Temp = new List<Employee>();
        foreach (var item in Departments)// dovr icinde dovr olmaq ve ordakilari employer listine include etmek  lazmdir
        {
            foreach (var item1 in item.Employees)
            {
                Temp.Add(item1);
            }
        }
        if (Temp.Count == 0)
            throw new KeyNotFoundException("List is empty");
        return Temp.ToList();
    }
    public List<Employee> GetEmployeesByDepartment(string departmentname) 
    {
        var department = Departments.Find(a => a.DepartmentName == departmentname);
        if (department == null) //whether if department is null show  threre is no such a department
            throw new ArgumentNullException("There is no such department!");
        return department.Employees.ToList();
    }

}
