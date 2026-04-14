using System;
using System.Collections.Generic;

class Program
{
    static int ReadInt(string message, int min ,int max)
    {

        while (true)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine() ?? "";


            if (int.TryParse(input, out int value) && value >= min && value <= max)
            {
                return value;
            }

            Console.WriteLine($"Invalid input. Enter a number between {min} and {max}.");
        }


    }

    static void Main()
    {
        List<Resident> residents = new List<Resident>();
        UtilitiesManager manager = new UtilitiesManager();

        Console.Write("Enter number of residents: ");
        int residentCount = int.Parse(Console.ReadLine()?? "0");

        for (int i = 0; i < residentCount; i++)
        {
            Console.WriteLine($"\nResident {i + 1}:");

            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Address: ");
            string address = Console.ReadLine() ?? "";

            Console.Write("Account Number: ");
            string acc = Console.ReadLine() ?? ""   ;

            Console.Write("Monthly Usage: ");
            double usage = double.Parse(Console.ReadLine()  ?? "0");

            residents.Add(new Resident(name, address, acc, usage));
        }

        

        while (true)
        { 
            Console.WriteLine("\n====MENU======");
            Console.WriteLine("\n1. Add service Request");
            Console.WriteLine("\n2. View Pending Requests");
            Console.WriteLine("\n3. Process Request");
            Console.WriteLine("\n4. Exit");

            int option = ReadInt("Select an option: ", 1, 4);

            if (option == 1)
            {
                Console.WriteLine("\n--- Add Request ---");

                int choice = ReadInt($"Select resident (1-{residents.Count}): ", 1, residents.Count) - 1;

                Console.Write("Request Type: ");
                string type = Console.ReadLine() ?? "";

                int priority = ReadInt("Priority (1-5): ", 1, 5);

                int severity = ReadInt("Severity (1-10): ", 1, 10);

                Console.Write("Estimated Hours: ");
                double hours = double.Parse(Console.ReadLine() ?? "0");

                var request = new ServiceRequest(residents[choice], type, priority, severity, hours, 0 );
                manager.AddRequest(request);
            } else if(option == 2)
            {

                if (manager.PendingCount() == 0)
                {
                    Console.WriteLine("\nNo pending requests.");

                }
                else
                {
                    manager.DisplayQueue();
                }

            } else if(option == 3)
            {
                if(manager.PendingCount() == 0)
                {
                    Console.WriteLine("No requests to process.");
                    continue;
                }

                ServiceRequest? request = null;

                while(request == null)
                    {
                    int index = ReadInt($"select request:()1-{manager.PendingCount()}: ", 1, manager.PendingCount())-1;
                    if (request ==null)
                    {
                        Console.WriteLine("Invalid selection. Try again");
                    }
                    
                }
                    manager.GenerateReport(request);



            } else if(option == 4)
            {
                Console.WriteLine("\n Final Summary.");
                manager.DisplaySummary();

                Console.WriteLine("Exiting System");
                break;
            }
        }

    }
}