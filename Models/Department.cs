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
        public int WorkerLimit  { get; private set; }
        public double SalaryLimit { get; private set; }
        public List<Employee> Employees { get; set; }
        public string Name { get; internal set; }

        public Department(string Departmentname,int worklimit,double Salarylimit)
        {
            DepartmentName = Departmentname;
            WorkerLimit = worklimit;
            SalaryLimit = SalaryLimit;
        }


        public double CalcSalaryAverage()
        {
            
           
            double average =0;
            double sum = 0;
            foreach (var item in Employees)
            {
                sum += item.Salary;
            }
            
            average = sum / Employees.Count;
            return average;
            //calculation of the average
        }


    }
}
