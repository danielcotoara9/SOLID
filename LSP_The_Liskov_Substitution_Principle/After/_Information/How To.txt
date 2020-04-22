
LSP : Liskov substitution Principle - How To obtain a better design

- Create a base class that will be the base for every geometric figure
- Consider Refactoring to a new Base Class
	- Give two classes that shares a lot of behavior but are not substitutable.
	- Ensude substitutability is retained between each class and the new base class.

- Add a method there that will calculate the Area 
- Every child will override this method with its own implementation