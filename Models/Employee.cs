using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Employee
    {
        public static int TotalCount = 1000;

        public string No { get; set; }
        public string FullName;
       
       
      

        public string Position { get; set; }
        public int Salary { get; set; }
        public string DepartmentName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public Employee(string name, string surname, string position, int salary, string departmentName)

        {
            Name = name;
            Surname = surname;

            FullName = Name + " " + Surname;
            Position = position;
            DepartmentName = departmentName;
            Salary = salary;
            TotalCount++;
           // No = departmentName.Trim().ToUpper()[0].ToString() + departmentName.Trim().ToUpper()[1].ToString() + TotalCount.ToString();
            No = departmentName.ToString().Trim().ToUpper().Substring(0, 2) + TotalCount.ToString();
            
        } 

        public override string ToString()
        {
            return $"{No},{Salary},{DepartmentName},{Position},{FullName}";
        }
    }  }
