using Ej02_ControlStatesInaGame.Stack;
using Ej02_ControlStatesInaGame;
internal class Program
{
    private static void Main(string[] args)
    {
        LinkedStack<Movimientos> movimiento = new LinkedStack<Movimientos>();

        movimiento.Push(new Movimientos { Accion = "saltar", Cordenada = "1", tiempo = "80" });
        movimiento.Push(new Movimientos { Accion = "Atacar", Cordenada = "2", tiempo = "70" });
        movimiento.Push(new Movimientos { Accion = "Mover", Cordenada = "3", tiempo = "60" });
        movimiento.Push(new Movimientos { Accion = "saltar", Cordenada = "4", tiempo = "50" });
        movimiento.Push(new Movimientos { Accion = "Atacar", Cordenada = "5", tiempo = "40" });
        movimiento.Push(new Movimientos { Accion = "Mover", Cordenada = "6", tiempo = "30" });
        movimiento.Push(new Movimientos { Accion = "saltar", Cordenada = "7", tiempo = "20" });
        movimiento.Push(new Movimientos { Accion = "Atacar", Cordenada = "8", tiempo = "10" });

        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"=== Deshacer #{i} ===");

            var undone = movimiento.Pop();

            Console.WriteLine($"Movimiento deshecho: {undone}");

            if (!movimiento.IsEmpty())
                Console.WriteLine($"Movimiento actual: {movimiento.Peek()}");
            else
                Console.WriteLine("No quedan movimientos.");

            Console.WriteLine($"\nMovimientos restantes: {movimiento.Count()}\n");
        }

    }
}