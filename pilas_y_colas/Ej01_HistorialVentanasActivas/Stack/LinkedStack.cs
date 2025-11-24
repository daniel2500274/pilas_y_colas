using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01_HistorialVentanasActivas.Stack
{
    public class LinkedStack<T>
    {

        private Node<T> top;


        public bool IsEmpty() => this.top == null;

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = top;
            this.top = node;
        }

        public T Pop()
        {
            if (this.IsEmpty()) throw new InvalidOperationException("Pila vacía");

            T value = this.top.Value;
            this.top = this.top.Next;

            return value;
        }

        public T Peek()
        {
            if (this.IsEmpty()) throw new InvalidOperationException("Pila vacía");

            return this.top.Value;
        }

        public int Count()
        {
            int count = 0;
            Node<T> currentNode = this.top;


            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }

            return count;
        }
    }
}
