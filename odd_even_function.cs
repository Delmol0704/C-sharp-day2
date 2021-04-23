using System;
					
public class Class1
{
	void CheckOddEven(int a)
	{
		if(a%2==0)
			Console.WriteLine("Even");
		else
			Console.WriteLine("Odd");
	}	
							 
		
	public static void Main()
	{
		Class1 class1= new Class1();
		Console.WriteLine("Enter value");
		int num = Convert.ToInt32(Console.ReadLine());						 
		class1.CheckOddEven(num);
	}
}