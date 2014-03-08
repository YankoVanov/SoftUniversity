using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // most common way
        Console.WriteLine("Hello C#");

        // variable way
        string textToBeWritten = "Hello C#";
        Console.WriteLine(textToBeWritten);

        // placeholder {0} way
        Console.WriteLine("{0}", textToBeWritten);
    }
}
