namespace Matthew.Vandergrift.Technical.Screening.Areas.LinkedList.Singly
{
    public static class SinglyLinkedListExpression
    {
        public static SinglyLinkedListNode GetNodeAtFirstAddedFromFront<T>(this SinglyLinkedList<T> list, int position)
        {
            var mark = list.GetFirstAddedFromFrontNode();
            var i = 0;
            while (i < position)
            {
                mark = mark?.Next;
                i++;
            }
            return mark;
        }
    }
}