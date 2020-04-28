
OCP Open Closed Principle - How To obtain a better design

Three Approaches to Achieve OCP

- Parameters (Procedural Programming).
	- Control behavior via specific parameter/s

 - Inheritance => Templated Method Pattern
	- Child types ovverides behavior of a base class (or interface)

- Composition / Strategy Pattern
	- Client code depends on abstraction
	- Provides a "plug in" model
	- Implementations utilize Inheritance; Client utilizes Composition
