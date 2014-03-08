using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // common way
        Console.WriteLine(1);
        Console.WriteLine(101);
        Console.WriteLine(1001);

        Console.WriteLine();

        // placeholder way -> \n insert new line
        Console.WriteLine("{0}\n{1}\n{2}", 1, 101, 1001);
    }
}

