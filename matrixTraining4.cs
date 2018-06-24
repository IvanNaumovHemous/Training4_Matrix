using System;

namespace matrixTraining4
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            int[,] matrix = GetMatrix(size);

            PrintMatrix(matrix);        
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] GetMatrix(int size)
        {
            var matrix = new int[size, size];
            var rows = matrix.GetLength(0) - 1;
            var columns = 0;
            var counter = 2;

            matrix[rows, columns] = 1;

            FirstFigure(matrix, rows, columns, counter);

            matrix[0, matrix.GetLength(1) - 1] = size * size;
            counter = size * size - 1;

            SecondFigure(matrix, rows, columns, counter);
           
            return matrix;
        }

        private static void SecondFigure(int[,] matrix, int rows, int columns, int counter)
        {
            for (int c = 1; c < matrix.GetLength(0) - 1; c++)
            {
                rows = c;
                columns = matrix.GetLength(1) - 1;

                for (int d = 0; d <= c; d++)
                {
                    matrix[rows, columns] = counter;
                    rows--;
                    columns--;
                    counter--;
                }
            }
        }

        private static void FirstFigure(int[,] matrix, int rows, int columns, int counter)
        {
            for (int a = 1; a < matrix.GetLength(0); a++)
            {
                rows = matrix.GetLength(0) - a - 1;
                columns = 0;

                for (int b = 0; b <= a; b++)
                {
                    matrix[rows, columns] = counter;
                    rows++;
                    columns++;
                    counter++;
                }
            }
        }
    }
}
