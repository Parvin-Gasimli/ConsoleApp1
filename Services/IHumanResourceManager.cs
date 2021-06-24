using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    interface IHumanResourceManager

    {
        //created the Department list 

        void AddDepartment(string name, int workerlimit, double salarylimit);
        void EditDepartaments(string name, string newName);
        List<Department> GetDepartments();
        void AddEmployee(string name, string surname, string position, int salary, string departmentname);

        void EditEmployee(string no, string name, string surname, int salary, string position);

        void RemoveEmployee(string no, string departmentname);

       // string[] SearchEmployee(string search);


    }
}

