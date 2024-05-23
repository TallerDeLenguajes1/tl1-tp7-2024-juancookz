using EspacioCalculadora;
using System;
Calculadora calc = new Calculadora();
float num;
float.TryParse(Console.ReadLine(), out num);
calc.Sumar(num);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("El resultado es: " + calc.Resultado);
Console.ResetColor();