using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class Matrix
    {
        private int[,] _data;

        public Matrix(int Rows, int Columns)
        {
            _data = new int[Rows, Columns];
        }

        public int Rows { get { return _data.GetLength(0); } }

        public int Columns { get { return _data.GetLength(1); } }

        public int this[int row, int column]
        {
            get
            {
                return _data[row, column];
            }
            set
            {
                _data[row, column] = value;
            }
        }

        public static Matrix operator +(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.Rows != matrixB.Rows || matrixA.Columns != matrixB.Columns)
            {
                throw new ApplicationException("The matrices must be of the same dimension ");
            }

            Matrix result = new Matrix(matrixA.Rows, matrixA.Columns);

            for (int i = 0; i < matrixA.Rows; i++)
            {
                for (int j = 0; j < matrixA.Columns; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var tmRow = new int[Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    tmRow[j] = this[i, j];
                }

                sb.AppendLine(string.Join("\t", tmRow));
                sb.AppendLine("");
            }
            return sb.ToString();
        }
    }
}
