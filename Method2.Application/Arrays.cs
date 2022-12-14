using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class Arrays
    {
        public Arrays()
        {
            runUnidimensional();

            runBidimensional();
        }

        public void runUnidimensional()
        {
            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 50;
            numbers[2] = 100;

            Array.Resize<int>(ref numbers, 4);

            numbers[3] = 200;

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public void runBidimensional()
        {
            int[,] matriz = new int[2, 2];

            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[1, 0] = 3;
            matriz[1, 1] = 4;

            Console.WriteLine("matriz[1,1]: {0}", matriz[1, 1]);

            int[,] matrixB = new int[2, 2]
            {
                {3, 4},{5, 6}
            };

            Console.WriteLine("matrixB[1,1]: {0}", matrixB[1,1]);
            Console.WriteLine("");

            string[,] matrixC = new string[3, 2] {
                {"value1", "value2" },
                {"value3", "value4" },
                {"value5", "value6" }
            };

            WhiteArrayBidimensional<string>(matrixC);
        }

        public void WhiteArrayBidimensional<T>(T[,] matrix) {
            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);
            var sb = new StringBuilder();
            var tmRow = new T[matrix.GetLength(0)];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tmRow[j] = matrix[i, j];
                }
                sb.AppendLine(string.Join("\t", tmRow));
                //sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
