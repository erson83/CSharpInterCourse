using System;
using System.Collections;


namespace DesignStack

{
    public class Stack
    {


        private Stack<object> _items = new Stack<object>();

        // for list, stacks, arrays, we do not have to intialize contstructors


        public void Push(object obj)
        {
            //Push() method stores the given object on top of the stack.
            if (obj == null)
            {
                throw new System.InvalidOperationException("cannot pass in null value.");
            }
            else
            {
                _items.Push(obj);
            }

        }

        public Object Pop()
        {
            //Pop() method removes the object on top of the stack and returns it.
            if (_items.Count == 0)
                throw new System.InvalidOperationException("cannot pop from empty stack");
            return _items.Pop();
        }


        public void Clear()
        { 
            //Clear() method removes all objects from the stack.

            _items.Clear();
        }



    }

}
