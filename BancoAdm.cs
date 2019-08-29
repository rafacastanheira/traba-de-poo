using System;
using System.Collections.Generic;

namespace Banco
{
    public class BancoAdm
    {
        public List<Conta> ListaConta = new List<Conta>();        

        public BancoAdm()
        {

        }

        public void ListarConta()
        {
            foreach (Conta valor in ListaConta)
                Console.WriteLine("Conta: "+valor.NumeroConta+
                " Saldo:"+valor.saldo()+" Nome: "+valor.Titular.Nome);
            
        }

       

        
        
    }
}