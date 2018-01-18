using System;

namespace Matthew.Vandergrift.Technical.Screening.Areas.LinkedList.Singly
{
    public static class SinglyLinkedListExpression
    {
        public static SinglyLinkedListNode GetNodeAtPositionAddedFromFront<T>(this SinglyLinkedList<T> list, int position)
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

        public static int GetMinimumValueNodeFromFront<T>(this SinglyLinkedList<T> list)
        {
            var mark = list.GetHead();

            var smallest = (int)mark.Data;

            while (mark.Next != null)
            {
                var newValue = (int) mark.Data;
                if (smallest > newValue )
                    smallest = newValue;

                mark = mark.Next;
            }

            return smallest;
        }
    }
}