using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tipo int Tamaño: {0} Rango [{1},{2}]", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("tipo float Tamaño: {0} Rango [{1},{2}]", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("tipo double Tamaño: {0} Rango [{1},{2}]", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("tipo Int16 Tamaño: {0} Rango [{1},{2}]", sizeof(Int16), Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("tipo Int32 Tamaño: {0} Rango [{1},{2}]", sizeof(Int32), Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("tipo Double Tamaño: {0} Rango [{1},{2}]", sizeof(Double), Double.MinValue, Double.MaxValue);
            Console.WriteLine("tipo Boolean Tamaño: {0}", sizeof(Boolean));
            Console.WriteLine("tipo bool Tamaño: {0}", sizeof(bool));
            Console.WriteLine("tipo char Tamaño: {0} Rango [{1},{2}]", sizeof(char), char.MinValue, char.MaxValue);
        }
    }
}
