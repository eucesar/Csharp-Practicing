using System;
class Programa
{
    static void Main(string[] args)
    {
        //var
        int numeroLista1, numeroLista2, numeroLista3;
        int soma;
        double media;

        //numero
        Console.Write("Digite um numero: ");
        numeroLista1 = int.Parse(Console.ReadLine());

        Console.Write("Digite um numero: ");
        numeroLista2 = int.Parse(Console.ReadLine());

        Console.Write("Digite um numero: ");
        numeroLista3 = int.Parse(Console.ReadLine());

        //conta
        soma = numeroLista1 + numeroLista2 + numeroLista3;

        media = soma / 3;


        //saida
        Console.WriteLine("A soma será: " + soma);
        Console.WriteLine("A media será: " + media);
        Console.ReadLine();
    }
}
