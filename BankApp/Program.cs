// See https://aka.ms/new-console-template for more information
using BankApp.Entities;
using BankApp.Services.Interfaces;
using BankApp.Utils;

Bank bank = new Bank() { Name ="123" };
IBankService bankService = DependencyInjecter.GetService<IBankService>();
bankService.Add(bank);

Console.WriteLine("Hello, World!");
