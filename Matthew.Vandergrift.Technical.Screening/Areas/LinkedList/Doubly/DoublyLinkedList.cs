using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matthew.Vandergrift.Technical.Screening.Areas.LinkedList.Doubly
{
    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode _head;

        public void AddNodeFromFront(T t)
        {
            var newNode = new DoublyLinkedListNode()
            {
                Data = t,
                Next = _head,
                Prev = null
            };

            if (_head != null)
                _head.Prev = newNode;

            _head = newNode;
        }

        public void AddNodeFromLast(T t)
        {
            var newNode = new DoublyLinkedListNode()
            {
                Data = t,
                Next = _head,
                Prev = null
            };

            if (_head != null)
                _head.Prev = newNode;

            _head = newNode;
        }

        public DoublyLinkedListNode GetHead()
        {
            return _head;
        }

        public T GetFirstAddedFromFrontData()
        {
            return (T)GetHead().Next.Data;
        }

        public DoublyLinkedListNode GetFirstAddedFromFrontNode()
        {
            return GetHead().Next;
        }

        public DoublyLinkedListNode GetLastAddedFromFrontNode()
        {
            var temp = _head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }
    }
}