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
/*
    |\__/,|   (`\
  _.|o o  |_   ) )
-(((---(((-------- 𝒞𝑒𝓈𝒶𝓇 ℐ𝑔𝓁𝑒𝓈𝒾𝒶𝓈  */