using System;
using System.Collections.Generic;
using System.Linq;

namespace UdemyIntermediate
{
    public class Stack
    {
        private readonly List<object> stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Failed: null object added to stack!");
            }

            stack.Add(obj);
        }

        public void Clear()
        {
            stack.Clear();
        }

        public object Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Failed: stack is empty! Cannot get the top object from the stack.");
            }

            object pop = stack.Last();
            stack.RemoveAt(stack.Count - 1);
            return pop;
        }
    }
}
