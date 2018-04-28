using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests
{
    [Category("LinkedList")]
    [TestFixture]
    public class LinkedListTest
    {
        private static IEnumerable<object> GetPrintTestSource()
        {
            yield return new object[] { null, Enumerable.Empty<int>() };

            yield return new object[] { new LinkedListNode<int> {
                                                                    Data = 0,
                                                                    Next = new LinkedListNode<int>{
                                                                        Data = 1,
                                                                        Next = new LinkedListNode<int>{
                                                                            Data = 2
                                                                        }
                                                                    }
                                                                },
                                                                new int[] { 0, 1, 2}
            };
        }

        [TestCaseSource("GetPrintTestSource")]
        public void Print_OnValidParams_ReturnsExpecetedResult(LinkedListNode<int> linkedListNode, IEnumerable<int> expectedResult)
        {
            //Act
            var actualResult = linkedListNode.Print();
            //Assert
            CollectionAssert.AreEqual(actualResult, expectedResult);
        }


        private static IEnumerable<object> GetRemoveAtTestSource()
        {
            yield return new object[] {
                                            new LinkedListNode<int> {
                                                                        Data = 0,
                                                                        Next = new LinkedListNode<int>{
                                                                            Data = 1,
                                                                            Next = new LinkedListNode<int>{
                                                                                Data = 2
                                                                            }
                                                                        }
                                                                    },
                                                                1u,
                                            new LinkedListNode<int> {
                                                                        Data = 0,                                                                       
                                                                        Next = new LinkedListNode<int>{
                                                                            Data = 2
                                                                        }                                                                        
                                                                    }
            };
        }        

        [TestCaseSource("GetRemoveAtTestSource")]
        public void RemoveAt_OnValidParams_ReturnsExpecetedResult(LinkedListNode<int> linkedListNode, uint pos, LinkedListNode<int> expectedResult)
        {
            //Act
            linkedListNode.RemoveAt(pos);
            //Assert     
            while (expectedResult != null) {
                Assert.AreEqual(linkedListNode.Data, expectedResult.Data);
                expectedResult = expectedResult.Next;
                linkedListNode = linkedListNode.Next;
            }
        }

        private static IEnumerable<object> GetRemoveAt_OnInvalidPosition_ThrowsArgumentOutOfRangeExceptionTestSource()
        {
            yield return new object[] {
                                            new LinkedListNode<int> {
                                                                        Data = 0,
                                                                        Next = new LinkedListNode<int>{
                                                                            Data = 1,
                                                                            Next = new LinkedListNode<int>{
                                                                                Data = 2
                                                                            }
                                                                        }
                                                                    },
                                                                3u
            };
            yield return new object[] {
                                            new LinkedListNode<int> {
                                                                        Data = 0,
                                                                        Next = new LinkedListNode<int>{
                                                                            Data = 1,
                                                                            Next = new LinkedListNode<int>{
                                                                                Data = 2
                                                                            }
                                                                        }
                                                                    },
                                                                5u
            };
        }

        [TestCaseSource("GetRemoveAt_OnInvalidPosition_ThrowsArgumentOutOfRangeExceptionTestSource")]
        public void RemoveAt_OnInvalidPosition_ThrowsArgumentOutOfRangeException(LinkedListNode<int> linkedListNode, uint pos)
        {
            //Act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => linkedListNode.RemoveAt(pos));
        }

        [Test]
        public void RemoveAt_OnNullLinkedList_ThrowsArgumentNullException()
        {
            //Arrange
            LinkedListNode<int> linkedListNode = null;
            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => linkedListNode.RemoveAt(0));
        }

        private static IEnumerable<object> GetReverseTestSource()
        {
            yield return new object[] { null, null };

            yield return new object[] {
                                            new LinkedListNode<int> {
                                                                        Data = 0,
                                                                        Next = null
                                                                    },
                                            new LinkedListNode<int> {
                                                                        Data = 0,
                                                                        Next = null
                                                                    }
            };

            yield return new object[] {
                                            new LinkedListNode<int> {
                                                                        Data = 0,
                                                                        Next = new LinkedListNode<int>{
                                                                            Data = 1,
                                                                            Next = new LinkedListNode<int>{
                                                                                Data = 2
                                                                            }
                                                                        }
                                                                    },
                                            new LinkedListNode<int> {
                                                                        Data = 2,
                                                                        Next = new LinkedListNode<int>{
                                                                            Data = 1,
                                                                            Next = new LinkedListNode<int>{
                                                                                Data = 0
                                                                            }
                                                                        }
                                                                    }

            };
        }

        [TestCaseSource("GetReverseTestSource")]
        public void Reverse_ReturnsExpecetedResult(LinkedListNode<int> linkedListNode,  LinkedListNode<int> expectedResult)
        {
            //Act
            var actualResult = linkedListNode.Reverse();
            //Assert     
            while (expectedResult != null)
            {
                Assert.AreEqual(actualResult.Data, expectedResult.Data);
                expectedResult = expectedResult.Next;
                actualResult = actualResult.Next;
            }
        }
    }


}
