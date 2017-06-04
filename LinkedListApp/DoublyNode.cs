namespace LinkedListApp
{
    public class DoublyNode<T>
    {
        public T Value { get; set; }

        public DoublyNode<T> Next { get; set; }

        public DoublyNode<T> Previous { get; set; }

        public DoublyNode(T value)
        {
            Value = value;
        }
    }
}
