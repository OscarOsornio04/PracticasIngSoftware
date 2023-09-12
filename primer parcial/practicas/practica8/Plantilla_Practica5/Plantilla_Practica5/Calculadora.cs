using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla_Practica5
{
    internal class Calculadora
    {
        public double x, y, r;
        
        public Calculadora() { }

        public double calcularExponencial(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Exp(x);
        }

        public double calcularSeno(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Sin(x);
        }

        public double calcularCoseno(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Cos(x);
        }

        public double calcularTangente(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Tan(x);
        }

        public double calcularASeno(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Pow(Math.Sin(x), -1);
        }

        public double calcularACoseno(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Pow(Math.Cos(x), -1);
        }

        public double calcularATangente(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Pow(Math.Tan(x), -1);
        }

        public double calcularSenoH(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Sinh(x);
        }

        public double calcularCosenoH(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Cosh(x);
        }

        public double calcularTangenteH(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Tanh(x);
        }

        public double calcularLogaritmoDiez(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Log10(x);
        }

        public double calcularLogaritmoN(String texto)
        {
            x = double.Parse(texto);
            return r = Math.Log(x);
        }

        public double calcularPotencia(String texto1, String texto2)
        {
            x = double.Parse(texto1);
            y = double.Parse(texto2);
            return r = Math.Pow(x, y);
        }

        public double calcularSuma(String texto1, String texto2)
        {
            x = double.Parse(texto1);
            y = double.Parse(texto2);
            return r = x + y;
        }

        public double calcularResta(String texto1, String texto2)
        {
            x = double.Parse(texto1);
            y = double.Parse(texto2);
            return r = x - y;
        }

        public double calcularMulti(String texto1, String texto2)
        {
            x = double.Parse(texto1);
            y = double.Parse(texto2);
            return r = x * y;
        }

        public double calcularDivision(String texto1, String texto2)
        {
            x = double.Parse(texto1);
            y = double.Parse(texto2);
            return r = x / y;
        }

        public double calcularMod(String texto1, String texto2)
        {
            x = double.Parse(texto1);
            y = double.Parse(texto2);
            return r = x % y;
        }
    }
}
