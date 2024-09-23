

// Відправка email
using lab4;

INotification emailNotification = new EmailNotification("admin@gmail.com");
emailNotification.Send("Server was turned off", "The main server was turned off");

// Відправка Slack повідомлення
SlackService slackService = new SlackService("admin", "sdfg-335df-af", "123");
INotification slackNotification = new SlackServiceAdapter(slackService);
slackNotification.Send("Server was turned off", "The main server was turned off");

// Відправка SMS
SmsService smsService = new SmsService("0951234563", "Company");
INotification smsNotification = new SmsServiceAdapter(smsService);
smsNotification.Send("Server was turned off", "The main server was turned off");