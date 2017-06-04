using System;

namespace LinkedListApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var first = new Node<int>(3);
            var second = new Node<int>(5);
            //first.Next = second;
            var third = new Node<int>(7);
            //second.Next = third;
            //PrintNodes(first); 

            var linkedList = new MyLinkedList<int>();
            linkedList.AddToFront(third);
            linkedList.AddToFront(second);
            linkedList.AddToFront(first);
            //Print(linkedList);

            var otherLinkedList = new MyLinkedList<int>();
            otherLinkedList.AddToEnd(first);
            otherLinkedList.AddToEnd(second);
            otherLinkedList.AddToEnd(third);
            //Print(otherLinkedList);

            //otherLinkedList.RemoveLastNode();
            //Print(otherLinkedList);

            //otherLinkedList.RemoveLastNode();
            //Print(otherLinkedList);

            // Remove middle element from linkedlist
            otherLinkedList.Remove(5);
            Console.WriteLine("Expected 5 to be removed");
            Print(otherLinkedList);

            otherLinkedList = new MyLinkedList<int>();
            otherLinkedList.AddToEnd(first);
            otherLinkedList.AddToEnd(second);
            otherLinkedList.AddToEnd(third);



            otherLinkedList = new MyLinkedList<int>();
            otherLinkedList.AddToEnd(first);
            otherLinkedList.AddToEnd(second);
            otherLinkedList.AddToEnd(third);


            Console.ReadLine();
        }

        private static void Print<T>(MyLinkedList<T> linkedList)
        {
            foreach (var value in linkedList)
            {
                Console.WriteLine(value);
            }
        }

    }
}
