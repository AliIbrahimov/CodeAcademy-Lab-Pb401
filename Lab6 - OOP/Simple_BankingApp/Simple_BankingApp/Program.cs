using System;
class Program
{
    static void Main()
    {
        VipAccount vipAccount = new("Vip001", "Javid", "Guluzade");
        NormalUser user = new("N001", "Ali", "Jahangirov");

        //vipAccount.Deposit(1000);
        //vipAccount.Deposit(200);
        //vipAccount.WithDraw(300);
        //vipAccount.Deposit(1000);
        //vipAccount.Deposit(200);
        //vipAccount.WithDraw(300);
        //vipAccount.Deposit(1000);
        //vipAccount.Deposit(200);
        //vipAccount.WithDraw(300);
        //vipAccount.Deposit(1000);
        //vipAccount.Deposit(200);
        //vipAccount.WithDraw(300);
        //vipAccount.CalculateInterest();
        //vipAccount.ShowTransaction();

        Console.WriteLine("---------------------------------------------------------------");

        user.Deposit(1000);
        user.Deposit(200);
        user.WithDraw(1000);
        user.Deposit(200);
        user.CalculateInterest();
        user.ShowTransaction();


    }
}



