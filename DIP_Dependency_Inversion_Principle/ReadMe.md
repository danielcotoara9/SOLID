
DIP : Dependency Inversion Principle

- High-level modules should not depend on low level modules. Both should depend on abstractions.

- Abstraction should not depend on details. Details should depend on abstractions.

Would you solder a lamp directly to the electrical wiring in a wall? Please see image DIP from Images folder. 
	- We see there that is a common interface, which is our plug(US format). Using this "common interface" we are able 
		to plug in any number of different devices that implement that interface. That's what Dependency Inversion 
		allows us to do as well.
	- We can write our classes in such a way that their dependencies are exposed as interfaces, we are able to pass
		implementations of those interfaces just as we're able to plug in any particular device we want into the wall socket

-----------------------------------------------------------------------------------------------------------------------------
	Dependencies in .NET
		- Framework (3.1;4.5;... ) 
		- Access to Thrid Party Libraries (log4net)
		- DataBase 
		- File System
		- Email
		- Web Services
		.............


 - What are Dependencies ?

	If you're writing .net software you have taken a dependency on the .net platform, the .net framework, and more or less on Windows 
		unless you're developing for Mono, and this is something that is not, you know, within the scope of dependency inversion per se, 
		it's a dependency that you're probably pretty comfortable with and that you don't expect to change too much with the course of your software. 
	However, the dependencies we're talking about with regard to our application design are more low level and things that we are going to expect
		to possibly change as part of our application during its lifetime. For example, access to Third Party Libraries. 
		These can often be things that will change frequently and, therefore, if possible we want to be able to inject alternate implementations 
		of these Third Party Libraries into our code, unless we're certain that, you know, our choice of Third Party Libraries is not like 
		to change for the lifetime of our application. 
	Certainly, our database represents a dependency assuming that our application has one and it's definitely one of the things that you will want to wrap
		in such a way that it is not an implicit dependency within your code, but rather something that could be injected and replaced.
	Other dependencies are less obvious. For example, if your code references the file system, if it uses email, 
		if it sends email or even checks email from a POP mailbox for example, if it uses Web Services or really any kind of network access at all,
		would be a dependency as well. 
		Any sort of system resources, even things like just the clock that you might access via DateTime. 
		Now represent further dependencies that might require you to invert in the case of situations 
		where they affect the behavior of your application and there's no way for you to test it unless you run it at certain times of day. 
		Configuration can be a dependency in terms of the files that you use for configuring your application. 
		The "new" Keyword is itself a possible indication that you've got a dependency within your application. 
	We want to limit the places in which you allow your application to instantiate new objects, unless they're primitives like strings, for example. 
	And related to that is the use of static methods. Anytime you're calling a static method, you're adding a dependency to your code that cannot easily
		be separated from the calling code in the case of trying to write a test for it or in the case of wanting to change the way your code works throughout
		the entire application in one place. If you have static methods sprinkled throughout your code, it's very difficult to change them all 
		through one configuration change or one startup file change. 
	Thread.Sleep can also be a dependency, as well as the use of Random, and it can be very difficult to test code that is supposed to give you random results,
		so if you specify an interface that you use for generating your random values, then in your test you can override that interface and say, 
		well if the random value is this, then I should expect this result and similarly it allows you to more easily test so-called random data.

-----------------------------------------------------------------------------------------------------------------------------

	Traditional Programming and Dependencies
	- High Level modules tend to call low level modules (instantiate when need them)
	- User Interfaces depends on
		- Infrasctructure
		- Utility (logger)
		- Data Acess
	- Static methods
	- Class instantiation / call stack logic in scattered through all modules
		(VIOLATION OF SRP - a class should not be responsible to instantiate another one in their code)

-----------------------------------------------------------------------------------------------------------------------------

	Class Dependencies - we need them, but we need to use them in a good way.
	- Class constructors should require any dependencies the class needs. - good
	- Class constructors make this cleas have "explicit" dependencies - good
	- Classes that do not have "implicit", HIDDEN dependencies - aren't clear =>
		=> instantiate using new a class that you supose it will work without passing anything (in ctor), you will find out
			that DataBase access for that class is not there! (that class will lie to you, it has HIDDEN dependencies)

	Example:
	-- BAD --
	public class HelloWorldHidden
	{
		public string Hello(string name)
		{
			if(DateTime.Now.Hour < 12) return "Good morning, " + name;
			if(DateTime.Now.Hour < 18) return "Good afternoon, " + name;
			return "Good evening, " + name
		}
	}
	- Has a hidden dependency of Clock (DateTime)
	- Violates OCP - Open Closed Principle 
	Questions:
		- How to alter this dependency(DateTime) ?
		- How to test this ? - Run tests: morning, afternon, evening to see if they are working ?

	-- GOOD --
	declare what they need to work properly !!
	public class HelloWorldExplicit
	{
		private readonly DateTime _timeOfGreeting;
		public HelloWorldExplicit(DateTime timeOfGreeting) -- passed to the class constructor
		{
			_timeOfGreeting = timeOfGreeting;
		}

		public string Hello(string name) -- if only this method use the clock can be pass only here as well and not in the constructor
		{
			if(_timeOfGreeting.Hour < 12) return "Good morning, " + name;
			if(_timeOfGreeting.Hour < 18) return "Good afternoon, " + name;
			return "Good evening, " + name
		}
	}
	-- Better solution to this -> pass a interface that has an implementation and in which we can choose what we want