using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo.Models
{
    public class Cofre
    {
        public double Conta { get; set; }

        public Cofre(double conta)
        {
            Conta = conta;
        }

        public void Depositar()
        {
            Console.WriteLine("Qual moeda deseja depositar?");
            string tipoMoeda = Console.ReadLine();

            Console.WriteLine("Quanto deseja depositar?");
            double valor += Convert.ToDouble(Console.ReadLine());
        }
        public void Sacar()
        {
            Console.WriteLine("Em qual moeda deseja sacar?");
            string tipoMoeda = Console.ReadLine();

            Console.WriteLine("Quanto deseja sacar?");
            double valor -= Convert.ToDouble(Console.ReadLine());

        }
    }
}