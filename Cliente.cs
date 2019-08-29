namespace Banco
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {

        }

        public Cliente (string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }
        
    }
}