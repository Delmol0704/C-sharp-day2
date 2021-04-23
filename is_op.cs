using System;
					
public struct Person
{
	public string Name {get;set;}
	public Person(string _name)
	{
		Name= _name;
	}
}
public struct Dog
{
	public string Breed {get;set;}
	public Dog(string _breed)
	{
		Breed= _breed;
	}
}
class class6
{
	public static void showvalue(Object o)
	{
		if(o is Person p)
		{
			Console.WriteLine(p.Name);
		}
		else if(o is Dog d)
		{
			Console.WriteLine(d.Breed);
		}
	}
	static void main()
	{
		Object o = new Person("Delmol");
		showvalue(o);
		o = new Dog("Husky");
		showvalue(o);
	}
}

			