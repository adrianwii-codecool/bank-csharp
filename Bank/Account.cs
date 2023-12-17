using System;
namespace Bank
{
	public class Account
	{

		protected decimal balance;

		public Account()
		{
			balance = 0;
		}

		public void IncreaseBalance(decimal amount)
		{
			balance += amount;
		}

		public virtual decimal getBalance()
		{
			return balance;
		}

    }
}

