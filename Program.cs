using System;

namespace aulaswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch; comando de decição múltipla
            // case: um teste de igualdade 
            //break: indica que não deve mais executar comandos do bloco switch
            // default (opcional): caso padrão, se nenhum dos casos anteriores for verdadeiro
            string opcao="";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Menu de opções");
            Console.WriteLine("--------------");
            Console.WriteLine("N. Novo arquivo");
            Console.WriteLine("A. Abrir arquivo");
            Console.WriteLine("H. Ajuda");
            Console.WriteLine("X. Sair");

            Console.Write("Digite sua opção: ");
            opcao=Console.ReadLine();
            Console.ResetColor();

            switch (opcao.ToUpper()){
                case "N":
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Um arquivo novo será criado.");
                Console.ResetColor();
                break;
                case "A":
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Um arquivo existente poderá ser aberto.");
                Console.ResetColor();
                break;
                case "H":
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Uma tela de ajuda será exibida.");
                Console.ResetColor();
                break;
                case "X":
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Obrigada por utilizar nosso software!");
                Console.ResetColor();
                break;
                default:
                Console.WriteLine("Opção inválida!");
                Environment.Exit(1); // código de erro
                break;
            }        
            Environment.Exit(0); // código de sucesso
        }
    }
}
