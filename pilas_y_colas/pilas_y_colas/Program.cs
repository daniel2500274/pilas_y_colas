using Ej01_HistorialVentanasActivas;
using Ej01_HistorialVentanasActivas.Stack;


Console.WriteLine("=== Menú de Ejercicios - Pilas y Colas ===\n");

Console.WriteLine("1. Ej01 - Historial de Ventanas Activas");
Console.WriteLine("\nSeleccione el ejercicio a ejecutar (1): ");

string? opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        Console.WriteLine("\n--- Ejecutando Ej01: Historial de Ventanas Activas ---\n");
        EjecutarEj01();
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}

static void EjecutarEj01()
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
