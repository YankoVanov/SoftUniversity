/*07. Declare two string variables and assign them with following value:
The "use" of quotations causes difficulties.
Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string escapedString = "The \"use\" of quotations causes difficulties.";
        string anotherString = "The use of quotations causes difficulties.";
        Console.WriteLine(escapedString);
        Console.WriteLine(anotherString);
    }
}