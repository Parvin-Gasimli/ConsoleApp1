using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Employee
    {
     
        public static int TotalCount { get; set; } = 1000;
        public string No;
        public string FullName { get; set; }
        public string Position { get; set; }
        public List<Employee> Employees { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }
       
        public Employee(string fullname, string position, double salary, string departmentName)

        {
            Employees = new List<Employee>();

            FullName = fullname;
            Position = position;
            DepartmentName = departmentName;
            Salary = salary;
            TotalCount++;
          // No = departmentName.Trim().ToUpper()[0].ToString() + departmentName.Trim().ToUpper()[1].ToString() + TotalCount.ToString();
            No = departmentName.ToString().Trim().ToUpper().Substring(0, 2) + TotalCount.ToString();//bu method bize departmantname 2 sozu ile totatl count birlesdirir.
            
        }

       
        public override string ToString()
        {
            return $"Nomresi:{No} / Maas:{Salary}   /Departament Adi:{DepartmentName}      /Vezifesi:{Position}     /Adi  ve  Soyadi:{FullName}";
        }
    }  }
