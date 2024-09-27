using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo.Models
{
    public class Conta
    {
        public string Nome { get; set; }
        public int Senha { get; set; }
        public string Account { get; set; }

        public Conta(int senha, string nome, string account)
        {
            Nome = nome;
            Senha = senha;
            Account = account;
        }
        public Conta(){}

        public void CriarConta()
        {
            List<string> conta = new List<string>();

            Console.WriteLine("Digite seu nome");
            Nome = Console.ReadLine();

            conta.Add(Nome);

            Console.WriteLine("Digite sua senha");
            Senha = Convert.ToInt32(Console.ReadLine());

            conta.Add(Convert.ToString(Senha));
        }
        public void DeletarConta()
        {
            
        }
    }
}