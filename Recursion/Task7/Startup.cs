using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Startup
    {
        private static string[,] matrix = new string[,]
        {
            {" ","*","*","*","*","*","*" },
            {" ","*","*","*","*","*","*" },
            {" "," ","*","*","*","*","*" },
            {"*"," "," "," ","*","*","*" },
            {"*","*","*"," "," ","*","e" },
            {"*","*","*","*"," "," "," " },
        };

        private static List<string> coordinates = new List<string>();
        static void Main(string[] args)
        {
            FindExit(0, 0);
            Console.WriteLine(string.Join("\n\r", coordinates));
        }

        private static void FindExit(int row, int col)
        {
            if (col < 0 || row < 0 || col >= matrix.GetLength(1) || row >= matrix.GetLength(0))
            {
                return;
            }

            if (matrix[row, col] == "e")
            {
                coordinates.Add($"end at ({row}, {col})");
            }

            if (matrix[row, col] != " ")
            {
                return;
            }

            coordinates.Add($"move at ({row}, {col})");

            matrix[row, col] = "*";
            FindExit(row + 1, col);
            FindExit(row, col + 1);
            FindExit(row - 1, col);
            FindExit(row, col - 1);

            matrix[row, col] = " ";
        }
    }
}
