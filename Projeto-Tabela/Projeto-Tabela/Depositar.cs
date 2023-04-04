using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Tabela
{
    public class Depositar
    {
       
        public void Conta(double valor, double valorDEPOSITADO = 100) 
        {
            Banco conta = new Banco();
            // Obter o saldo atual da conta
            double saldoAtual = conta.Saldo;
            // Adicionar o valor digitado ao saldo atual
            double novoSaldo = saldoAtual + valorDEPOSITADO;
            // Atribuir o novo saldo de volta à conta bancária
            saldoAtual = conta.Saldo;

        }
    }
}
