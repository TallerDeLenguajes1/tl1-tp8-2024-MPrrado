
﻿
using System.Collections.Concurrent;
using EspacioCalculadora; //necesitamos esto para traer el espacio de nombres (el entorno) de nuestra clase para poder acceder
Calculadora instanciaCalculadora = new Calculadora();

// static bool 

bool salir = true;
while(salir)
{
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
        if (opcion > 5 || opcion < 0)
        {
            Console.WriteLine("ERROR LA OPCION INGRESADA NO ES VALIDA");
        }
        else
        {
            salir = operacionCalculadora(instanciaCalculadora,salir, opcion);
        }
    }
}
