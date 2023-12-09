using BankApp.Entities;
using BankApp.Services.Interfaces;
using BankApp.Utils;

Bank bank = new Bank() { Name = "Bank1" };
IBankService bankService = DependencyInjecter.GetService<IBankService>();
bankService.Add(bank);

Console.WriteLine("Hello, World!");
