using System;
class Programa
{
    static void Main(string[] args)
    {
        //var
        int numero, numero1, numero2;
        int resultadoDaSoma;

        //numero
        Console.Write("Digite um numero: ");
        numero = int.Parse(Console.ReadLine());

        //conta
        numero1 = numero % 10; //unidade - saber uma casa antes de qq valor, divido depois %10
        numero2 = numero / 10; //dezena
        resultadoDaSoma = numero1 + numero2;

        //saida
        Console.WriteLine(numero1);
        Console.WriteLine(numero2);

        Console.WriteLine("A soma será: " + resultadoDaSoma );
        Console.ReadLine();
    }
}