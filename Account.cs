using System;
namespace BankApp.Classes;

public class Account(){
    
    public float balance{get; } = 1000;

    public void Deposit()
    {
       
        Console.WriteLine("Ηow much money do you want to deposit?");
        string userMoneyDepositToString = Console.ReadLine();
        float userMoneyDeposit = float.Parse(userMoneyDepositToString);
        Console.WriteLine($"Your new balance is {balance + userMoneyDeposit}");
    }

    public void Withdrawal()
    {
        Console.WriteLine("Ηow much money do you want to withdrawal?");
        string userMoneyWithdrawalToString = Console.ReadLine();
        float userMoneyWithdrawal = float.Parse(userMoneyWithdrawalToString);
        if(userMoneyWithdrawal <= balance)
        {
            Console.WriteLine("Succesfull withdrawal!");
            float newBalance = balance - userMoneyWithdrawal;
            Console.WriteLine($"Your new balance is: {newBalance}");
        }else{
            Console.WriteLine("Sorry you can't make withdrawal! Type another amount!");
            Withdrawal();
        }
    }

    public void Balance()
    {
        Console.WriteLine($"Your Balance is: {balance}");
    }
}