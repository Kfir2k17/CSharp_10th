using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace Introduction___1
{
    class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node(T x)
        {
            value = x;
            this.next = null;
        }

        public Node(T x, Node<T> next)
        {
            value = x;
            this.next = next;
        }

        public T GetValue() { return value; }
        public Node<T> GetNext() { return next; }
        public void SetValue(T x) { value = x; }
        public void SetNext(Node<T> n) { next = n; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
