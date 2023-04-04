using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Tabela
{
    public class Sacar
    {
        public Sacar(double valorQueTemNaConta, double tirar) 
        {
        
            Banco Sacar = new Banco();
            valorQueTemNaConta = Sacar.Saldo;
            tirar = valorQueTemNaConta - 100;
            tirar = Sacar.Saldo;

        }

    }
}
