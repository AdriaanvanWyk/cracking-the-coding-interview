// Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0
using System;
using System.Collections.Generic;

namespace ArraysAndStrings.exercise8 
{
    
    class Program
    {

        static void Main(string[] args)
        {

            //int[,] inputMatrix = new int[,] {{1, 3, 5}, {2, 4, 6}, {0, 7, 0}};
            //int[,] inputMatrix = new int[,] {{1, 0, 5}, {2, 4, 6}, {3, 7, 3}};
            //int[,] inputMatrix = new int[,] {{1, 3, 5}, {2, 4, 6}, {0, 7, 0}};
            int[,] inputMatrix = new int[,] {{1, 1, 1}, {2, 2, 6}, {8, 7, 9}};

            Program program = new Program();

            int[,] zeroMatrix = program.createZeroMatrix(inputMatrix);

            for(int row=0; row < zeroMatrix.GetLength(0); row++)
            {
                string srow = "";
                for(int col=0; col < zeroMatrix.GetLength(1); col++)
                {
                    srow += $"{zeroMatrix[row, col].ToString()} ";
                }
                Console.WriteLine(srow);
            }

        }


        int[,] createZeroMatrix(int[,] inputMatrix)
        {
            
            List<(int, int)> zeroLocations = getMatrixZeroLocations(inputMatrix);

            Console.WriteLine("Hello");
            foreach((int row, int col) index in zeroLocations)
            {
                for(int currentRow=0; currentRow < inputMatrix.GetLength(0); currentRow++)
                {
                    inputMatrix[currentRow, index.col] = 0;
                }

                for(int currentCol=0; currentCol < inputMatrix.GetLength(1); currentCol++)
                {
                    inputMatrix[index.row, currentCol] = 0;
                }
            }

            return inputMatrix;
        }

        List<(int, int)> getMatrixZeroLocations(int[,] inputMatrix)
        {

            List<(int, int)> zeroLocations = new List<(int, int)>();
            for(int row=0; row < inputMatrix.GetLength(0); row++)
            {
                for(int col=0; col < inputMatrix.GetLength(1); col++)
                {
                    if(inputMatrix[row, col] == 0)
                    {
                        zeroLocations.Add((row, col));
                    }
                }
            }

            return zeroLocations;
        }
    }
}