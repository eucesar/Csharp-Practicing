using System;
class Programa
{
    static void Main(string[] args)
    {
        //Como deve ficar :

        //*
        //**
        //***
        //****
        //*****

        /*
        1° = variável inicialização
        2° = Condição - tem q ser respeitada para ser inicializada
        3° = Contador(limitador)
        */

        //var
        int contadorLinhas, contadorColunas;


    
        //conta
        /*
       1° = variável inicialização
       2° = Condição - tem q ser respeitada para ser inicializada
       3° = Contador(limitador)
       */
        for (contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                Console.Write("*");

                //Se o numero de colunas for maior ou igual ao numero de linah QUEBRA = coluna 1 linha 1 QUEBRA
                if (contadorColunas >= contadorLinhas)
                    break;

            }
        //saida
        Console.WriteLine();
        }
    }
}
/*
    |\__/,|   (`\
  _.|o o  |_   ) )
-(((---(((-------- 𝒞𝑒𝓈𝒶𝓇 ℐ𝑔𝓁𝑒𝓈𝒾𝒶𝓈  */