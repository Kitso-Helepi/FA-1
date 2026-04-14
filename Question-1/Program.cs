class Question1
{
    public static void Main()
    {
       //Student Personal info
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();
        Console.Write("Enter student Surname: ");
        string studentSurname = Console.ReadLine();

        //Student Marks Input
        Console.Write("Enter student Mark 1: ");
        string studentMark1 = Console.ReadLine();
        int mark1 = int.Parse(studentMark1);
        string studentMark2 = Console.ReadLine();
        int mark2 = int.Parse(studentMark2);
        string studentMark3 = Console.ReadLine();
        int mark3 = int.Parse(studentMark3);

        //Student Results 
        Console.WriteLine("Student Name "+ studentName+studentSurname);


    }
}