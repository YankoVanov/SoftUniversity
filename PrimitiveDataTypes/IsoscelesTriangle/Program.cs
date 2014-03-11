/*08. Write a program that prints an isosceles triangle of 9 copyright symbols ©. Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.*/

using System;
using System.Text;

class Program
{
    static void Main()
    {
        // change console current encoding to UTF8
        Console.OutputEncoding = Encoding.UTF8;

        char copyRight = '\u00A9';
        // Console.WriteLine(copyRight);

        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());
        int cols = (rows * 2) - 1; // this is the unique formula for all measures

        int[,] matrix = new int[rows, cols];

        int currentRow = 0;
        int currentCol = cols / 2;

        for (int i = 0; i < rows; i++)
        {
            if (i + 1 == rows)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j % 2 == 0)
                    {
                        matrix[currentRow, j] = 1;
                    }
                }
            }

            matrix[currentRow, currentCol - i] = 1;
            matrix[currentRow, currentCol + i] = 1;
            currentRow++;
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 1)
                {
                    Console.Write(copyRight);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
