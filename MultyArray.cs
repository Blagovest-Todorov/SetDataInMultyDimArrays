using System;
using System.Co0llections.Generic;

namespace _03.multyDimArrayTutorial
{
    class MultyArray
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 5]; //we create array matrix of 2 rows and  2 columns
            for (int row = 0; row < numbers.GetLength(0); row++)  //0 menas get lenght by row /
            {
                for (int col = 0; col < numbers.GetLength(1); col++) //get lenght 1 mean get lenght of the columns
                {
                    int value = int.Parse(Console.ReadLine());
                    numbers[row, col] = value; //on curerent row columns it asignes the current value input;

                }
                //it is recommended to use lists in stead of oneDimensionalArrays;
                //List<int> numbersList = new List<int>();
            }

        }
    }
}
