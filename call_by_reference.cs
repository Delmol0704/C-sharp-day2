using System;
					
public class Class1
{
	void swap(ref int x, ref int y)
	{
		int t;
		t=x;
		x=y;
		y=t;
		Console.WriteLine("Inside swap function");
		Console.WriteLine("x = "+x);
		Console.WriteLine("y = "+y);
	}	
							 
		
	public static void Main()
	{
		Class1 class1= new Class1();
		int x = 5;
		int y = 4;
		Console.WriteLine("Inside main function");
		Console.WriteLine("x = "+x);
		Console.WriteLine("y = "+y);
		class1.swap(ref x, ref y);
		Console.WriteLine("Inside main function");
		Console.WriteLine("x = "+x);
		Console.WriteLine("y = "+y);
		
	}
}