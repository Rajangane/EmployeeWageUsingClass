// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("************* Employee Wage Using Class ***************");
*/
using EmployeeWageUsingClass;
Console.Write("Select Number:\n1)ComputeEmployeeWage\n2)EmpMulttipleCompany\n");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        new ComputeEmployeeWage().ComputeWage();
        break;
    case 2:

        new EmpMultipleCompany().Compute("Dmart", 10, 20, 30);
        new EmpMultipleCompany().Compute("vishal", 10, 40, 50);
        break;
    default:
        Console.WriteLine("\n invalid choice");
            break;
}