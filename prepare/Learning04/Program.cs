using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignament = new Assignment();
        assignament.SetStudentName("Samuel Bennett");
        assignament.SetToppic("Multiplication");
        Console.WriteLine(assignament.GetSummary());

        MathAssignment mathassignment = new MathAssignment();
        mathassignment.SetTextbookSection("7.5");
        mathassignment.SetProblems("8-20");
        Console.WriteLine(mathassignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.SetStudentName("Mary Waters");
        writingAssignment.SetTitle("The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}