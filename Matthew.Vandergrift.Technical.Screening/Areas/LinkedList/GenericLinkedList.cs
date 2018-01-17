namespace Matthew.Vandergrift.Technical.Screening.Areas.LinkedList
{
    public class GenericLinkedList<T>
    {
        private LinkedListNode _head;

        // Add a node at the beginning of the list with t as its data value.
        public void AddNode(T t)
        {
            var newNode = new LinkedListNode
            {
                Next = _head,
                Data = t
            };
            _head = newNode;
        }

        public LinkedListNode GetHead()
        {
            return _head;
        }

        public T GetFirstAddedData()
        {
            return (T)GetHead().Next.Data;
        }

        public LinkedListNode GetFirstAddedNode()
        {
            return GetHead().Next;
        }

        public LinkedListNode GetLastAddedNode()
        {
            var temp = _head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

        public void Reverse()
        {
            LinkedListNode prev = null;

            var current = _head;
            while (current != null)
            {
                var temp = current.Next;
                current.Next = prev;
                prev = current;
                current = temp;
            }

            _head = prev;
        }
    }
}