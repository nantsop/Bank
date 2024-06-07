 using System;
 using BankApp.Classes;


Account account = new Account();
while(true){
    Console.WriteLine("Welcome to our Bank! \nWhich of the following commands do you wanna make? \nPlease select one of the following options:");
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdrawal");
    Console.WriteLine("3. Balance");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");
    string userChoise = Console.ReadLine();


    switch (userChoise)
    {
        case "1":
            account.Deposit();
            break;
        case "2":
            account.Withdrawal();
            break;
        case "3":
            account.Balance();
            break;
        case "4":
            Console.WriteLine("Thank you!");
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
    Console.WriteLine("Press any key to continue...");
    
    Console.ReadKey();

}