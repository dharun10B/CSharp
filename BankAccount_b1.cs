namespace StudentApp
{
    namespace Banking
    {
        partial class BankAccount
        {
            public int acctno = 1234;
            public string actname = "Smith";
            public double cbalance = 1000000;

            public void Deposit(double amount)
            {
                cbalance += amount;
            }
        }
    }
}
