using System;


namespace BankAccountSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      var account = new BankAccount("christian", 1000);
      System.Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

      account.MakeDeposit(300, DateTime.Now, "Online Sales");
      System.Console.WriteLine(account.Balance);
      account.MakeWithdrawal(100, DateTime.Now, "Kali's food");
      System.Console.WriteLine(account.Balance);

      System.Console.WriteLine(account.GetAccountHistory());
    
    }
  }
}
