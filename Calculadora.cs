
using System.Collections.ObjectModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace EspacioCalculadora
{
    public class Calculadora
    {
        private float resultado;
        public float Resultado
        {
            get
            {
                return resultado;
            }
        }
        public void Sumar(float num)
        {
            resultado += num;
        }
        
        public void Restar(float num)
        {
            resultado -= num;
        }
        /*
        public void Multiplicar()
        {
            System.Console.WriteLine("MULTIPLICAR");
            Console.WriteLine("Ingrese el primer número:");
            num1 = verifNum();
            Console.WriteLine("Ingrese el segundo número:");
            num2 = verifNum();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("El resultado es: " + (num1 * num2));
            Console.ResetColor();
        }
        public void Dividir()
        {
            System.Console.WriteLine("DIVIDIR");
            Console.WriteLine("Ingrese el primer número:");
            num1 = verifNum();
            while (true)
            {
                Console.WriteLine("Ingrese el segundo número:");
                num2 = verifNum();
                if (num2 != 0)
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE PUEDE DIVIDIR EN 0");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("El resultado es: " + (num1 / num2));
            Console.ResetColor();
        }*/
        private float verifNum()
        {
            float num;
            while (true)
            {
                if (!float.TryParse(Console.ReadLine(), out num))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ingrese un numero valido:");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }
            return num;
        }
    }
}