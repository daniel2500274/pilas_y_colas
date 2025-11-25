using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQ02_GestionVehiculosCarrilReversible.DequeBQ2
{
    public class LinkedDequeBQ2<T>
    {
        private NodeBQ2<T>? front;
        private NodeBQ2<T>? rear;

        public bool IsEmpty() => front == null;

        public void InsertRear(T value)
        {
            NodeBQ2<T> node = new NodeBQ2<T>(value);

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
            NodeBQ2<T> node = new NodeBQ2<T>(value);
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
