using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking.Tests
{
    [TestFixture]
    public class NQueensProblemSolverTest
    {
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(8)]
        public void GetSolutions_OnValidParams_HasAtLeastOneSolution(int numberOfQueens)
        {
            //Arrange
            var nQueensProblemSolver = new NQueensProblemSolver(numberOfQueens);
            //Act
            var result = nQueensProblemSolver.GetSolutions();
            //Assert
            Assert.GreaterOrEqual(result.Count, 1);
        }

        [TestCase(3)]
        public void GetSolutions_OnHasNoSolutionParams_HasNoSolutions(int numberOfQueens)
        {
            //Arrange
            var nQueensProblemSolver = new NQueensProblemSolver(numberOfQueens);
            //Act
            var result = nQueensProblemSolver.GetSolutions();
            //Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
