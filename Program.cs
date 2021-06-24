using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Resul","dadasov","Front Developer",3400,"It academy");
            Console.WriteLine(employee1);
            Department department = new Department("acadmy", 23, 500);
            Console.WriteLine(department);
            IList<Employee> employees = new List<Employee>();
         
           
           



        }
    }
}
