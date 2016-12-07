using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueens
{
    class Startup
    {
        static void Main(string[] args)
        {
        }

        private static void PlaceQueens(bool[,] board, int[,] occupied, int columnIndex)
        {
            if (columnIndex == 8)
            {
                return;
            }
            for (int rowIndex = 0; rowIndex < 8; rowIndex++)
            {
                if (occupied[rowIndex,columnIndex]==0)
                {
                    board[rowIndex, columnIndex] = true;
                    MarkOccupied(occupied, 1, columnIndex, rowIndex);
                    PlaceQueens(board, occupied, columnIndex + 1);
                    board[rowIndex, columnIndex] = false;
                    MarkOccupied(occupied, -1, columnIndex, rowIndex);
                }
             
            }
        }

        private static void MarkOccupied(int[,] occupied, int value, int column, int row)
        {
            for (int i = 0; i < occupied.GetLength(0); i++)
            {
                occupied[i, column] += value;
                occupied[row, i] += value;

                if (column + i < occupied.GetLength(0) && row + i < occupied.GetLength(0))
                {
                    occupied[row + i, column + i] += value;
                }

                if (column + i < occupied.GetLength(0) && row - i >= 0)
                {
                    occupied[row - i, column + i] += value;
                }
            }
        }
    }
}
