using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQ01_BarraNavegacionEditorFotos.DQ01
{
    public class LinkedStackBQ01<T>
    {
        private Node<T>? front;
        private Node<T>? rear;

        public bool IsEmpty() => front == null;

        public void InsertRear(T value)
        {
            Node<T> node = new Node<T>(value);

            if (this.IsEmpty())
            {
                this.front = this.rear = node;
            }
            else
            {
                this.rear!.Next = node;
                node.Prev = this.rear;
                this.rear = node;
            }
        }

        public void InsertFront(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.IsEmpty())
            {
                this.front = this.rear = node;
            }
            else
            {
                node.Next = this.front;
                this.front!.Prev = node;
                this.front = node;
            }
        }

        public T DeleteRear()
        {
            if (this.IsEmpty()) throw new InvalidOperationException("Deque Vacía");

            T value = this.rear!.Value;
            this.rear = this.rear.Prev;

            if (this.rear == null)
            {
                this.front = null;
            }
            else
            {
                this.rear.Next = null;
            }

            return value;
        }

        public T DeleteFront()
        {
            if (this.IsEmpty()) throw new InvalidOperationException("Deque Vacía");
            T value = this.front!.Value;
            this.front = this.front!.Next;

            if (this.front == null)
            {
                this.rear = null;
            }
            else
            {
                this.front.Prev = null;
            }

            return value;
        }

        public T PeakRear()
        {
            if (this.IsEmpty()) throw new InvalidOperationException("Deque Vacía");
            return this.rear!.Value;
        }
    }
}
