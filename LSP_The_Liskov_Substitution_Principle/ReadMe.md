
LSP : The Liskov Subtitution Principle

- The Liskov Substitution Principle states that Subtypes must be subtitutable for their base types.

	Substitutability
	- Childs classes must not:
		- Remove base class behavior
		- Violate base class invariants
	- In general must not required calling code to know they are different from their base type

	Relationships:
		- IS-A -> describes inheritance. Example : A car IS-A Vehicle == Car : Vehicle
	LSP suggests that IS-A should be replaced with IS-SUBSTITUTABLE-FOR

