namespace Matthew.Vandergrift.Technical.Screening.Areas.LinkedList.Doubly
{
    public class DoublyLinkedListNode
    {
        public object Data;
        public DoublyLinkedListNode Next;
        public DoublyLinkedListNode Prev;

        public DoublyLinkedListNode()
        {
        }


        public DoublyLinkedListNode(object data)
        {
            Data = data;
            Prev = null;
            Next = null;
        }
    }
}