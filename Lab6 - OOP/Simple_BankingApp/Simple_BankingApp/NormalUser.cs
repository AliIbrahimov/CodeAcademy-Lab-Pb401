public class NormalUser :Account
{
    private decimal interestRate = 0.1m;
    private int maxTrasactionPerDay = 5;

    private int dailyTrasactionCount;

    public NormalUser(string accountNumber, string name, string surname) : base(accountNumber, name, surname)
    {
        dailyTrasactionCount = 0;
    }

    public override void CalculateInterest()
    {
        decimal interest = Balance * interestRate;
        decimal Temp = Balance;
        Balance += interest;
        TransactionCount--;
        
        AddTransaction($"Deposit: {Temp}- 5% +{interest}, Balance : {Balance}", true);
    }

    public override void Deposit(decimal amount)
    {
        if (dailyTrasactionCount <= 5)
        {
            Balance += amount;
            AddTransaction($"Deposit +{amount}, Balance: {Balance}", canMakeTrasaction());
            dailyTrasactionCount++;
        }

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
    public bool canMakeTrasaction()=> dailyTrasactionCount <maxTrasactionPerDay;
}




