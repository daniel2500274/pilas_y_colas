using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que02_ControlDePaquetesRecibidosEnBodega
{
    public class Paquete
    {
        public int CodigoPaquete { get; set; }
        public string? Proveedor { get; set; }

        public double Peso { get; set; }
        public override string ToString()
        {
            return $"Código Paquete: {CodigoPaquete} - Proveedor: {Proveedor} - Peso: {Peso} Kg";
        }
    }
}
