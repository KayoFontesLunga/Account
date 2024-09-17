using Account;
using System;

SpecialAccount SpecialAccount = new SpecialAccount();
SpecialAccount.AccountNumber = "7237438918894-C";
SpecialAccount.AccountHolderName = "Kayo José da Silva Fontes Lunga";
SpecialAccount.Deposit(500);
SpecialAccount.Withdraw(100);
SpecialAccount.ViewBalance();