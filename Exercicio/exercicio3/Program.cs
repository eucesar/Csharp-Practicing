using System;
class Programa
{
    static void Main(string[] args)
    {
        //var
        int numero;
        int divisaoSobra;

        //numero
        Console.Write("Digite um numero de (1-999): ");
        numero = int.Parse(Console.ReadLine());

        //conta
        divisaoSobra = numero % 2;

        //saida
        if (divisaoSobra == 0)
        {
            Console.WriteLine("é par");
        }
        else
        {
            Console.WriteLine("é impar");
        }

        Console.ReadLine();
    }
}
