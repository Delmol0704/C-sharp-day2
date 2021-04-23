using System;
					
class Dog 
{
	public void speak()
	{
		Console.WriteLine("Bark  !");
	}
}
class class7
{
	static void main()
	{
		Object o = new Dog();
	 	Dog dog = o as Dog;
	 	if (dog != null)
		 	dog.speak();
	}
}
			