using System;

namespace DIO.Projeto
{
    class Program
    {
        static GameRepositorio repositorio = new GameRepositorio();
        static void Main(string[] args)
        {
          
            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarGame();
                        break;
                    case "2":
                        InserirGame();
                        break;
                    case "3":
                        AtualizarGame();
                        break;
                    case "4":
                        ExcluirGame();
                        break;
                    case "5":
                        VisualizarGame();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = obterOpcaoUsuario();              
            }
        }

        private static void VisualizarGame()
        {
            Console.Write("Digite o id do Game: ");
            int indiceGame = int.Parse(Console.ReadLine());

            var Game = repositorio.RetornaPorId(indiceGame);

            Console.WriteLine(Game);
        }

        private static void ExcluirGame()
        {
            Console.Write("Digite o id do Game: ");
            int indiceGame = int.Parse(Console.ReadLine());

            repositorio.Exlui(indiceGame);
        }

        private static void AtualizarGame()
        {
            Console.WriteLine("Digite o Id do Game: ");
            int indiceGame = int.Parse(Console.ReadLine());            
            
            var atualizaGame = preencherFormulario(indiceGame);

            repositorio.Atualiza(indiceGame, atualizaGame);
        }

        private static Game preencherFormulario(int idGame) 
        {
            foreach (int item in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{item} - {Enum.GetName(typeof(Genero),item)}");                
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            foreach (int item in Enum.GetValues(typeof(Consoles)))
            {
                Console.WriteLine($"{item} - {Enum.GetName(typeof(Consoles),item)}");                
            }
            Console.Write("Digite o console deste games entre as opções acima:");
            int entradaConsole = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Game: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descrição do Game: ");
            string entradaDescricao = Console.ReadLine();

            Game retornoGame = new Game(
                idGame,
                (Genero)entradaGenero,
                entradaTitulo,
                entradaDescricao,
                (Consoles)entradaConsole
            );

            return retornoGame;
        }

        private static void InserirGame()
        {
            Console.WriteLine("Inserir um novo Game");          
            
            var novoGame = preencherFormulario(repositorio.ProximoId());

            repositorio.Insere(novoGame);
        }

        private static void ListarGame()
        {
            Console.WriteLine("Listar meus Games");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum game cadastrado :-( ");
                return;
            }

            foreach (var item in lista)
            {
                Console.WriteLine($"ID {item.retornaID()}: {item.retornaTitulo()}");
            }
            
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine(" --- Controle do meus Jogos de Video Games --- ");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Lista games");
            Console.WriteLine("2- Inserir novo game");
            Console.WriteLine("3- Atualizar game");
            Console.WriteLine("4- Excluir game");
            Console.WriteLine("5- Visualizar game");
            Console.WriteLine("C- Limpar Tela");            
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
