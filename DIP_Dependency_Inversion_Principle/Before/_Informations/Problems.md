
DIP: Dependency Inversion Principle - Problems

- How to test the Order class, how to inject the HIDDEN dependencies ? => See tests from UnitTests project DIP => Before folder

- Order has HIDDEN dependencies
	- MailMessage
	- SmtpClient
	- InventoryService
	- PaymentGateWay
	- Logger
	- DateTime.Now
- What results from these? =>
	- Tight coupling
	- Hard to change implementation details (OCP - violations)
	- Difficult to test


