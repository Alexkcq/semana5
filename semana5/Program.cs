﻿using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, Word");
string re = "s";
double suma = 0;    
double cant = 0;
while (re == "s")
{
    Console.WriteLine("Desea participar (s/n)?");
    re = Console.ReadLine();
    Console.WriteLine("Ingrese edad");
    int edad = Convert.ToInt32(Console.ReadLine());
    suma = suma + edad;
    cant = cant + 1;
}
double prom = suma / cant;
Console.WriteLine($"EL promedio de {cant} edades es {prom}");
Console.ReadKey();