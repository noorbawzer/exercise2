using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of rows :");
           int rows= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of columns : ");
           int columns = Convert.ToInt32(Console.ReadLine());
            Matrix mat = new Matrix(rows,columns);
            mat.ReadMatrix();
            Console.WriteLine(" the Matrix is :");
            mat.Print();
            mat.Transpose();
            mat.Print();
        }
    }
}
