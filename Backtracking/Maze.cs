using System;
using System.Diagnostics;

namespace Backtracking
{
    public class Maze
    {
        private char[,] _maze;

        public Maze(char[,] maze)
        {
            _maze = maze;
        }

        public bool Solve(uint startY, uint startX)
        {
            if (_maze[startY, startX] != 'S')
                throw new InvalidOperationException();

            return Move(startY, startX);
        }

        private bool Move(uint y, uint x)
        {
            if (y < 0 || y > _maze.GetLength(0) || x < 0 || x > _maze.GetLength(1))
                return false;

            if (_maze[y, x] == 'X')
                return true;

            if (_maze[y, x] == '#' || _maze[y, x] == '*')
                return false;

            if (_maze[y, x] == ' ')
                _maze[y, x] = '*';
#if DEBUG
            Print();
#endif
            if (Move(y, x + 1))
                return true;

            if (Move(y - 1, x))
                return true;

            if (Move(y + 1, x))
                return true;

            if (Move(y, x - 1))
                return true;

            return false;
        }

        private void Print()
        {
            Debug.WriteLine(String.Empty);
            for (var i = 0; i < _maze.GetLength(0); i++)
            {
                for (var j = 0; j < _maze.GetLength(1); j++)
                {
                    //if (_maze[i, j] == '*')
                        //Console.BackgroundColor = ConsoleColor.Green;
                    //if (_maze[i, j] == '#')
                            //Console.BackgroundColor = ConsoleColor.Blue;

                    Debug.Write(_maze[i, j]);
                    //Console.ResetColor();
                }
                Debug.WriteLine(String.Empty);
            }
        }
    };
}
