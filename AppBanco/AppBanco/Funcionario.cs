using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public Funcionario(int idFuncionario, string nome, string telefone, string endereco, string email)
        {
            this.IdFuncionario = idFuncionario;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Email = email;
        }
    }
}
