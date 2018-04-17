using System;
using System.Diagnostics;

namespace Backtracking
{
    public class NQueensProblemSolver
    {
        private char[,] _board;
        private int _queensNumber;

        private const char EmptyCell = '.';
        private const char OccupiedCell = 'q';

        public NQueensProblemSolver(int queensNumber)
        {
            _queensNumber = queensNumber;
            _board = new char[queensNumber, queensNumber];
            Clear();
        }

        private void Print()
        {
            for (var i = 0; i < _board.GetLength(0); i++)
            {
                Debug.WriteLine(String.Empty);
                for (var j = 0; j < _board.GetLength(0); j++)
                {
                    Debug.Write(_board[i, j]);
                }
            }
            Console.WriteLine();
        }

        private void Clear()
        {
            for (var i = 0; i < _board.GetLength(0); i++)
            {
                for (var j = 0; j < _board.GetLength(0); j++)
                {
                    _board[i, j] = EmptyCell;
                }
            }
        }

        public char[,] GetSolutions()
        {

            if (!GetSolution(0, 0))
                return null;
#if DEBUG
            Print();
#endif
            return _board;
        }

        private bool GetSolution(int y, int x)
        {
            if (!IsUnderAttack(y, x))
            {
                _board[y, x] = OccupiedCell;
                if (y == _board.GetLength(0) - 1 || GetSolution(y + 1, 0))
                    return true;
                else
                    _board[y, x] = EmptyCell;                
            }
            if (x < _board.GetLength(1) - 1)
                return GetSolution(y, x + 1);
           
            return false;
        }

        private bool IsUnderAttack(int y, int x)
        {
            if (_board[y, x] == OccupiedCell)
                return true;

            for (var i = 0; i < _board.GetLength(0); i++)
            {
                if (_board[y, i] == OccupiedCell || _board[i, x] == OccupiedCell)
                    return true;

                var x1Pos = x;
                var y1Pos = y;

                if (x1Pos - i >= 0 && y1Pos - i >= 0 && _board[y1Pos - i, x1Pos - i] == OccupiedCell)
                    return true;

                var x2Pos = x;
                var y2Pos = y;
                if (x2Pos - i >= 0 && y2Pos + i < _board.GetLength(0) && _board[y2Pos + i, x2Pos - i] == OccupiedCell)
                    return true;


                var x3Pos = x;
                var y3Pos = y;
                if (x3Pos + i < _board.GetLength(0) && y3Pos - i >= 0 && _board[y3Pos - i, x3Pos + i] == OccupiedCell)
                    return true;

                var x4Pos = x;
                var y4Pos = y;
                if (x4Pos + i < _board.GetLength(0) && y4Pos + i < _board.GetLength(0) && _board[y4Pos + i, x4Pos + i] == OccupiedCell)
                    return true;
            }
            return false;
        }
    }
}