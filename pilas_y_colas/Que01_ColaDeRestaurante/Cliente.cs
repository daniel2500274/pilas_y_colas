using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que01_ColaDeRestaurante
{
    public class Cliente
    {
        public int NumeroOrden { get; set; }
        public string? NombreCliente { get; set; }
        public string? TipoPedido { get; set; }
        public override string ToString()
        {
            return $"No. Orden: {NumeroOrden} - Cliente: {NombreCliente} -Pedido: {TipoPedido}";
        }
    }
}
