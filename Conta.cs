using System;

namespace Banco
{
    public class Conta
    {
        private Random Rand = new Random();
        public int NumeroConta { get; set; }
        public Cliente Titular;
        private double Saldo;

        public Conta()
        {
            

        }

        public Conta(string nome, string cpf )
        {
            this.Titular = new Cliente(nome, cpf);
            this.NumeroConta = Rand.Next(1000,9999);
            this.Saldo = 1000;
        }

        public double saldo()
        {
            return this.Saldo;

        }

        public bool sacar(double valor)
        {
            if (valor<=Saldo)
            {
                Saldo -= valor;                
                return true;
            }
            else
                return false;
              

        }

        public bool transferir(double valor)
        {
            if (sacar(valor))
                return true;
            else
                return false;
        }


        
        
    }
}