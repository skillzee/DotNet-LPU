// See https://aka.ms/new-console-template for more information
using EventDrivenPhoneCallSubscription;

Console.WriteLine("Hello, World!");


PhoneCall phoneCall = new PhoneCall();
phoneCall.MakeAPhoneCall(false);
Console.WriteLine(phoneCall.Message);

