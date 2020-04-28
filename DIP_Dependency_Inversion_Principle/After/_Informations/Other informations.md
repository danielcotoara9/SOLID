
DIP : Dependemcy Inversion Principle -  How To obtain a better design

-----------------------------------------------------------------------------------------------------------------------------
	Construnctor Injection - Part of Strategy Pattern

	- Pros
		- Classes self-document what they need to perform their work
		- Works well with or without a container
		- Classes are always in a valid state once constructed
	- Cons
		- Constructors can have many parameters/dependencies(design smell) - can be solved
		- Some feautures (e.g. Serialization) may require default constructor
		- Some methods in the class may not require things other methods require (design smell, your class lacks cohesion)

-----------------------------------------------------------------------------------------------------------------------------

	Property Injection = Setter Injection

	- Pros
		- Dependency can be changed at any time during object lifetime
		- Very flexible

	- Cons
		- Objects may be in an invalid state between construction and setting of dependencies via setters
		- Less intuitive (what properties to set, wich is the order, ...)

-----------------------------------------------------------------------------------------------------------------------------

	Parameter Injection - dependencies are passed via method parameter

	- Pros
		- Most granular
		- Very flexible
		- Requires no change to rest of class

	- Cons
		- Breaks method signature (if other class use this method it can be expensive)
		- Can result in many parameters (design smell) - can be solved
	This should be used only one method from a class required a parameter that other methods don't. Otherwise use construnctor injection

-----------------------------------------------------------------------------------------------------------------------------