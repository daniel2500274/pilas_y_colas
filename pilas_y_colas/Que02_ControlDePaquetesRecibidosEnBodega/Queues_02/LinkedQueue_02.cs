using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que02_ControlDePaquetesRecibidosEnBodega.Queues_02
{
    public class LinkedQueue_02<T>
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


        public IEnumerable<T> AsEnumerable()
        {
            var current = front;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

    }

}
