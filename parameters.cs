using System;
					
public class Program
{
	public static void addstring(string s1, string s2, string s3=" ")
		{
			Console.WriteLine(s1+s3+s2);
		}
	public static void Main()
	{
		//named parameter
		/*
		addstring(s1:"Delmol", s3:" ", s2:"Denny");
		*/
		
		//optional parameter
		addstring("Delmol","Denny");
		
	}
}