namespace Bank;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello in our Bank!");

        Manger adrian = new Manger();

        Account account1 = new CurrentAccount();
        account1.IncreaseBalance(1000);

        Account account2 = new CurrentAccount();
        account2.IncreaseBalance(5000);

        Account account3 = new CurrentAccount();
        account3.IncreaseBalance(3000);


        SavingsAccount savings1 = new SavingsAccount();
        savings1.IncreaseBalance(10000);
        savings1.IncreaseInterests(100);

        adrian.AddAcount(account1);
        adrian.AddAcount(account2);
        adrian.AddAcount(account3);
        adrian.AddAcount(savings1);

        decimal sum = 0;

        foreach (Account account in adrian.GetAccounts())
        {
                sum += account.getBalance();
        }


        Console.WriteLine($"Suma na kontach wynosi: {sum}");
    }
}

