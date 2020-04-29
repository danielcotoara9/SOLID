
SRP: Single Responsibility Principle - How To obtain a better design

- Identify the responsibilities that are likely to change.
	Checkout method is doing
	- Processing payment -> IPaymentProcessor (ProcessCredCard())
	- Reserving inventory -> IReservingInventory (ReserveInventory())
	- Sending notifications -> INotificationService (NotifyCustomerOrderCreated())

	After that break the Order class in smaller classes that have fewer responsibilities
	After that break the Order class in smaller classes that have fewer responsibilities and only use the interfaces that need.
	- OnlineOrder (Checkout())
	- PoSCreditOrder (Checkout())
	- PoSCashOrder (Checkout())
