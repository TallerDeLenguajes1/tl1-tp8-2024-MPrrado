using System.Collections.Concurrent;
using EspacioCalculadora; //necesitamos esto para traer el espacio de nombres (el entorno) de nuestra clase para poder acceder
Calculadora instanciaCalculadora = new Calculadora();
EjecutarOperacionCalculadora operar = new EjecutarOperacionCalculadora();
List<Operacion> historial = new List<Operacion>();

// static bool 

bool salir = true;
while(salir)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("--------MENU CALCUADORA V2.0.0-------");
    Console.WriteLine("1- SUMAR");
    Console.WriteLine("2- RESTAR");
    Console.WriteLine("3- MULTIPLICAR");
    Console.WriteLine("4- DIVIDIR");
    Console.WriteLine("5- MOSTRAR RESULTADO");
    Console.WriteLine("6- LIMPIAR");
    Console.WriteLine("0- SALIR");
    Console.WriteLine("Ingrese una opcion: ");
    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        if (opcion > 6 || opcion < 0)
        {
            Console.WriteLine("ERROR LA OPCION INGRESADA NO ES VALIDA");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            salir = operar.operacionCalculadora(instanciaCalculadora, salir, opcion, historial);
        }
    }
}
