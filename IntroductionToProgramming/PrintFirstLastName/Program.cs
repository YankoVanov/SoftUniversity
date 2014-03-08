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
        Console.WriteLine("Yanko");
        Console.WriteLine("Vanov");

        Console.WriteLine();

        // using placeholders and variables -> \n insert new line
        string firstName = "Yanko";
        string lastName = "Vanov";

        Console.WriteLine("{0}\n{1}", firstName, lastName);
    }
}

