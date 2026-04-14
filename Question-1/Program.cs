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
        string studentName = Console.ReadLine().Trim() "";

        Console.Write("Enter student Surname: ");
        string studentSurname = Console.ReadLine().Trim() "";

        //Student Marks Input
        int mark1 = ReadMark("Enter student mark 1:");
        int mark2 = ReadMark("Enter student mark 2:");
        int mark3 = ReadMark("Enter student mark 3:");

        //Student Results 
        Console.WriteLine("   ");
        Console.WriteLine("==============Student Result==============")
        Console.WriteLine("   ");


        Console.WriteLine($"Student Name:{studentSurname} {studentName} ");

        int totalMarks = mark1 + mark2 + mark3;
        Console.WriteLine($"Total amount of marks:  {totalMarks}");

        double averageMarks = totalMarks / 3.0;
        Console.WriteLine($"The average marks: {averageMarks:F2}");

        string result = averageMarks >= 50
            ? "Student has passed the course."
            : "Student has failed the course.";

        Console.WriteLine(result);
        Console.WriteLine("End of program");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();



    }
}