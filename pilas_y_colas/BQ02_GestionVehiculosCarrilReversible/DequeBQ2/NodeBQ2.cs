using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQ02_GestionVehiculosCarrilReversible.DequeBQ2
{
    public class NodeBQ2<T>
    {
        public T Value { get; set; }
        public NodeBQ2<T>? Next { get; set; }

        public NodeBQ2<T>? Prev { get; set; }

        public NodeBQ2(T value)
        {
            this.Value = value;
        }
    }
}
