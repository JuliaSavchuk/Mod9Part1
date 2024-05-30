namespace Mod9Part1
{
    public delegate void CardEventHandler(string message);

    public class CreditCard
    {
        public string CardNumber { get; private set; }
        public string CardHolderName { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        private string pin;
        public decimal CreditLimit { get; private set; }
        public decimal Balance { get; private set; }

        public event CardEventHandler AccountReplenished;
        public event CardEventHandler FundsWithdrawn;
        public event CardEventHandler CreditLimitReached;
        public event CardEventHandler PinChanged;

        public CreditCard(string cardNumber, string cardHolderName, DateTime expiryDate, string pin, decimal creditLimit, decimal initialBalance)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpiryDate = expiryDate;
            this.pin = pin;
            CreditLimit = creditLimit;
            Balance = initialBalance;
        }

        public void ReplenishAccount(decimal amount)
        {
            Balance += amount;
            AccountReplenished?.Invoke($"Account replenished by {amount}. New balance is {Balance}.");
        }

        public void WithdrawFunds(decimal amount)
        {
            if (Balance - amount < 0)
            {
                CreditLimitReached?.Invoke("Credit limit reached. Transaction denied.");
            }
            else
            {
                Balance -= amount;
                FundsWithdrawn?.Invoke($"Withdrawn {amount}. New balance is {Balance}.");
            }
        }

        public void ChangePin(string newPin)
        {
            pin = newPin;
            PinChanged?.Invoke("PIN has been changed successfully.");
        }
    }
}
