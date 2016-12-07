using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens
{
    class Startup
    {
        private static int count = 0;
        static void Main(string[] args)
        {
            PlaceQueens(new bool[8, 8], new int[8, 8], 0);
            Console.WriteLine(count);
        }

        private static void PlaceQueens(bool[,] board, int[,] occupied, int columnIndex)
        {
            if (columnIndex == 8)
            {
                for (int i = 0; i < 8; i++)
                {

                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(board[i,j] + " ");
                        count++;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                return;
            }

            for (int rowIndex = 0; rowIndex < 8; rowIndex++)
            {
                if (occupied[rowIndex,columnIndex]==0)
                {
                    board[rowIndex, columnIndex] = true;
                    Occupy(occupied, rowIndex, columnIndex, 1);
                    PlaceQueens(board, occupied, columnIndex + 1);
                    Occupy(occupied, rowIndex, columnIndex, -1);
                    board[rowIndex, columnIndex] = false;

                }
            }
        }

        private static void Occupy(int[,] occupied, int roxIndex, int colIndex, int value)
        {
            for (int i = 0; i < 8; i++)
            {
                occupied[roxIndex, i] += value;
                occupied[i, colIndex] += value;
                if (colIndex + i < occupied.GetLength(0) && roxIndex + i < occupied.GetLength(0))
                {
                    occupied[roxIndex + i, colIndex + i] += value;
                }

                if (colIndex+ i < occupied.GetLength(0) && roxIndex - i >= 0)
                {
                    occupied[roxIndex- i, colIndex+ i] += value;
                }
            }
        }
    }
}
