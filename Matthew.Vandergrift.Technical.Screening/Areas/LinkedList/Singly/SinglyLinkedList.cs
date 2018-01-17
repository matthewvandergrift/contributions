namespace Matthew.Vandergrift.Technical.Screening.Areas.LinkedList.Singly
{
    public class SinglyLinkedList<T>
    {
        private SinglyLinkedListNode _head;

        // Add a node at the beginning of the list with t as its data value.
        public void AddNodeFromFront(T t)
        {
            var newNode = new SinglyLinkedListNode
            {
                Next = _head,
                Data = t
            };
            _head = newNode;
        }

        // Add a node at the end of the list with t as its data value.
        public void AddNodeFromLast(T t)
        {
            var newNode = new SinglyLinkedListNode(t);
            if (_head == null)
            {
                _head = newNode;
                return;
            }
            var lastNode = GetLastAddedFromFrontNode();
            lastNode.Next = newNode;
        }

        public SinglyLinkedListNode GetHead()
        {
            return _head;
        }

        public T GetFirstAddedFromFrontData()
        {
            return (T)GetHead().Next.Data;
        }

        public SinglyLinkedListNode GetFirstAddedFromFrontNode()
        {
            return GetHead().Next;
        }

        public SinglyLinkedListNode GetLastAddedFromFrontNode()
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
            SinglyLinkedListNode prev = null;

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