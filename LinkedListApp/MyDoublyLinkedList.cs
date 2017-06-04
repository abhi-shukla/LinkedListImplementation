using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListApp
{
    public class MyDoublyLinkedList<T> : ICollection<T>
    {
        public DoublyNode<T> Head { get; private set; }
        public DoublyNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void AddToFront(T item)
        {
            AddToFront(new DoublyNode<T>(item));
        }

        public void AddToFront(DoublyNode<T> node)
        {
            if(Count == 0)
            {
                Head = node;
                Tail = node;                
            }
            else
            {
                var temp = Head;
                Head = node;
                Head.Next = temp;
                temp.Previous = Head;
            }
            Count++;
        }

        public void AddToEnd(T item)
        {
            AddToEnd(new DoublyNode<T>(item));
        }

        public void AddToEnd(DoublyNode<T> node)
        {
            if(Count ==0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                var temp = Tail;
                Tail = node;
                temp.Next = Tail;
                Tail.Previous = temp;
            }
            Count++;
        }
       
        public void Add(T item)
        {
            AddToFront(new DoublyNode<T>(item));
        }

        public void RemoveFirst()
        {
            if (Count == 0) return;

            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Previous = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if (Count == 0) return;

            if(Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }

            Count--;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            var current = Head;
            while(current != null)
            {
                if(current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var current = Head;
            while(current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            if (Head.Value.Equals(item))
            {
                RemoveFirst();
                return true;
            }
            if (Tail.Value.Equals(item))
            {
                RemoveLast();
                return true;
            }

            var previous = Head;
            var current = Head.Next;

            while (current.Next != null)
            {
                if(current.Value.Equals(item))
                {
                    previous.Next = current.Next;
                    current.Next.Previous = previous;
                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
