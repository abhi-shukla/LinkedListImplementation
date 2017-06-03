using System;

namespace LinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new Node { Value = 3 };
            var second = new Node { Value = 5 };
            //first.Next = second;
            var third = new Node { Value = 7 };
            //second.Next = third;
            //PrintNodes(first); 

            var linkedList = new MyLinkedList();
            linkedList.AddToFront(third);
            linkedList.AddToFront(second);
            linkedList.AddToFront(first);

            //PrintLinkedList(linkedList);

            var otherLinkedList = new MyLinkedList();
            otherLinkedList.AddToEnd(first);
            otherLinkedList.AddToEnd(second);
            otherLinkedList.AddToEnd(third);

            PrintLinkedList(otherLinkedList);
        }

        private static void PrintNodes(Node node)
        {            
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;                
            }

            Console.ReadLine();
        }

        private static void PrintLinkedList(MyLinkedList linkedList)
        {
            while (linkedList.Head != null)
            {
                Console.WriteLine(linkedList.Head.Value);
                linkedList.Head = linkedList.Head.Next;
            }

            Console.ReadLine();
        }
    }
}
