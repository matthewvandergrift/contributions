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

        // The following method returns the data value stored in the last node in
        // the list. If the list is empty, the default value for type T is
        // returned.
        public T GetFirstAdded()
        {
            // The value of temp is returned as the value of the method. 
            // The following declaration initializes temp to the appropriate 
            // default value for type T. The default value is returned if the list is empty.
            var value = default(T);

            var current = _head;
            while (current != null)
            {
                value = (T) current.Data;
                current = current.Next;
            }
            return value;
        }
    }
}