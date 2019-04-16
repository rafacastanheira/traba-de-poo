using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    public class Banco
    {
        public float Armazenar { get; set; }
        public float Emprestar { get; set; }
        public float Receber { get; set; }
        public List<Conta> Conta { get; set; }

        //int contaC = 0;

        public void adicionarConta()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Informe o nome do titular:");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Informe o endereço do titular:");
            cliente.Endereco = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento do titular:");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe o CPF do titular:");
            cliente.Cpf = Console.ReadLine();
            Console.WriteLine("Informe o e-mail do titular:");
            cliente.Email = Console.ReadLine();

            Conta conta = new Conta()
            {
                Titular = cliente
            };

            Console.WriteLine("Conta cadastrada com sucesso!");

        }
    }
}
