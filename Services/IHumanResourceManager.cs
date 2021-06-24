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
        List<Department> department { get; set; }


        void AddDepartment(string name, int workerlimit, int salarylimit);
        void EditDepartaments(string name, string newName);
        List<Department> GetDepartments();
        void AddEmployee(string fullname, string position, int salary, string departmentname);

        void EditEmployee(string no, int salary, string position);

        void RemoveEmployee(string no, string departmentname);

        string[] SearchEmployee(string search);


    }
}

