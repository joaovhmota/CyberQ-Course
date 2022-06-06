using Exercício_02;

BankSystem bankSystem = new BankSystem();
Client c = new Client();
c.Name = "João";
c.Balance = 5000;
c.Agency = "Ag1";
c.Savings = 0;
c.CheckingAccount = "1234";
c.Password = "1234";

bankSystem.AddClient(c);
bankSystem.Login();