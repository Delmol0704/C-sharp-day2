using System;
					
public class Program
{
	public static void Main()
	{
	
		Console.WriteLine("Enter value");
		var a = Console.ReadLine();
		int result;
		int.TryParse(a, out result);
		if (result == 0)
			Console.WriteLine("It is not a number");
		else
			Console.WriteLine("It is a number");
	}
}