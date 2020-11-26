using System;
using System.Collections.Generic;

namespace _03.multyDimArrayTutorial
{
    class MultyArray
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number of rows ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Please enter number of columns ");
            int cols = int.Parse(Console.ReadLine());

            int[,] numbers = new int[rows, cols];  //rows->the total number of the rows,cols->the total numebr of columns

            for (int row = 0; row < rows; row++)  //numbers.GetLenght(0); --we take the size of rows
            {                                       //row-> curretn row into the matrix
                for (int col = 0; col < cols; col++) //numbers.GetLenght(1) --we take the lenght ,the size of columns
                {                                     //col the current row into the Matrix 
                    Console.Write("Enter Matrix[{0}, {1}]", row, col);
                    numbers[row, col] = int.Parse(Console.ReadLine()); //opens a new console Line form  :
                                                                       //where we read currect number Element that we set to a position currentRow and currentCol i.e (0,0)

                }
            }
            Console.WriteLine("your matrix is :");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    //Console.WriteLine(numbers[row, col]);
                    Console.Write("{0}", numbers[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
