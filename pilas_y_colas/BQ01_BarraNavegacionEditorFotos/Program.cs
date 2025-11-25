using BQ01_BarraNavegacionEditorFotos;
using BQ01_BarraNavegacionEditorFotos.DQ01;
internal class Program
{
    private static void Main(string[] args)
    {
        LinkedStackBQ01<Imagen> deque = new LinkedStackBQ01<Imagen>();
        deque.InsertRear(new Imagen { Nombre = "Imagen6", Resolucion = "3840x2160" });
        deque.InsertRear(new Imagen { Nombre = "Imagen7", Resolucion = "1280x720" });
        deque.InsertRear(new Imagen { Nombre = "Imagen8", Resolucion = "2560x1440" });
        deque.InsertRear(new Imagen { Nombre = "Imagen9", Resolucion = "1920x1080" });
        deque.InsertRear(new Imagen { Nombre = "Imagen10", Resolucion = "3840x2160" });
        deque.InsertRear(new Imagen { Nombre = "Imagen11", Resolucion = "1366x768" });
        deque.InsertRear(new Imagen { Nombre = "Imagen12", Resolucion = "2560x1440" });
        deque.InsertRear(new Imagen { Nombre = "Imagen13", Resolucion = "1920x1080" });
        deque.InsertRear(new Imagen { Nombre = "Imagen14", Resolucion = "4096x2160" });
        deque.InsertRear(new Imagen { Nombre = "Imagen15", Resolucion = "1280x720" });
        deque.InsertRear(new Imagen { Nombre = "Imagen16", Resolucion = "3840x2160" });
        deque.InsertRear(new Imagen { Nombre = "Imagen17", Resolucion = "1920x1200" });
        deque.InsertRear(new Imagen { Nombre = "Imagen18", Resolucion = "2560x1440" });
        deque.InsertRear(new Imagen { Nombre = "Imagen19", Resolucion = "1600x900" });
        deque.InsertRear(new Imagen { Nombre = "Imagen20", Resolucion = "1920x1080" });


        for (int i = 1; i <= 2; i++)
        {
            //Console.WriteLine($"Imagenn Eliminada: {deque.DeleteRear()}");
            Console.WriteLine($"Imagenn Eliminada: {deque.DeleteFront()}");
        }
        deque.InsertFront(new Imagen { Nombre = "ImagenAgregada", Resolucion = "1920x1080" });

        Console.WriteLine($"Imagen despues de los movimientos: {deque.PeakRear()}");
    }
}