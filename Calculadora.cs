
using System.Collections.ObjectModel;
using System.Globalization;
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

        public void Multiplicar(float num)
        {
            resultado = resultado * num;
        }

        public void Dividir(float num)
        {
            resultado = resultado / num;
        }
        public void Limpiar()
        {
            resultado = 0;
        }
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