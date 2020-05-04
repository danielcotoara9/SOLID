
LSP : Liskov Substitution Principle - Summary

- Conformance to LSP allows proper use of polymorphism and produces more maintainable code 

- When to apply LSP?
	- If you notice obvious smells like those shown
	- If you find yourself being bitten by OCP violations invariably causes
	- When you find if-then check polymorphic checking the type of the objects.
	- When you derived from a base class or interface and not fully implemented

- Important
	- Don't interrogate (check A is typeOf(B)) object for their internals - move the behavior to the object.
	   This is "Tell, Don't Ask"
	- Remember IS-SUBSTITUTABLE-FOR instead of IS-A


- Related Fundamentals
	- Polymorphism
	- Inheritance
	- Interface Segregation Principle
	- Open/Close Principle

