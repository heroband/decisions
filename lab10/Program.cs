using lab10;

var deliveryDateSelector = new DeliveryDateSelector();
var timeSlotSelector = new TimeSlotSelector();
var receiverCheckbox = new Checkbox();
var receiverNameField = new TextField();
var receiverPhoneField = new TextField();
var pickupCheckbox = new Checkbox();

var mediator = new OrderFormMediator(deliveryDateSelector, timeSlotSelector, receiverCheckbox, receiverNameField, receiverPhoneField, pickupCheckbox);

Console.WriteLine("=== Вибір дати доставки ===");
deliveryDateSelector.ChangeDate("2024-11-01");

Console.WriteLine("\n=== Вибір 'отримувач інша особа' ===");
receiverCheckbox.ToggleCheck();

Console.WriteLine("\n=== Вибір самовивозу ===");
pickupCheckbox.ToggleCheck();