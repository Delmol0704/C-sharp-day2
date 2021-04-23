using System;
					
public class Program
{
	public static void Main()
	{
		/*
		//string operations
		string sample = "     Dummy   ";
		string sample1 = "Dummy1";
		Console.WriteLine(string.Compare(sample,sample1));    //prints 0 or -1
		Console.WriteLine(sample.Trim());
		Console.WriteLine(sample.ToLower());
		*/
		
		/*
		//palindrome
		Console.WriteLine("Enter a string");
		string input_string = Console.ReadLine();
		char[] rev_array = new char[input_string.Length];
		for (int i=input_string.Length-1; i>=0; i--)
		{
			rev_array[i] = input_string[i];
		}
		string rev_string = new string(rev_array);
		if(rev_string == input_string)
			{
				Console.WriteLine("Palindrome");
			}
		else
			{
				Console.WriteLine("Not Palindrome");
			}
		*/
		
		/*
		//no. of vowels
		Console.WriteLine("enter string");
		string str = Console.ReadLine();
		int cons=0, vowel=0;
		for(int i=0; i<str.Length; i++)
		{
			if(str[i]=='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u')
				vowel++;
			else
				cons++;
		}
		Console.WriteLine("no. of vowels = "+vowel);
		Console.WriteLine("no. of consonents = "+cons);	
		*/
		
		//maximum occuring charcter
		Console.WriteLine("enter string");
		string inputString = Console.ReadLine();
		int[] charCount = new int[256];
		int length = inputString.Length;
		for(int i=0; i<inputString.Length; i++)
		{
			charCount[inputString[i]]++;
		}
		int maxcount = -1;
		char character = ' ';
		for(int j=0; j<length; j++)
		{
			if( maxcount < charCount[inputString[j]])
			   {
				   maxcount = charCount[inputString[j]];
				   character = inputString[j];
			   }
		}
			   Console.WriteLine("Maximum occurng character is : "+character+" and count is "+maxcount);
			   
 	}
}