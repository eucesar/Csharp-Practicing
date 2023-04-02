using System;
using System.ComponentModel.Design;

class Programa
{
    static void Main(string[] args)
    {
        //var
        int numeroLista1, numeroLista2;
        bool iguais;

        //numero
        Console.Write("Digite um numero: ");
        numeroLista1 = int.Parse(Console.ReadLine());

        Console.Write("Digite um numero: ");
        numeroLista2 = int.Parse(Console.ReadLine());

        //contas
        iguais = numeroLista1 == numeroLista2;

        
        //saida
        if (numeroLista1 > numeroLista2)
        {
            Console.WriteLine($"o {numeroLista1} é maior que o {numeroLista2}");
        }
        else
        {
            Console.WriteLine($"o {numeroLista2} é maior que o {numeroLista1}");
        }

        if (iguais) 
        {
            Console.WriteLine("obs.: os numeros da lista são iguais, troque os numeros para executar de uma melhor maneira");
        }
        
        Console.ReadLine();
    }
}