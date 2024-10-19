using lab7;

var deliveryContext = new DeliveryPriceContext();

// deliveryContext.CalculateCost(15); // Unhandled exception. System.InvalidOperationException: Delivery strategy isn't set

deliveryContext.SetStrategy(new PickupStrategy());
Console.WriteLine($"Pickup price is {deliveryContext.CalculateCost(15)}"); // Pickup price is 0

deliveryContext.SetStrategy(new ExternalDeliveryStrategy());
Console.WriteLine($"External delivery price is {deliveryContext.CalculateCost(15)}"); // External delivery price is 5,00

deliveryContext.SetStrategy(new OwnDeliveryStrategy());
Console.WriteLine($"Own delivery price is {deliveryContext.CalculateCost(15)}"); // Own delivery price is 1,5


