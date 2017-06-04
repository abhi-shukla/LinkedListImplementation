using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListApp
{
    public class MyLinkedList <T> : ICollection<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        public bool IsReadOnly 
        {
            get
            {
                return false;
            }
        }

        public void AddToFront(T value)
        {
            AddToFront(new Node<T>(value));
        }

        public void AddToFront(Node<T> node)
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
                Count++;
            }
        }

        public void AddToEnd(T value)
        {
            AddToEnd(new Node<T>(value));
        }

        public void AddToEnd(Node<T> node)
        {
            if(node != null)
            {
                Count++;
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

        public void RemoveLastNode()
        {
            if (Count == 0) return;

            Count--;

            if(Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var current = Head;
                while(current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }
        }

        public void RemoveFirstNode()
        {
            if (Count == 0) return;

            Count--;

            if(Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var current = Head;
                Head = Head.Next;
                current.Next = null;
            }
            
        }

        public void Add(T item)
        {
            AddToFront(item);
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            Node<T> current = Head;
            while(current != null)
            {
                if(current.Value.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> current = Head;
            while(current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            if (Head.Value.Equals(item))
            {
                RemoveFirstNode();
                return true;
            }

            if(Tail.Value.Equals(item))
            {
                RemoveLastNode();
                return true;
            }

            var previous = Head;
            var current = Head.Next;

            while(current.Next != null)
            {
                if(current.Value.Equals(item))
                {
                    previous.Next = current.Next;
                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
