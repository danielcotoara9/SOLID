
SRP: Single Responsibility Principle - Problems

- Cash transactions don't need credit card processings
- Point of Sale Transactions don't need inventory reservations. 
	Store inventory is updated separately in our system.
- Point of sale don't need email verifications
	The customer doesn't provide an email.
	The customer knows immediately that the order was a success
- Any change to notifications, credit card processing, or inventory management
	will affect Order as well as the Web and Point of Sale implementations of Order.