using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter some value");
        var x = Console.ReadLine();
        Console.WriteLine(x);
        Console.WriteLine(x.GetType());
	}
}