using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQ01_BarraNavegacionEditorFotos
{
    public class Imagen
    {
        public string? Nombre { get; set; }
        public string? Resolucion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Resolución: {Resolucion}, Fecha de Creación: {FechaCreacion}";
        }
    }
}
