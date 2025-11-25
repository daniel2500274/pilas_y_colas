using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQ02_GestionVehiculosCarrilReversible
{
    public class Vehiculo
    {
        public string Placa { get; set; } = "";
        public string tipo { get; set; } = "";
        public string HoraIngreso { get; set; } = DateTime.Now.ToString("HH:mm:ss");

        public override string ToString()
        {
            return $"Placa: {Placa}, Tipo: {tipo}, Hora de Ingreso: {HoraIngreso}";
        }

    }
}
