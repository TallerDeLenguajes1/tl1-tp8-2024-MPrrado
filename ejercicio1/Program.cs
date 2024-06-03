using System.Runtime.InteropServices;
using espacioTareas;
Listas listas = new Listas //instanciamos la clase listas que contiene las listas de pendientes y realizadas
{
    //incializamos las listas
    TareasPendientes = new List<Tarea>(),
    TareasRealizadas = new List<Tarea>()
}; 
OperacionesTareas operarLista = new OperacionesTareas(); //instanciamos las operaciones para operar con las listas
listas.TareasPendientes = operarLista.GenerarListaTareasPendientes(listas.TareasPendientes); //generamos listaPendientes aleatoriamente

int option=1;
while(option != 0)
{
    Console.ForegroundColor=ConsoleColor.Yellow;
    System.Console.WriteLine("----------SISTEMA TO-DO----------");
    System.Console.WriteLine("1- MOSTRAR LISTAS");
    System.Console.WriteLine("2- MOVER A REALIZADAS");
    System.Console.WriteLine("3- BUSCAR SEGUN DESCRIPCION");
    System.Console.WriteLine("0- SALIR");
    System.Console.WriteLine("elegir opcion: ");
    int.TryParse(Console.ReadLine(), out option);

    switch(option)
    {
        case 1:
            Console.ForegroundColor=ConsoleColor.White;
            System.Console.WriteLine("------Pendientes------");
            operarLista.MostrarListaTareas(listas.TareasPendientes); //mostramos la lista de pendientes
            System.Console.WriteLine("------Realizadas------");
            operarLista.MostrarListaTareas(listas.TareasRealizadas); //mostramos la lista de realizadas
            break;
        case 2:
            Console.ForegroundColor=ConsoleColor.White; 
            operarLista.MoverTareasTerminadas(listas.TareasPendientes, listas.TareasRealizadas);
            break;
        case 3:
            // operarLista.BuscarTarea(listas.TareasPendientes);
            break;
        case 0:
            Console.ForegroundColor=ConsoleColor.DarkMagenta;  
            System.Console.WriteLine("SALIENDO...");
            break;
        default:
            Console.ForegroundColor=ConsoleColor.Red;
            System.Console.WriteLine("OPCION INCORRECTA");
            break;
    }

    Console.ForegroundColor=ConsoleColor.White;
}

// operarLista.MostrarListaTareas(listas.TareasPendientes); //mostramos la lista de pendientes

// operarLista.MoverTareasTerminadas(listas.TareasPendientes, listas.TareasRealizadas);

// operarLista.MostrarListaTareas(listas.TareasRealizadas); //mostramos la lista de realizadas

