using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int grade_int = int.Parse(grade);

        string letter_grade = "";

        if (grade_int >= 90)
        {
            letter_grade = "A";
        }

        else if (grade_int >= 80)
        {
            letter_grade = "B";
        }

        else if (grade_int >= 70)
        {
            letter_grade = "C";
        }

        else if (grade_int >= 60)
        {
            letter_grade = "D";
        }

        else
        {
            letter_grade = "F";
        }

        Console.WriteLine($"Your grade is: {letter_grade}");

        if (grade_int >= 70)
        {
            Console.WriteLine("Congratulation you passed!");
        }
        else
        {
            Console.WriteLine("So sorry, try it next time, you haven't passed");
        }
    }
}