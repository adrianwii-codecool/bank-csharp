using System;
namespace Bank
{
	public class Manger
	{
		List<Account> accounts = new List<Account>();

		public Manger()
		{
		}

		public void AddAcount(Account account)
		{
			accounts.Add(account);
		}

		public List<Account> GetAccounts()
		{
			return accounts;
		}
    }
}

