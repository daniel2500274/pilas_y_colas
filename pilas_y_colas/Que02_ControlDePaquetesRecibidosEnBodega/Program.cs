using Que02_ControlDePaquetesRecibidosEnBodega;
using Que02_ControlDePaquetesRecibidosEnBodega.Queues_02;
internal class Program
{
    private static void Main(string[] args)
    {
        LinkedQueue_02<Paquete> cola = new LinkedQueue_02<Paquete>();

        cola.Enqueue(new Paquete { CodigoPaquete = 834, Proveedor = "Cargo Express", Peso = 25 });
        cola.Enqueue(new Paquete { CodigoPaquete = 956, Proveedor = "TransRapid", Peso = 75 });
        cola.Enqueue(new Paquete { CodigoPaquete = 1047, Proveedor = "Guatex", Peso = 30 });
        cola.Enqueue(new Paquete { CodigoPaquete = 1182, Proveedor = "LogiPack", Peso = 100 });
        cola.Enqueue(new Paquete { CodigoPaquete = 1293, Proveedor = "Cargo Express", Peso = 45 });
        cola.Enqueue(new Paquete { CodigoPaquete = 1456, Proveedor = "Guatex", Peso = 60 });
        cola.Enqueue(new Paquete { CodigoPaquete = 1578, Proveedor = "TransRapid", Peso = 20 });
        cola.Enqueue(new Paquete { CodigoPaquete = 1689, Proveedor = "LogiPack", Peso = 85 });
        cola.Enqueue(new Paquete { CodigoPaquete = 1741, Proveedor = "Cargo Express", Peso = 55 });
        cola.Enqueue(new Paquete { CodigoPaquete = 1825, Proveedor = "Guatex", Peso = 40 });
        cola.Enqueue(new Paquete { CodigoPaquete = 1967, Proveedor = "TransRapid", Peso = 90 });
        cola.Enqueue(new Paquete { CodigoPaquete = 2031, Proveedor = "LogiPack", Peso = 35 });
        cola.Enqueue(new Paquete { CodigoPaquete = 2154, Proveedor = "Cargo Express", Peso = 70 });
        cola.Enqueue(new Paquete { CodigoPaquete = 2298, Proveedor = "Guatex", Peso = 50 });
        cola.Enqueue(new Paquete { CodigoPaquete = 2367, Proveedor = "TransRapid", Peso = 65 });

        for (int i = 1; i <= 3; i++)
        {
            var enviado = cola.Dequeue();
            Console.WriteLine($"Paquete Procesado #{i}: {enviado}");
        }
        Console.WriteLine($"\nSiguiente paquete en fila: {cola.Peek()}");

        double pesoPendiente = cola.AsEnumerable().Sum(p => p.Peso);

        Console.WriteLine($"Peso total pendiente: {pesoPendiente} kg");

    }
}