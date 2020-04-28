
DIP : Dependemcy Inversion Principle -  How To obtain a better design

-----------------------------------------------------------------------------------------------------------------------------
We can use : Please read Other informations file for more details

- Dependency Injection is a technique that is used to allow calling code to inject the dependecies a class needs when it is instantiated.
- The Hollywood Principle
	- "Don't call us; we'll call you!" (So instead our class calling SmtpClient, she should say I NEED a notification service that will know how to do that )

- Three Primary Techniques
	- Construnctor injection
	- Propery injection
	- Parameter injection

-----------------------------------------------------------------------------------------------------------------------------

What we will do:
	- Extract dependencies into Interfaces
	- Inject implementations of Interfaces into Order
	- Reduce Order's responsabilities - SRP
