using System;





class Question1
{

    static int ReadMark(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input required. please enter a number");
                continue;
            }
            if(int.TryParse(input.Trim(), out int value))
            {
                if (value <0 || value > 100)
                {
                    Console.WriteLine("Please a mark betwee 0 and a 100");
                    continue;
                }
                return value;
            }
            Console.WriteLine("Invalid number. please enter valid number");
        }
    }



    public static void Main()
    {
       //Student Personal info
        Console.Write("Enter student name: ");
        Console.Write("Enter student Surname: ");

        //Student Marks Input

        //Student Results 


    }
}