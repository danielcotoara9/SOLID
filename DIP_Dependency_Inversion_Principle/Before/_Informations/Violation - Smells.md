
DIP : Dependency Inversion Principle - Code Smells

1) Use of new keyword
    foreach(var item in cart.Items)
    {
        //instantiate classes rather than interfaces
        // Is the responsibility of that class to instantiate this ?
        var inventoryService = new InventoryService();
        inventoryService.Reserve(item.Sku, item.Quantity);
    }

2) Use of static methods/properties
    message.Subject = "Your order placed on " + DateTime.Now.ToString();
    DataAccess.SaveCustomer(customer);

---- Where to instantiate objects ?
    - Default constructor of the class ("poor man's dependency injection"/"poor man's IoC")
    - Main (Startup files)
    - IoC Container (Use an Inversion of Control Container)

---- IoC Containers
    - Responsible for object graph instantiation
    - Initiated at application startup
    - Managed interfaces and the implementation to be used are "Registered" with the container
    - Dependencies or interfaces are "Resolved" at application startup or runtine
    - Examples of IoC
        - Ninject
        - StructureMap
        - Autofac
