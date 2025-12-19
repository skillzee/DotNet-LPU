using System;

class AddProgDiscount
{
	static void Main()
	{
		int num1 = 100;
		int num2 = 200;
		int numResult;
		Console.Write("Enter First Number: ");
		num1=Int32.Parse(Console.ReadLine());
		Console.Write("Enter Second Number: ");
		num2=Int32.Parse(Console.ReadLine());


		//BL
		int disc = (num1+num2)*10/100;
		numResult = (num1+num2) - disc;

		Console.WriteLine("LPU Shoppee");
		Console.WriteLine("Price of Product 1 {0}", num1);
		Console.WriteLine("Price of Product 2 {0}", num2);
		Console.WriteLine("Total Price {0}", (num1+num2));
		Console.WriteLine("Discounted Price of Products {0}", disc);
		Console.WriteLine("Payable amount after Discount: {0}", numResult);						
	}	
}