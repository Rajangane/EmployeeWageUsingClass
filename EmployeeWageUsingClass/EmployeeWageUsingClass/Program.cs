// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("************* Employee Wage Using Class ***************");
*/
using EmployeeWageUsingClass;
Console.Write("Select Number:\n1)ComputeEmployeeWage\n2)EmpMulttipleCompany\n3)saveWage\n4)IinterfaceComputeEmpWage\n");
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
    case 3:
        SaveWage s = new SaveWage("Demart", 10, 20, 30);
        SaveWage s1 = new SaveWage("vishal", 10, 20, 30);
        s.ComputeWage();
        Console.WriteLine(s.ToString());
        s1.ComputeWage();
        Console.WriteLine(s1.ToString());
        break;
    case 4:
        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
        empWageBuilder.addCompanyEmpWage("Dmart", 20, 20, 10);
        empWageBuilder.addCompanyEmpWage("Vishal", 10, 20, 50);
        empWageBuilder.ComputeEmpWage();
        Console.WriteLine("total wage for Dmart company : " + empWageBuilder.getTotalWage("Dmart"));
        break;

    default:
        Console.WriteLine("\n invalid choice");
            break;
}