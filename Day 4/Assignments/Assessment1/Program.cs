// See https://aka.ms/new-console-template for more information
using Assessment1;

Console.WriteLine("Hello, World!");


Employee emp1 = new Employee();


System.Console.Write("Enter the Employee ID: ");
emp1.EmpID = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter the Employee Name: ");
emp1.Name = Console.ReadLine();


System.Console.Write("Enter the Employee Age: ");
emp1.Age = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter the Employee Department: ");
Console.WriteLine("1 - IT");
Console.WriteLine("2 - HR");
Console.WriteLine("3 - Finance");

emp1.DepChoice = Convert.ToInt32(Console.ReadLine());


string departmentName=String.Empty; //Sir ne bataya tha to use String.Empty rather than " "

string role = String.Empty;

int allowance = 0;

switch (emp1.DepChoice)
{
    case 1:
        departmentName = "IT";
        System.Console.WriteLine("Enter The Role: 1 for Developer OR 2 for Tester");
        int roleChoice = Convert.ToInt32(Console.ReadLine());

        // Yahan par we can do hygeine check for role choice but abhi nhi kar raha sir se puchunga

        switch (roleChoice)
        {
            case 1:
                role = "Developer";
                allowance = 30;
                break;
            case 2:
                role = "Tester";
                allowance = 25;
                break;
        }

        break;

    case 2:
        departmentName = "HR";
        System.Console.WriteLine("Enter The Role: 1 for Recruiter OR 2 for Payroll");
        
        int roleChoiceHR = Convert.ToInt32(Console.ReadLine());


        switch (roleChoiceHR)
        {
            case 1:
                role = "Recruiter";
                allowance = 20;
                break;
            case 2:
                role = "Payroll";
                allowance = 22;
                break;
        }

        break;

    case 3:
        departmentName = "Finance";
        System.Console.WriteLine("Enter The Role: 1 for Accountant OR 2 for Auditor");
        
        int roleChoiceFin = Convert.ToInt32(Console.ReadLine());


        switch (roleChoiceFin)
        {
            case 1:
                role = "Accountant";
                allowance = 28;
                break;
            case 2:
                role = "Auditor";
                allowance = 26;
                break;
        }

        break;


    
}


Console.Write("Enter the Basic Salary: ");
emp1.BasSal = Convert.ToDouble(Console.ReadLine());

double finalSalary = emp1.BasSal + (emp1.BasSal * allowance / 100);

string accessLevel = String.Empty;

if(finalSalary >=60000 && departmentName == "IT")
{
    accessLevel = "Admin Access";;
}

else if(finalSalary >= 60000)
{
    accessLevel = "Manager Access";
}


else
{
    accessLevel = "Employee Access";
}




System.Console.WriteLine("The Final Details are: ");
System.Console.WriteLine($"The Employee ID is {emp1.EmpID} \n The Name of the Employee is: {emp1.Name} \n  The Department of working is:  {departmentName} \n The Role is: {role} \n The basic Salary is {emp1.BasSal} \n The final Salary is: {finalSalary} \n The Access Level is: {accessLevel}");

