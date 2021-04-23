using System;
					
public class Class1
{
	void OUT(out int x)
	{
		x = 8;
	}	
							 
		
	public static void Main()
	{
		Class1 class1= new Class1();
		int x = 5;
		
		Console.WriteLine("Inside main function");
		Console.WriteLine("x = "+x);
		
		class1.OUT(out x);
		Console.WriteLine("after OUT");
		Console.WriteLine("x = "+x);
		
		
	}