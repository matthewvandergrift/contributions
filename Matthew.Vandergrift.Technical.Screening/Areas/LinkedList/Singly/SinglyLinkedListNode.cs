namespace Matthew.Vandergrift.Technical.Screening.Areas.LinkedList.Singly
{
    public class SinglyLinkedListNode
    {
        public SinglyLinkedListNode Next;
        public object Data;

        public SinglyLinkedListNode()
        {
        }

        public SinglyLinkedListNode(object data)
        {
            Data = data;
            Next = null;
        }
    }
}