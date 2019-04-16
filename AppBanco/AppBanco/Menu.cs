using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    public class Menu
    {
        public void menuOpcoes()
        {
            int Opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("***************| MENU DE OPÇÕES (BANCO) |********************");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("[1] Menu Gerente:");
                Console.WriteLine("[2] Menu Funcionario:");               
                Console.WriteLine("[0] Sair do Sistema:");
                Console.WriteLine("----------------------------------------------------------------");
                Console.Write("Escolha uma das opções acima: ");

                try
                {
                    Opcao = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opção Inválida, pressione uma tecla para tentar novamente...");
                    Console.ReadKey();
                    menuOpcoes();
                }  
                
                if(Opcao == 1)
                {
                    menuGerente();
                }
                
            } while (Opcao != 0);
        }

        public void menuGerente()
        {
            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("***************| MENU GERENTE |********************");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("[1] Cadastrar conta:");
                Console.WriteLine("[2] :");
                Console.WriteLine("[0] Voltar ao menu principal:");
                Console.WriteLine("----------------------------------------------------------------");
                Console.Write("Escolha uma das opções acima: ");

                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opção Inválida, pressione uma tecla para tentar novamente...");
                    Console.ReadKey();
                    menuOpcoes();
                }

                if(op == 1)
                {
                    Banco banco = new Banco();
                    banco.criarConta();
                }
            } while (op != 0);
        }


    }
}
