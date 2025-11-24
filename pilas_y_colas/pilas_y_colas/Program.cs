using Ej01_HistorialVentanasActivas;
using Ej01_HistorialVentanasActivas.Stack;

//importaciones ejercicio 002
using Ej02_ControlStatesInaGame; 

Console.WriteLine("=== Menú de Ejercicios - Pilas y Colas ===\n");

Console.WriteLine("1. Ej01 - Historial de Ventanas Activas");
Console.WriteLine("2. Ej02 - Control de Estados en un Juego");
Console.WriteLine("\nSeleccione el ejercicio a ejecutar (1): ");

string? opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        Console.WriteLine("\n--- Ejecutando Ej01: Historial de Ventanas Activas ---\n");
        EjecutarEj01();
        break;
    case "2":
        Console.WriteLine("\n--- Ejecutando Ej02: Control de Estados en un Juego (Undo Moves) ---\n");
        EjecutarEj02();
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

static void EjecutarEj02()
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
