using System.Collections.Generic;

namespace Matthew.Vandergrift.Technical.Screening.Areas.LinkedList
{
    public static class GenericLinkedListExpression
    {
        public static LinkedListNode GetNodeAt<T>(this GenericLinkedList<T> list, int position)
        {
            var mark = list.GetFirstAddedNode();
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