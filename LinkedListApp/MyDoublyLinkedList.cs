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
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
