public abstract class Account
{
    protected Account(string accountNumber, string name, string surname)
    {
        AccountNumber = accountNumber;
        Name = name;
        Surname = surname;
        Balance = 0;
        Transactions = new string[10];
        TransactionCount = 0;
    }
    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Balance { get; set; }
    public string AccountNumber { get; set; }
    public string[] Transactions { get; set; }
    public int TransactionCount { get; set; }


    public void ShowTransaction()
    {
        foreach (var transaction in Transactions)
        {
            if (transaction is not null)
                Console.WriteLine(transaction);
        }
    }
    protected void AddTransaction(string transaction,bool canMakeTrasaction)
    {
        if (TransactionCount < Transactions.Length && canMakeTrasaction)
            Transactions[TransactionCount++] = transaction;
       

        else
            Console.WriteLine("Daily transfer full!");

    }
    abstract public void Deposit(decimal amount);
    public abstract void WithDraw(decimal amount);
    public abstract void CalculateInterest(); //faiz hesablamag ucun!!!!
}




