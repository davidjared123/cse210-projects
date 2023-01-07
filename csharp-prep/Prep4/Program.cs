using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int user_num = -1;
        while (user_num != 0)
        {
            Console.Write("Enter number: ");
            user_num = int.Parse(Console.ReadLine());

            if (user_num != 0)
            {
                numbers.Add(user_num);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The max is: {largest}");

        int lower = numbers[0];

        foreach (int number in numbers)
        {
            if (number < lower && number > 0)
            {
                lower = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {lower}");


        Console.WriteLine("The sorted list is: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}