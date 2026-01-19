// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    string? input = Console.ReadLine();

    string[] inputArray = input.Split(" ");
    if (inputArray.Length > 3) {
        throw new Exception("Error:InvalidExpression");
    }
    if (!inputArray[0].All(Char.IsDigit) || !inputArray[2].All(Char.IsDigit)){
        throw new Exception("Error:Invalid Number");
    }


int num1 = Convert.ToInt32(inputArray[0]);
int num2 = Convert.ToInt32(inputArray[2]);

    if (num2 == 0) throw new Exception("Error:DivideByZero");
    string op = inputArray[1];




    switch (op)
    {
        case "+":

            int res = num1 + num2;
            Console.WriteLine("The result is " + res);
            break;

        case "-":
            int res2 = num1 - num2;
            Console.WriteLine("The result is " + res2);
            break;

        case "*":
            int res3 = num1 - num2;
            Console.WriteLine("The result is " + res3);
            break;
        case "/":
            int res4 = num1 / num2;
            Console.WriteLine("The result is " + res4);
            break;
        default:
            throw (new Exception("Error:UnknownOperator"));

    }

}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}

