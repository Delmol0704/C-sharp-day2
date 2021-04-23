using System;
					
public class Author1
{
	public string name1;
	public int rank1;
}
public class Author2
{
	public string name2;
	public int rank2;
	public static void Main()
	{
		Author2 author2 = new Author2();
		Author1 author1 = new Author1();
		bool result;
		result = author1 is Author1;
		Console.WriteLine(result);
		
	}
}