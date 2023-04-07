using ProxyPattern.Abstracts;
using ProxyPattern.Concretes;


Console.WriteLine("Enter username : ");
string? username = Console.ReadLine();
Console.WriteLine("Enter password : ");
string? password = Console.ReadLine();
Console.WriteLine("Enter amount of money : ");
double amount = Convert.ToDouble(Console.ReadLine());

IBank bank = new ProxyBank(username, password);
bank.SendMoney(amount);

