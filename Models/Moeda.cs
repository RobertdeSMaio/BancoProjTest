using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo.Models
{
    public class Moeda
    {
        public double Real { get; set; }
        public double Dolar { get; set; }
        public double Euro { get; set; }

        public Moeda(double real, double dolar, double euro)
        {
            Euro = euro;
            Real = real;
            Dolar = dolar;
        }

        public Moeda(){}

        protected void Valor()
        {
            Real = 1;
            Dolar = 1;
            Euro = 1;
        }
        public void ConverterDolar()
        {
            double dolarParaEuro = Dolar * 0.89;
            double dolarParaReal = Dolar * 5.44;
        }
        public void ConverterEuro()
        {
            double euroParaDolar = Euro * 1.12;
            double euroParaReal = Euro * 6.08;
        }
        public void ConverterReal()
        {
            double realParaDolar = Real * 0.18;
            double realParaEuro = Real * 0.16;
        }
    }
}