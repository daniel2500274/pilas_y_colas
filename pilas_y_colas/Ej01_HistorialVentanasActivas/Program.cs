using Ej01_HistorialVentanasActivas;
using Ej01_HistorialVentanasActivas.Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        LinkedStack<Ventana> ventana = new LinkedStack<Ventana>();

        ventana.Push(new Ventana() { NombreVentana = "Ventana 1 roles", Usuario = "Usuario Oscar" });
        ventana.Push(new Ventana() { NombreVentana = "Ventana 2 usuarios", Usuario = "Usuario Erick" });
        ventana.Push(new Ventana() { NombreVentana = "Ventana 3 Perfil", Usuario = "Usuario Marielos" });
        ventana.Push(new Ventana() { NombreVentana = "Ventana 4 Ayuda", Usuario = "Usuario Steven" });
        ventana.Push(new Ventana() { NombreVentana = "Ventana 5 Reportes", Usuario = "Usuario Edwin" });
        ventana.Push(new Ventana() { NombreVentana = "Ventana 6 Configuracion ", Usuario = "Usuario Elsa" });


        Console.WriteLine($"Ventana Activa:-  {ventana.Peek()}");
        Console.WriteLine($"Cerrando:-  {ventana.Pop()}\n");
        Console.WriteLine($"Ventana Activa:-  {ventana.Peek()}");
        Console.WriteLine($"Cerrando:-  {ventana.Pop()}\n");
        Console.WriteLine($"Ventana Activa:-  {ventana.Peek()}");
        Console.WriteLine($"Cerrando:-  {ventana.Pop()}\n");
        Console.WriteLine($"Ventana Activa:-  {ventana.Peek()}");


        Console.WriteLine($"\nVentanas activas en el historial: {ventana.Count()}");



    }
}