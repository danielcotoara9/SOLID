
OCP : Open Closed Principle

- The Open/Closed Principle states that software entities (classes, modules, functions, ...) should be open to extension, but close for modifications.
		When you extend your software you should not need to go and dig around in its internals just to change its behavior.
	You should be able to extend it by adding to it, with new functionality and new classes, new functions. 
	Without the need to change your existing classes and functions, while still achieving new behavior. 
	So the Open/Closed Principle offers up this sort of conundrum in that, it's stating that things should be open to extension. 
	New behavior, changes to behavior can be done in the future, but yet closed to modification. 
	What does that mean? That means you shouldn't need to change the source code or the binary code,
	you shouldn't have to recompile the existing pieces of your application a necessarily in order to achieve this. 

	Dr. Bertrand Meyer originated the term Open/Closed Principle in his 1988 book Object Oriented Software Construction. 
		So how do we do this? How do we change behavior without changing code? 
		The key is to rely on abstractions. Once we start to rely on abstractions in our code, 
			there is no limit to the number of different ways we can implement that abstraction, 
			and thus no limit to the number of ways we can change the behavior of the code that's using these abstractions. 
	So what do we mean by abstractions? Well in. NET abstractions include Interfaces, as well as Abstract Base Classes. 

	In procedural code we can also achieve some level of a the Open/Closed Principle using parameters. 


