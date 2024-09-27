using estudo.Models;

bool menu = true;

string opcao;

while(menu)
{
  Console.Clear();
  Console.WriteLine($"Bem-vindo, o que deseja fazer?");
  Console.WriteLine("1 - Entrar");
  Console.WriteLine("2 - Abrir conta");
  Console.WriteLine("3 - Encerrar conta");
  Console.WriteLine("4 - Sair");

  opcao = Console.ReadLine();

  switch(opcao)
  {
    case "1":
    break;
    case "2":
    break;
    case "3":
    break;
    case "4":
      menu = false;
    break;
    default:
    Console.WriteLine("Opção inválida, aperte qualquer tecla para continuar");
    string opcaoErro = Console.ReadLine();
    Console.Clear();
    break;
  }
}