using System;

class Program
{
    static void Main(string[] args)
    {
        //var
        string nome;
        int quantidadeDeLetras;

        //numero
        Console.WriteLine("Digite uma string:");
        nome = Console.ReadLine().ToLower();

        //conta
        quantidadeDeLetras = 0;

        //saida
        foreach (char quantidadeDeLtras in nome)
        {
            if ("aeiou".IndexOf(quantidadeDeLtras) >= 0)
            {
                quantidadeDeLetras++;
            }
        }

        Console.WriteLine($"A string possui {quantidadeDeLetras} vogais.");
    }
}