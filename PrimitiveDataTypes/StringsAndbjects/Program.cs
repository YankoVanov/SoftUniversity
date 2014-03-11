/*06. Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            string helloWord = "Hello";
            string worldWord = "World";

            object concatenatedString = helloWord + " " + worldWord;
            Console.WriteLine(concatenatedString);

            string castedString = (string)concatenatedString;
            Console.WriteLine(castedString);
        }
    }
