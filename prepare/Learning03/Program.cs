using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fr1 = new Fraction();
        Console.WriteLine(fr1.get_string());
        Console.WriteLine(fr1.get_decimal());

        Fraction fr2 = new Fraction(5);
        Console.WriteLine(fr2.get_string());
        Console.WriteLine(fr2.get_decimal());

        Fraction fr3 = new Fraction(5, 2);
        Console.WriteLine(fr3.get_string());
        Console.WriteLine(fr3.get_decimal());

    }
}