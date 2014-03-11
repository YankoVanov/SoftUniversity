/*12. Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.*/
using System;

class Program
{
    static void Main()
    {
        int? nullIntValue = null;
        double? nullDoubleValue = null;
        Console.WriteLine(nullIntValue);
        Console.WriteLine(nullDoubleValue);

        nullIntValue += 6;
        nullDoubleValue += 5.332;
        Console.WriteLine(nullIntValue);
        Console.WriteLine(nullDoubleValue);
        Console.WriteLine("Conclusion null + something equals to nothing :)");
    }
}

