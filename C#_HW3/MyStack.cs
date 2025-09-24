using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW3
{
    internal class MyStack<T>
    {
        private readonly Stack<T> stk;
        public MyStack() { stk = new Stack<T>(); }
        public int Count() { return stk.Count; }
        public void Push(T obj) { stk.Push(obj); }
        public T Pop() { return stk.Pop(); }
    }
}
