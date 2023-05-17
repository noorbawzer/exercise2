using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    class Matrix
    {

        private int rows;
        private int columns;
        private int[,] matrix;
        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
        }
        public void ReadMatrix()
        {
            Console.WriteLine("enter the elements of the matrix :");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("[" + i + "]" + "[" + j + "] =");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Transpose()
        {
            int[,] TransposedMatrix = new int[columns, rows];
            Console.WriteLine("Transpose is :");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                     TransposedMatrix[j,i]=matrix[i,j];
                }
            }
            matrix = TransposedMatrix;
            int temp = rows;
            rows = columns;
            columns = temp;
        }
        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{ matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}




  