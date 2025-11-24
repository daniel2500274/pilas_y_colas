using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que01_ColaDeRestaurante.Queues
{
    public class LinkedQueue<T>
    {
        private Node<T>? front;
        private Node<T>? rear;

        public bool IsEmpty() => front == null;

        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);

            if (this.rear == null)
            {
                this.front = this.rear = node;
            }
            else
            {
                this.rear.Next = node;
                this.rear = node;
            }

        }
        public T Dequeue()
        {
            if (this.IsEmpty()) throw new InvalidOperationException("Cola Vacía");

            T value = this.front!.Value;

            this.front = this.front.Next;

            if (this.front == null)
            {
                this.rear = null;
            }

            return value;

        }


        public T Peek()
        {
            if (this.IsEmpty()) throw new InvalidOperationException("Cola Vacía");

            return this.front!.Value;
        }


        public int Count()
        {
            int count = 0;
            Node<T> currentNode = this.front;

            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }

            return count;
        }

    }
}
