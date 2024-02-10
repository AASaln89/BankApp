using BankApp;
using BankApp.Entities;
using BankApp.Services.Interfaces;
using BankApp.Utils;


Bank bank = new Bank() { Name = "Bank1" };
IBankService bankService = DependencyInjecter.GetService<IBankService>();
bankService.Add(bank);
Client client = new Client() {Bank = bank, FirstName = "Client1", LastName = "Clnt1", PhoneNumber = "1234321", Number = "1111111", Type = ClientType.Individual};

IClientService clientService = DependencyInjecter.GetService<IClientService>();
clientService.Add(client);


