using System;
namespace Bank
{
	public class SavingsAccount : Account
	{
		private decimal interests;

		public SavingsAccount()
		{
            interests = 0;
		}

        public void IncreaseInterests(decimal interset)
        {
            interests += interset;
        }

        public override decimal getBalance()
        {
            return balance + interests;
        }
    }
}

