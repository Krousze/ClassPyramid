using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            String rowCount = Console.ReadLine();
            int rowNumber;
            bool good = int.TryParse(rowCount, out rowNumber);

            while (!good) 
            { 
                Console.Write("Enter only whole numbers.\n");
                rowCount = Console.ReadLine();
                good = int.TryParse(rowCount, out rowNumber);


            }
         
                    for(int row = 0; row < rowNumber; row++)
            {

                for (int column = rowNumber; column > row; column--)
                    Console.Write(" ");

                for (int column = 0; column < (2 * row + 1); column++)
                    Console.Write("*");
                Console.WriteLine();
           
            }
            Console.ReadKey();
        }
    }
}
