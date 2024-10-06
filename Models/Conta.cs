using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        protected bool VerificarLogin(string Nome, double Senha)//! erro ao encontrar a desgraca do DB
        {
            string stringDeConexao = "Data Source=MySQL;Initial Catalog=root;Integrated Security=True";//confere os dados do db

            using (SqlConnection connection = new SqlConnection(stringDeConexao))
            {
                string query = "SELECT COUNT(1) FROM Contas WHERE Nome = @Nome AND Senha = @Senha";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", Nome);
                    command.Parameters.AddWithValue("@Senha", Senha);

                    connection.Open();
                    int result = Convert.ToInt32(command.ExecuteScalar());

                    return result > 0;
                }
            }
        }

        public void Login()
        {
            Console.WriteLine("Digite seu login: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            double Senha = Convert.ToDouble(Console.ReadLine());

            if(VerificarLogin(Nome, Senha))
            {
                Console.WriteLine("Login Bem-sucedido");
            }else{
                Console.WriteLine("Login ou senha incorretos");
            }
        }

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
            List<string> conta = new List<string>();

            Console.WriteLine("Digite o nome da conta que deseja excluir: ");
            string Nome = Console.ReadLine();

            conta.Remove(Nome);
            Console.WriteLine("Sua conta foi excluida");
            
        }
    }
}