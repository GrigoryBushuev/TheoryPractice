using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class LinkedList
    {

        public static void RemoveAt<T>(this LinkedListNode<T> linkedListNode, uint n)
        {
            if (linkedListNode == null)
                throw new ArgumentNullException(nameof(linkedListNode));

            var i = 0;
            while (i < n - 1)
            {
                if (linkedListNode == null)
                    throw new ArgumentOutOfRangeException(nameof(n));

                linkedListNode = linkedListNode.Next;
                i++;
            }

            if (linkedListNode.Next == null)
                throw new ArgumentOutOfRangeException(nameof(n));

            linkedListNode.Next = linkedListNode.Next.Next;
        }

        public static void RemoveDuplicates<T>(this LinkedListNode<T> linkedListNode)
        {

        }

        public static bool HasCycles<T>(this LinkedListNode<T> linkedListNode)
        {

            return true;
        }

        public static IEnumerable<T> Print<T>(this LinkedListNode<T> linkedListNode)
        {
            if (linkedListNode == null)
                yield break;

            while (linkedListNode != null)
            {
                yield return linkedListNode.Data;
                linkedListNode = linkedListNode.Next;
            }
        }

        public static LinkedListNode<T> Reverse<T>(this LinkedListNode<T> linkedListNode)
        {
            if (linkedListNode == null || linkedListNode.Next == null)
                return linkedListNode;

            var current = linkedListNode;
            LinkedListNode<T> tail = null;

            while (current != null) {
                var temp = current.Next;
                current.Next = tail;
                tail = current;
                current = temp;
            }
            return tail;
        }

    }
}
