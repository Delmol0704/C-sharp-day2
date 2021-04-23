using System;
					
public class Program
{
	public static int show(params int[] num)
		{
			int res = 1;
			foreach (var item in num)
			{
				res = res*item;
			}
			return res;
		}
	public static void Main()
	{
		int x = show(10, 20, 20, 10);
		Console.WriteLine(x);	
	}
}