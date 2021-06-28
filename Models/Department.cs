using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Department
    {
        public string DepartmentName { get; set; }
        public int WorkerLimit  { get;  set; }
        public double SalaryLimit { get;  set; }
        public List<Employee> Employees { get; set; }
        public List<Department> Departments { get; set; }
        public string Name { get; internal set; }

        public Department(string Departmentname,int worklimit,double Salarylimit)
        {
            Employees = new List<Employee>();
            DepartmentName = Departmentname;
            WorkerLimit = worklimit;
            SalaryLimit = Salarylimit;
        }


        public double CalcSalaryAverage()
        {
            
           
         double average =0;
            double sum = 0;
            foreach (var item in Employees)
            {
                sum += item.Salary;
            }
            if (Employees.Count != 0)

            {
                average = sum / Employees.Count;
                return average;
            }
            else
            {
                return 0;
            }
            //if wirkerlimit is zero 


           
            //calculation of the average
        }
        
        }


    }

