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
        public void GetSolutions_OnValidParams_ReturnsNotNull(int numberOfQueens)
        {
            //Arrange
            var nQueensProblemSolver = new NQueensProblemSolver(numberOfQueens);
            //Act
            var result = nQueensProblemSolver.GetSolutions();
            //Assert
            Assert.IsNotNull(result);
        }

        [TestCase(3)]
        public void GetSolutions_OnHasNoSolutionParams_ReturnsNull(int numberOfQueens)
        {
            //Arrange
            var nQueensProblemSolver = new NQueensProblemSolver(numberOfQueens);
            //Act
            var result = nQueensProblemSolver.GetSolutions();
            //Assert
            Assert.IsNull(result);
        }
    }
}
