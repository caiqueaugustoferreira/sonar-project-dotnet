namespace ComplexCodeExample
{
    public class BankAccount
    {
        private double balance;
        private string password;

        public BankAccount(double initialBalance, string password)
        {
            balance = initialBalance;
            this.password = password;
        }

        public double Withdraw(double amount, string passwordAttempt)
        {
            if (passwordAttempt != password)
            {
                throw new UnauthorizedAccessException("Incorrect password");
            }

            if (amount < 0)
            {
                throw new ArgumentException("Amount must be positive");
            }
            else if (amount == 0)
            {
                Console.WriteLine("No withdrawal necessary");
            }
            else if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            else if (balance - amount < 10)
            {
                Console.WriteLine("Warning: Low balance");
                balance -= amount;
            }
            else
            {
                balance -= amount;
            }

            if (balance < 0)
            {
                throw new InvalidOperationException("Balance went negative!");
            }

            return balance;
        }
    }
}