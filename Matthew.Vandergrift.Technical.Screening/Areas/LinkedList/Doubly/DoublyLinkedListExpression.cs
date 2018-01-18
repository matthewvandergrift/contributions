using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matthew.Vandergrift.Technical.Screening.Areas.LinkedList.Doubly
{
    public static class DoublyLinkedListExpression
    {
        public static DoublyLinkedList<int> DeleteNodeAtPositionStartingFromFront(this DoublyLinkedList<int> linkedList, int position)
        {
            var mark = FindDoublyLinkedListNodeAtPositionStartingFromFront(linkedList, position);

            mark.Prev.Next = mark.Next;
            mark.Next.Prev = mark.Prev;
            mark.Prev = null;
            mark.Next = null;

            return linkedList;

        }

        public static DoublyLinkedListNode FindDoublyLinkedListNodeAtPositionStartingFromFront(this DoublyLinkedList<int> linkedList, int position)
        {
            var mark = linkedList.GetHead();
            var i = 0;

            while (i < position - 1)
            {
                mark = mark.Next;
                i += 1;
            }

            return mark;

        }
    }
}