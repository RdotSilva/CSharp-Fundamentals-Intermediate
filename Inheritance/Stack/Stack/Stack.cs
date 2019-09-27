using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> _stackList = new List<object>();

        public void Push(object item)
        {
            if (item == null)
                throw new InvalidOperationException("Item can't be null.");

            _stackList.Add(item);
            
        }

        public object Pop()
        {
            if (_stackList.Count == 0)
                throw new InvalidOperationException("No elements in stack.");

            var index = _stackList.Count - 1;

            var poppedItem = _stackList[index];

            _stackList.RemoveAt(index);

            return (poppedItem);
        }

        public void Clear()
        {
            _stackList.Clear();
        }
    }
}