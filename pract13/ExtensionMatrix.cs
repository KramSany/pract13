using MatrixCool;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace pract13
{
    public static class ExtensionMatrix
    {
        public static void Create(this MatrixM<int> numbers, int row, int column)
        {
            int[,] matrix = new int[row, column];
            Random random = new();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
            numbers.Add(matrix);
        }
        public static MatrixM<double> Solving(this MatrixM<int> numbers)
        {
            double[] array = new double[numbers.ColumnCount];
            
            for (int j = 0; j < numbers.ColumnCount; j++)
            {
                double sumMid = 0;
                for (int i = 0; i < numbers.RowCount; i++)
                {
                    sumMid += numbers[i, j];
                }
                sumMid/=numbers.RowCount;
                array[j] = sumMid;
            }
            MatrixM<double> matrixWithSolvingValue = new MatrixM<double>(numbers.RowCount, numbers.ColumnCount);
            for (int j = 0; j < numbers.ColumnCount; j++)
            {
                for(int i = 0; i < numbers.RowCount; i++)
                {
                    if (numbers[i,j] > array[j])
                    {
                        matrixWithSolvingValue[i, j] = numbers[i, j];
                    }
                }
            }
            return matrixWithSolvingValue;
        }
    }
}
