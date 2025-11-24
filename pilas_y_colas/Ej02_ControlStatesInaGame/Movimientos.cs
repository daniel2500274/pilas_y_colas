using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02_ControlStatesInaGame
{
    public class Movimientos
    {
        public string Accion { get; set; } = "";
        public string Cordenada { get; set; } = "";
        public string tiempo { get; set; } = "";

        public override string ToString() => $"{Accion}: {Cordenada} ({tiempo})";
    }
}
