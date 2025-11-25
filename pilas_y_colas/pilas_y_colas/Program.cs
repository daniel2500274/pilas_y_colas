using BQ01_BarraNavegacionEditorFotos;
using BQ01_BarraNavegacionEditorFotos.DQ01;
using BQ02_GestionVehiculosCarrilReversible;
using BQ02_GestionVehiculosCarrilReversible.DequeBQ2;
using Ej01_HistorialVentanasActivas;
using Ej01_HistorialVentanasActivas.Stack;
using Ej02_ControlStatesInaGame;
using Que01_ColaDeRestaurante;
using Que01_ColaDeRestaurante.Queues;
using Que02_ControlDePaquetesRecibidosEnBodega;
using Que02_ControlDePaquetesRecibidosEnBodega.Queues_02;

Console.WriteLine("=== Menú de Ejercicios - Pilas y Colas ===\n");
Console.WriteLine("        === PILAS / STACKS ===\n");
Console.WriteLine("1. Ej01 - Historial de Ventanas Activas");
Console.WriteLine("2. Ej02 - Control de Estados en un Juego");
Console.WriteLine("3. Qu01 - Simulacion de Cola en un Restaurante");
Console.WriteLine("4. Qu02 - Control de paquetes recibidos en bodega");
Console.WriteLine("5. BQ01 - Barra de Navegación de Editor de Fotos");
Console.WriteLine("6. BQ02 - Gestión de Vehiculos en un carril reversible");
Console.WriteLine("0. Salir");
Console.WriteLine("\nSeleccione el ejercicio a ejecutar: ");

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
    case "3":
        Console.WriteLine("\n--- Ejecutando Qu01: Simulacion de Cola en un Restaurante ---\n");
        EjecutarQ01();
        break;
    case "4":
        Console.WriteLine("\n--- Ejecutando Qu02: Control de paquetes recibidos en bodega ---\n");
        EjecutarQ02();
        break;
    case "5":
        Console.WriteLine("\n--- Ejecutando BQ01: Barra de Navegación de Editor de Fotos ---\n");
        EjecutarBQ01();
        break;
    case "6":
        Console.WriteLine("\n--- Ejecutando BQ01: Barra de Navegación de Editor de Fotos ---\n");
        EjecutarBQ02();
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


static void EjecutarQ01()
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

static void EjecutarQ02()
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


static void EjecutarBQ01()
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



static void EjecutarBQ02()
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