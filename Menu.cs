using System;
namespace Banco
{
    public class Menu
    {
        public int Opcao { get; set; }
        Gerente gerente;
        public Menu()
        {

        }

        public void MostraMenu()
        {
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
                    MostraMenu();
                }  
                
                if(Opcao == 1)
                {
                    gerente = new Gerente();
                    gerente.MenuGerente();
                    
                }
                
            } while (Opcao != 0);
            Console.Clear();
        }
        
    }
}