using System;
using System.Collections.Generic;
using System.Text;

namespace basicosCSharp
{
    class CalculadoraBasica
    {
        private double ultimoResultado;
        public double Sumar(double primerValor, double segundoValor) {
            ultimoResultado = primerValor + segundoValor;
            return ultimoResultado;
        }
        public double Dividir(double primerValor, double segundoValor) {
            ultimoResultado = primerValor / segundoValor;
            return ultimoResultado;
        }
    }
}
