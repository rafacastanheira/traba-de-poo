using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public bool NomeSujo { get; set; }

        public Cliente(int idCliente, string nome, string endereco, DateTime dataNascimento, string cpf, string email, bool nomeSujo)
        {
            this.IdCliente = idCliente;
            this.Nome = nome;
            this.Endereco = endereco;
            this.DataNascimento = dataNascimento;
            this.Cpf = cpf;
            this.NomeSujo = nomeSujo;
            this.Email = email;
        }
    }
}
