using EspacioCalculadora;
using System;
Calculadora calc = new Calculadora();
float num;
string choice = "";
do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine("Resultado: " + calc.Resultado);
    Console.ResetColor();

    System.Console.WriteLine("Ingrese operacion:");
    System.Console.WriteLine("Sumar: (+)");
    System.Console.WriteLine("Restar: (-)");
    System.Console.WriteLine("Multiplicar: (*)");
    System.Console.WriteLine("Dividir: (/)");
    System.Console.WriteLine("Limpiar resultado: (0)");
    System.Console.WriteLine("SALIR: (x)");
    choice = Console.ReadLine();
    switch (choice)
    {
        case "+":
            Console.Write(calc.Resultado + " + ");
            float.TryParse(Console.ReadLine(), out num);
            calc.Sumar(num);
            break;
        case "-":
            Console.Write(calc.Resultado + " - ");
            float.TryParse(Console.ReadLine(), out num);
            calc.Restar(num);
            break;
        case "*":
            Console.Write(calc.Resultado + " * ");
            float.TryParse(Console.ReadLine(), out num);
            calc.Multiplicar(num);
            break;
        case "/":
            while (true)
            {
                Console.Write(calc.Resultado + " / ");
                float.TryParse(Console.ReadLine(), out num);
                if (num != 0)
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE PUEDE DIVIDIR EN 0");
                Console.ResetColor();
            }
            calc.Dividir(num);
            break;
        case "0":
            calc.Limpiar();
            break;
        case "x":
            choice = "x";
            break;
        default:
            Console.WriteLine("Operación inválida");
            break;
    }
} while (choice != "x");