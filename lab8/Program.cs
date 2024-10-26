using lab8;

EntityUpdater productUpdater = new ProductUpdater();
EntityUpdater userUpdater = new UserUpdater();
EntityUpdater orderUpdater = new OrderUpdater();

productUpdater.UpdateEntity(); // Product saved // Response: Status Code, Status
userUpdater.UpdateEntity(); // User saved // Response: Status Code, Status
orderUpdater.UpdateEntity(); // Order saved // Response: Status Code, Status, Order JSON