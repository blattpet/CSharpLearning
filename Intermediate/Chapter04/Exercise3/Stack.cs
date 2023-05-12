using System.Collections;

namespace Exercise3
{
    public class Stack
    {
        private readonly ArrayList _stack;

        public Stack() 
        { 
            _stack = new ArrayList();
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("You can't push an object that is null on the stack!");
            }

            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("The stack was empty!");
            } 
                
            object element = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return element;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}