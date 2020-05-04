
LSP : Liskov Substitution Principle - Code Smells

1) If checks that verify the type of the object

foreach (var employee in Employees)
{
	// Employees - Collection of base type
	if(employee is Manager)
	{
		Console.WriteLine("Employee is a Manager");
	}
	else{
		Console.WriteLine("Employee is not Mananger")
	}
	// other verifications

}

2) Child class does not fully implement this Base Class(can be an interface also)

public abstract class Base
{
	public abstract void Method1();
	public abstract void Method2();
}

//very common cases 
public class Child : Base
{
	// clients of the code expect to implement all the methods from the base
	public override void Method1()
	{
		throw new NotImplementedException();
	}
	public abstract void Method2()
	{
		//here is the code
	}
}