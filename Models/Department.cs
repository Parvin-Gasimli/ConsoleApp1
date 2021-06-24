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
        public int WorkerLimit  { get; set; }
        public double SalaryLimit { get; set; }
        public IList<Employee> employees { get; set; }
        public Department(string Departmentname,int worklimit,double Salarylimit)
        {
            DepartmentName = Departmentname;
            WorkerLimit = worklimit;
            SalaryLimit = SalaryLimit;
        }
       
        public Department(Employee employees)
        {

        }
        public double CalcSalaryAverage(List<Employee>employees)
        {
            double average =0;
            double sum = 0;
            foreach (Employee item in employees)
            {
                sum += item.Salary;
            }
            
            average = sum / employees.Count;
            return average;
            //calculation of the average
        }


    }
}
