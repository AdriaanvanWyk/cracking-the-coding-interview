// How I understand it:
// Rotate an NxM matrix by 90 degrees
// [1, 2, 3]  [4, 1]
// [4, 5, 6]  [5, 2]
//            [6, 3]
// Mentions 4 bytes per array item, c# has 32 bit for ints?

// Misread the question, wasn't stated in an ideal way
// It was to just rotate a 4x4 array 
// Why return boolean for a non-member array variable rotation instead of returning the rotated matrix????
// Code below will rotate any matrix given to it, whatever size and return the rotated matrix
// Dumb question

using System;
using System.Collections;


namespace ArraysAndStrings 
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            int[,] matrix = new int[,] {{1, 2, 3}, {4, 5, 6}};
            int[,] big_matrix = new int[,] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            int[,] testMatrix3 = new int[,] {{1, 2}, {4, 5}, {7, 8}};

            int[,] newMatrix = program.rotateMatrix(big_matrix);

            for(int row=0; row < newMatrix.GetLength(0); row++)
            {
                string srow = "";
                for(int col=0; col < newMatrix.GetLength(1); col++)
                {
                    srow += $"{newMatrix[row, col].ToString()} ";
                }
                Console.WriteLine(srow);
            }


        }


        int[,] rotateMatrix(int[,] matrix)
        {

            int[,] new_matrix = new int[matrix.GetLength(1),matrix.GetLength(0)];

            for(int col=0; col < matrix.GetLength(1); col++)
            {
                for(int row=0; row < matrix.GetLength(0); row++)
                {
                    
                    int new_row = col;
                    int new_col = (matrix.GetLength(0)-1)-row;

                    Console.WriteLine($"== {matrix[row, col]} ==\nOld Row\tNew Row\n{row}\t{new_row}\nOld Col\tNew Col\n{col}\t{new_col}");

                    new_matrix[new_row, new_col] = matrix[row, col];
                }
            }

            return new_matrix;
        }
    }
}