using System;

class Question2
{
    static int Amount(string prompt) {
        //Loop until valid input is received
        while (true)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input required. Please enter a number"); 
                continue;
            }

            if(int.TryParse(input!.Trim(),out int result))
            {
                return result;
            }

            else
            {
                Console.WriteLine("Invalid Input. Please enter a valid number.");
            }
        }
    
    
    }
    public static void Main()
    {
        
        string? Name;
        //do-while loop to ensure that the user enters a valid name (not null or whitespace)
        do
        {
            Console.WriteLine("Greetings, What is your name?");
            Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("Name is required. Please enter your name."); 
            }
        }while(string.IsNullOrWhiteSpace(Name));

        Console.WriteLine(" ");
        Console.WriteLine($"WELCOME {Name.ToUpperInvariant()}!");
        Console.WriteLine(" ");

        //Enter the Balance and the Withdrawal amounts
        int balance = Amount("Enter account balance:");
        int withdrawal = Amount("Enter withdrawal amount:");

        //Logic to check if the withdrawal amount exceeds the account balance and display appropriate messages
        if (balance< withdrawal)
        {
            Console.WriteLine("Error: Insufficient funds. Withdrawal amount exceeds account balance.");
        }
        else if (withdrawal < 0)
        {
            Console.WriteLine("Error: Invalid withdrawal amount. Withdrawal amount cannot be negative.");
        }
        else if (balance < 0)
        {
            Console.WriteLine("Error: Invalid account balance. Balance Amount cannot be negative.");
        }

        else
        {
            int newBalance = balance - withdrawal;
            Console.WriteLine("Withdrawal Successful.");
            Console.WriteLine($"New Balance:{newBalance}");
        }

        


    }
}