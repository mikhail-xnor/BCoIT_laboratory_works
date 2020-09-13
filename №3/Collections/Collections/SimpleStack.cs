using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class SimpleStack<T> : SimpleListProject.SimpleList<T>
        where T : IComparable
    {
        public void Push(T element)
        {
            SimpleListProject.SimpleListItem<T> newItem = new SimpleListProject.SimpleListItem<T>(element);
            if (last == null)
                Add(element);
            else
            {
                Count++;
                newItem.next = first;
                first = newItem;
            }
            
        }
        public T Pop()
        {
            if (first == null) throw new Exception("Out of range!");
            T tmp = first.data;
            first = first.next;
            return tmp;
        }
    }
}
