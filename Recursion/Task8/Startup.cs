using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Startup
    {
        private static string[,] matrix = new string[,]
        {
            {" ","*","*","*","*","*","*" },
            {" ","*","*","*","*","e","*" },
            {" "," ","*","*","*"," ","*" },
            {"*"," "," "," ","*"," "," " },
            {"*","*","*"," "," ","*"," " },
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
            var r = matrix.GetLength(0) - 1;
            if (row < r)
            {
                if (matrix[row + 1, col] == " " || matrix[row + 1, col] == "e")
                {
                    FindExit(row + 1, col);
                }

            }

            if ((col < (matrix.GetLength(1) - 1)) &&( matrix[row, col + 1] == " " || matrix[row, col + 1] == "e"))
            {
                FindExit(row, col + 1);
            }

            if (row > 0 && (matrix[row - 1, col] == " " || matrix[row - 1, col] == "e"))
            {
                FindExit(row - 1, col);
            }
            if (col > 0 &&( matrix[row, col - 1] == " " || matrix[row, col - 1] == "e"))
            {
                FindExit(row, col - 1);
            }

            matrix[row, col] = " ";
        }
    }
}
