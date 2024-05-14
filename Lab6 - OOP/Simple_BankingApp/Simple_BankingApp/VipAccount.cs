public class VipAccount : Account
{
    public VipAccount(string accountNumber, string name, string surname) : base(accountNumber, name, surname)
    {
    }

    private decimal cashbackRate = 0.02m;
    private decimal interestRate = 0.02m;
    private int maxTrasactionsPerDay = 10;
    private int dailyTrasactionCount;


    public override void CalculateInterest()
    {
        decimal interest = Balance * interestRate;
        decimal temp = Balance;
        Balance += interest;
        TransactionCount--;
        AddTransaction($"Deposit: {temp}- 5% +{interest}, new alance {Balance}",true);
    }

    public override void Deposit(decimal amount)
    {
        Balance += amount + (amount * cashbackRate);
        AddTransaction($"Deposit: +{amount}, Cashback: +{amount * cashbackRate}, Balance {Balance}", canMakeTrasaction());
        dailyTrasactionCount++;
    }

    public override void WithDraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            AddTransaction($"Withdraw: -{amount}, Balance {Balance}", canMakeTrasaction());
            dailyTrasactionCount++;
        }
        else
            Console.WriteLine("Your don't have enought in your money!");
    }
    public bool canMakeTrasaction() => dailyTrasactionCount < maxTrasactionsPerDay;
}



