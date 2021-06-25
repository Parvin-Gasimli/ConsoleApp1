using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Services;



namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {

            string ans;

            do
            {
                Console.WriteLine("\n====================================================\n");
                Console.WriteLine("1.1 - Departamentlerin siyahisini gostermek");
                Console.WriteLine("1.2 - Yeni Department yaratmaq");
                Console.WriteLine("1.3 - Departamen uzerinde deyisiklik etmek");
                Console.WriteLine("2.1 - Butun iscilerin siyahisini gostermek");
                Console.WriteLine("2.2 - Departamentdeki iscilerin siyahisini gostermek");
                Console.WriteLine("2.3 - Isci elave etmek");
                Console.WriteLine("2.4 - Isci uzerinde deyisiklik etmek");
                Console.WriteLine("2.5 - Departamentden isci silinmesi");
                Console.WriteLine("3 - sistemden cixis");

                Console.WriteLine("\nIcra etmek istediyiniz emeliyyati secin:");
                ans = Console.ReadLine();

                Console.WriteLine("\n====================================================\n");

                switch (ans)
                {
                    case "1.1":
                        ManagerOfHumanMenu.GetDepartmentsMenu();
                        break;
                    case "1.2":
                        ManagerOfHumanMenu.AddDepartmentMenu();

                        break;
                    case "1.3":
                        ManagerOfHumanMenu.EditDepartaments();
                        break;
                    case "2.1":
                        ManagerOfHumanMenu.EditEmployee();
                        break;
                    case "2.2":
                        ManagerOfHumanMenu.GetEmployees();
                        break;
                    case "2.3":
                        ManagerOfHumanMenu.AddEmployee();

                        break;
                    case "2.4":
                        ManagerOfHumanMenu.EditEmployee();
                        break;
                    case "2.5":
                        ManagerOfHumanMenu.RemoveEmployeeMenu();
                        break;

                    default:
                        if (ans != "3")
                        {
                            Console.WriteLine("Duzgun deyer daxil edilmedi");
                        }
                        break;

                }

            } while (ans != "3");
            //        int option = 0;

            //        do
            //        {
            //            Console.WriteLine("1. Departments");
            //            Console.WriteLine("2. Employees");
            //            Console.WriteLine("0 .Exit");
            //            Console.WriteLine("Please, enter a selection");
            //            string optionstr = Console.ReadLine();
            //            while (!int.TryParse(optionstr, out option))
            //            {
            //                Console.WriteLine("Enter a number, please");
            //                optionstr = Console.ReadLine();
            //            }
            //            switch (option)
            //            {
            //                case 1:
            //                    int option1 = 0;
            //                    do
            //                    {
            //                        Console.WriteLine("1. Add department");
            //                        Console.WriteLine("2. Edit Department");
            //                        Console.WriteLine("3. Show departments");
            //                        Console.WriteLine("0. Back");
            //                        Console.WriteLine("Please, enter a selection");
            //                        string optionstr1 = Console.ReadLine();
            //                        while (!int.TryParse(optionstr1, out option1))
            //                        {
            //                            Console.WriteLine("Enter a number, please");
            //                            optionstr1 = Console.ReadLine();
            //                        }
            //                        switch (option1)
            //                        {
            //                            case 1:
            //                                ManagerOfHumanMenu.AddDepartmentMenu();
            //                                break;
            //                            case 2:
            //                                ManagerOfHuman.();
            //                                break;
            //                            case 3:
            //                                ManagerOfHumanMenu.GetDepartmentsMenu();
            //                                break;
            //                            case 0:
            //                                break;
            //                            default:
            //                                Console.WriteLine("There is no such option!");
            //                                break;
            //                        }
            //                    } while (option1 != 0);
            //                    break;
            //                case 2:
            //                    int option2 = 0;
            //                    do
            //                    {
            //                        Console.WriteLine("1. Add employee");
            //                        Console.WriteLine("2. Edit employee");
            //                        Console.WriteLine("3. Remove employee");
            //                        Console.WriteLine("4. Show employees");
            //                        Console.WriteLine("0. Back");
            //                        Console.WriteLine("Please, enter a selection");
            //                        string optionstr2 = Console.ReadLine();
            //                        while (!int.TryParse(optionstr2, out option2))
            //                        {
            //                            Console.WriteLine("Enter a number, please");
            //                            optionstr2 = Console.ReadLine();
            //                        }
            //                        switch (option2)
            //                        {
            //                            case 1:
            //                                ManagerOfHumanMenu.AddEmployeeMenu();
            //                                break;
            //                            case 2:
            //                                ManagerOfHumanMenu.EditEmployeeMenu();
            //                                break;
            //                            case 3:
            //                                ManagerOfHumanMenu.RemoveEmployeeMenu();
            //                                break;
            //                            case 4:
            //                                ManagerOfHumanMenu.GetEmployeesMenu();
            //                                break;
            //                            case 0:
            //                                break;
            //                            default:
            //                                Console.WriteLine("There is no such option!");
            //                                break;
            //                        }
            //                    } while (option2 != 0);
            //                    break;
            //                case 0:
            //                    Console.WriteLine("Shutting down...");
            //                    break;
            //                default:
            //                    Console.WriteLine("There is no such option!");
            //                    break;
            //            }
            //        } while (option != 0);
            //    }
            //}


        }
    }
}





