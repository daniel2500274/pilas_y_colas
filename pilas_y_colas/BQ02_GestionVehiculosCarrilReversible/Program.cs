using BQ02_GestionVehiculosCarrilReversible;
using BQ02_GestionVehiculosCarrilReversible.DequeBQ2;

internal class Program
{
    private static void Main(string[] args)
    {
        LinkedDequeBQ2<Vehiculo> vehiculos = new LinkedDequeBQ2<Vehiculo>();

        vehiculos.InsertRear(new Vehiculo { Placa = "ABC123", tipo = "Carro" });
        vehiculos.InsertFront(new Vehiculo { Placa = "XYZ789", tipo = "Moto" });
        vehiculos.InsertFront(new Vehiculo { Placa = "LMN456", tipo = "Camión" });
        vehiculos.InsertRear(new Vehiculo { Placa = "DEF321", tipo = "Bus" });
        vehiculos.InsertFront(new Vehiculo { Placa = "GHI654", tipo = "Bicicleta" });

        for (int i = 1; i <= 3; i++)
        {
            var salida = vehiculos.DeleteFront();
            Console.WriteLine($"\nVehículo salido #{i}: {salida}");
        }

        vehiculos.InsertRear(new Vehiculo { Placa = "JKL987", tipo = "Tren" });
        vehiculos.InsertRear(new Vehiculo { Placa = "MNO654", tipo = "Camioneta" });

        Console.WriteLine("\nEstado final de los vehiculos:");
        MostrarEstado(vehiculos);

        static void MostrarEstado(LinkedDequeBQ2<Vehiculo> deque)
        {
            int i = 1;
            foreach (var v in deque.AsEnumerable())
            {
                Console.WriteLine($"{i++}. {v}");
            }
        }
    }
}