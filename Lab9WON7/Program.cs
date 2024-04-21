using Lab9WON7;

BankAccount currentAccount=new CheckingAccount("cont 1");
BankAccount savingsAccount = new SavingsAccount("cont 2", 0.2M);
BankAccount investmentAccount = new InvestmentAccount("cont 3", 0.3M, 23);

currentAccount.GetDescription();
savingsAccount.GetDescription();
investmentAccount.GetDescription();

currentAccount.MakeDeposit(200);
currentAccount.GetDescription();
currentAccount.Withdraw(6000);

savingsAccount.MakeDeposit(100);
savingsAccount.GetDescription();

investmentAccount.MakeDeposit(100);
investmentAccount.Withdraw(20);
investmentAccount.GetDescription();
