using System;

namespace Tateti
{
    public class TicTacToe
    {
   
        public string[,] Grid;

        public TicTacToe(string [,] gridarr, int arrSize)
        {
            this.Size = arrSize;
            this.Grid = gridarr;

        }

        public int Size { get; set; }

        public bool Horizontal(string[,] grid, int size, string symbol)
        {
            bool retval = false;
            bool[] winnerlines = new bool[size];
            for (int i = 0; i < size; i++)
            {
                winnerlines[i] = false;
            }
            int winner = 0;
            for (int line=0; line < size; line++)
            {
                winner = 0;

                for ( int column = 0; column < size; column++ )
                {
                    if (grid[line, column] == symbol)
                    {
                        winner+=1;
                    }
                }

                if (winner == size)
                {
                    winnerlines[line] = true;
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (winnerlines[i] == true)
                {
                    retval = true;
                    break;
                }
            }
            return retval;
        }

        public bool Vertical(string[,] grid, int size, string symbol)
        {
            bool retval = false;
            bool[] winnercolumns = new bool[size];
            int winner = 0;
            for (int i = 0; i < size; i++)
            {
                winnercolumns[i] = false;
            }
            for (int column = 0; column < size; column++)
            {
                winner = 0;

                for (int line = 0; line < size; line++)
                {
                    if (grid[line, column] == symbol)
                    {
                        winner+=1;
                    }
                }

                if (winner == size)
                {
                    winnercolumns[column]=true;
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (winnercolumns[i] == true)
                {
                    retval = true;
                    break;
                }
            }
            return retval;
        }

        public bool DiagonalDown(string[,] grid, int size, String symbol)
        {
            int winner = 0;

            int column = 0;

            for (int line = 0; line < size; line++)
            {
                column = line;

                if (grid[line, column] == symbol)
                {
                    winner+=1;
                }
            }

            if (winner == size)
            {
                return true;
            }

            return false;
        }

        public bool DiagonalUp(string[,] grid, int size, String symbol)
        {
            int winner = 0;

            int column = 0;

            for (int line = 0; line < size; line++)
            {
                column = line;

                if (grid[size - line - 1, column] == symbol)
                {
                    winner+=1;
                }
            }

            if (winner == size)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        { 
            bool HorizontalWinner = false;
            bool VerticalWinner = false;
            bool DiagonalDownWinner = false;
            bool DiagonalUpWinner = false;

            int Size = 3;
            string[,] grid = new string[Size, Size];
            grid[0, 0] = "+";                      //  + * +
            grid[0, 1] = "*";                      //  * + +
            grid[0, 2] = "+";                      //  * * +
            grid[1, 0] = "*";
            grid[1, 1] = "+";
            grid[1, 2] = "+";
            grid[2, 0] = "*";
            grid[2, 1] = "*";
            grid[2, 2] = "+";

            TicTacToe aTicTacToe = new TicTacToe(grid, Size);

            HorizontalWinner = aTicTacToe.Horizontal(grid, Size, "+");
            VerticalWinner = aTicTacToe.Vertical(grid, Size, "+");
            DiagonalDownWinner = aTicTacToe.DiagonalDown(grid, Size, "+");
            DiagonalUpWinner = aTicTacToe.DiagonalUp(grid, Size, "+");

            if (HorizontalWinner || VerticalWinner || DiagonalDownWinner || DiagonalUpWinner )
            {
                System.Console.WriteLine("Hey, we have a winner!!!...");
            }
            else
            {
                System.Console.WriteLine("Oops, no winner!...");
            }
            System.Console.ReadKey();
        }
    }
}
