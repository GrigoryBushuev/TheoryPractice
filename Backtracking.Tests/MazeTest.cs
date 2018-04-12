using NUnit.Framework;

namespace Backtracking.Tests
{
    [TestFixture]
    public class MazeTest
    {
        private Maze _maze;

        [SetUp]
        public void Init()
        {
            _maze = new Maze(new char[,] {
                                         {'#','#','#','S','#','#','#','#','#','X','#'}
                                          ,{'#',' ','#',' ','#',' ','#',' ','#',' ','#'}
                                          ,{'#',' ','#',' ',' ',' ','#',' ','#',' ','#'}
                                        ,{'#',' ','#',' ','#',' ',' ',' ','#',' ','#'}
                                        ,{'#',' ',' ',' ','#','#','#','#','#',' ','#'}
                                        ,{'#',' ','#','#','#',' ','#',' ','#',' ','#'}
                                        ,{'#',' ','#',' ','#',' ',' ',' ','#',' ','#'}
                                        ,{'#',' ',' ',' ','#',' ','#',' ','#',' ','#'}
                                        ,{'#',' ','#',' ',' ',' ','#',' ',' ',' ','#'}
                                        ,{'#','#','#','#','#','#','#','#','#','#','#'}
                                        });
        }
        
        [TestCase(0, 3)]
        public void Solve_OnValidParams_ReturnsTrue(int startY, int startX)
        {
            //Act
            var result = _maze.Solve((uint)startY, (uint)startX);
            //Assert
            Assert.IsTrue(result);
        }


        
    }
}
