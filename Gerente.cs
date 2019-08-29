using System;
namespace Banco
{
    public class Gerente
    {

        Menu menu;
        public static BancoAdm Itau = new BancoAdm();

        public Gerente()
        {

        }

        public void MenuGerente()
        {
            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("***************| MENU GERENTE |********************");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("[1] Adicionar conta:");
                Console.WriteLine("[2] Deletar conta:");
                Console.WriteLine("[3] Listar clientes:");
                Console.WriteLine("[4] Entrar na conta do cliente");
                Console.WriteLine("[0] Voltar ao menu principal:");
                Console.WriteLine("----------------------------------------------------------------");
                Console.Write("Escolha uma das opções acima: ");                
                op = int.Parse(Console.ReadLine());

                

                if(op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("ADICIONAR CONTA");
                    
                    string Nome, Cpf;
                    
                    Console.WriteLine("Digite o nome do cliente:");
                    Nome = Console.ReadLine();
                    Console.WriteLine("Digite o cpf do cliente: ");
                    Cpf = Console.ReadLine();

                    Itau.ListaConta.Add(new Conta (Nome, Cpf));

                    Console.WriteLine("Conta Adicionada com Sucesso");
                    Console.ReadLine();                  
            
                }

                if (op == 3)
                {
                    Console.Clear();
                    Itau.ListarConta();
                    Console.ReadLine();
                }

                if (op == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o numero da conta");
                    op = int.Parse(Console.ReadLine());                    

                    Console.ReadLine();
                }

                

                
            } while (op != 0);
            
        }
        
        
    }
}