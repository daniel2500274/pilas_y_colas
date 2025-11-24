using Que01_ColaDeRestaurante;
using Que01_ColaDeRestaurante.Queues;
internal class Program
{
    private static void Main(string[] args)
    {
        LinkedQueue<Cliente> cola = new LinkedQueue<Cliente>();


        Console.WriteLine("*******Atencion de clientes*******\n");


        cola.Enqueue(new Cliente { NumeroOrden = 1087, NombreCliente = "Roberto Vega", TipoPedido = "Desayuno" });
        cola.Enqueue(new Cliente { NumeroOrden = 2319, NombreCliente = "Isabel Morales", TipoPedido = "Bebida" });
        cola.Enqueue(new Cliente { NumeroOrden = 3642, NombreCliente = "Fernando Castro", TipoPedido = "Almuerzo" });
        cola.Enqueue(new Cliente { NumeroOrden = 4891, NombreCliente = "Patricia Ramos", TipoPedido = "Cena" });
        cola.Enqueue(new Cliente { NumeroOrden = 5273, NombreCliente = "Andrés Ortiz", TipoPedido = "Desayuno" });
        cola.Enqueue(new Cliente { NumeroOrden = 6558, NombreCliente = "Carmen Herrera", TipoPedido = "Postre" });
        cola.Enqueue(new Cliente { NumeroOrden = 7124, NombreCliente = "Miguel Vargas", TipoPedido = "Bebida" });
        cola.Enqueue(new Cliente { NumeroOrden = 8936, NombreCliente = "Elena Flores", TipoPedido = "Almuerzo" });
        cola.Enqueue(new Cliente { NumeroOrden = 9407, NombreCliente = "Jorge Sánchez", TipoPedido = "Cena" });
        cola.Enqueue(new Cliente { NumeroOrden = 1565, NombreCliente = "Raquel Domínguez", TipoPedido = "Desayuno" });
        cola.Enqueue(new Cliente { NumeroOrden = 2798, NombreCliente = "Alberto Navarro", TipoPedido = "Postre" });
        cola.Enqueue(new Cliente { NumeroOrden = 3481, NombreCliente = "Teresa Gil", TipoPedido = "Bebida" });
        cola.Enqueue(new Cliente { NumeroOrden = 4652, NombreCliente = "Ricardo Campos", TipoPedido = "Almuerzo" });
        cola.Enqueue(new Cliente { NumeroOrden = 5923, NombreCliente = "Beatriz Romero", TipoPedido = "Cena" });
        cola.Enqueue(new Cliente { NumeroOrden = 6147, NombreCliente = "Javier Molina", TipoPedido = "Desayuno" });

        for (int i = 1; i <= 4; i++)
        {
            var atendido = cola.Dequeue();
            Console.WriteLine($"Cliente atendido #{i}: {atendido}");
        }

        Console.WriteLine($"\nSiguiente cliente en fila: {cola.Peek()}");
        Console.WriteLine($"\nClientes restantes en cola: {cola.Count()}");

    }
}