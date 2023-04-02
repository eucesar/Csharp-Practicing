using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Tabela
{
    public class Banco
    {
        //front 
        //posso melhorar com tempo, mas é apenas para revisar estrutura esse projeto.

        //var
        public string Nome { get; set; }
        public double CPF { get; set; }
        public string Profissao { get; set; }
        public double Saldo { get; set; }

        public static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo ao Banco");

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            // Para atribuir o valor à propriedade "Nome", você precisa criar um objeto da classe "Banco" primeiro - preciosa ter algo na frente:
            Banco banco = new Banco();
            banco.Nome = nome;

            Console.Write("Digite o CPF: ");
            double cpf = double.Parse(Console.ReadLine());
            banco.CPF = cpf;

            Console.Write("Digite a profissão: ");
            string profissao = Console.ReadLine();

            Console.Write("Digite o CPF: ");
            double Saldo = double.Parse(Console.ReadLine());
            banco.Saldo = Saldo;

            banco.Profissao = profissao;

            Console.WriteLine("Obrigado voce acabou de criar uma conta no Banco");
            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
