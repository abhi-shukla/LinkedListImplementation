using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class MyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddToFront(Node node)
        {
            if(node != null)
            {
                if (Head == null && Tail == null)
                {
                    Head = node;
                    Tail = node;
                }
                else
                {
                    var temp = Head;
                    Head = node;
                    Head.Next = temp;
                }

            }
        }

        public void AddToEnd(Node node)
        {
            if(node != null)
            {
                if(Head == null && Tail == null)
                {
                    Head = node;
                    Tail = node;
                }
                else
                {
                    Tail.Next = node;
                    Tail = node;
                }
            }
        }
    }
}
