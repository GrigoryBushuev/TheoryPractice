using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Backtracking
{
    public class KnightsTour
    {
        private const int _boardSize = 8;
        private int[,] _board = new int[_boardSize, _boardSize];

        private static readonly List<(int x, int y)> _allMoves = new List<(int x, int y)>
        {
            (-2, 1),
            (-2, -1),
            (2, 1),
            (2, -1),
            (-1, 2),
            (1, 2),
            (-1, -2),
            (1, -2),
        };

        //1. Initialize the board
        //2. Set an initial position of the knight.
        //3. Define a list of all possible moves of the knight.

        //3. At each move generate a list of all possible moves from the current position.
        //4. For each valid position make a next move(mark a position in the board array by a number of the move) and go to 3 until we 
        //   found a solution or we can't make a valid move to continue.
        private void Print()
        {
            for (var y = 0; y < _board.GetLength(0); y++)
            {
                for (var x = 0; x < _board.GetLength(1); x++)
                {
                    Debug.Write($"{_board[y, x]} ");
                }
                Debug.WriteLine(String.Empty);
            }
        }

        private IEnumerable<(int Y, int X)> GetValidMoves(int y, int x)
        {
            //Enumerate from the list of _allMoves, check whether the move is valid
            var result = new List<(int, int)>();
            foreach (var possibleMove in _allMoves)
            {
                var nextMoveY = y + possibleMove.y;
                var nextMoveX = x + possibleMove.x;
                if (nextMoveY >= 0 && nextMoveY < _boardSize
                        && nextMoveX >= 0 && nextMoveX < _boardSize
                        && _board[nextMoveY, nextMoveX] == 0)
                    result.Add((nextMoveY, nextMoveX));
            }
            return result;
        }

        public bool Solve(int startYPos, int startXPos)
        {
            var isSolved = Solve(startYPos, startXPos, 1);
            if (isSolved)
                Print();
            return isSolved;
        }

        private bool IsSolved(int moveNumber)
        {
            return moveNumber == _boardSize * _boardSize;
        }

        private bool Solve(int y, int x, int moveNumber)
        {
            _board[y, x] = moveNumber;
            if (IsSolved(moveNumber))
                return true;
            var validMoves = GetValidMoves(y, x);
            if (validMoves.Any())
            {
                foreach (var move in validMoves)
                {
                    if (Solve(move.Y, move.X, moveNumber + 1))
                        return true;
                    else
                        _board[y, x] = 0;
                }
            }
            return false;
        }
    }
}
