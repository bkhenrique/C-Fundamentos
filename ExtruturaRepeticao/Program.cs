using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // while = enquanto
        // É uma estrutura de controle que
        // repete um bloco de comandos
        // enquanto uma condição for
        // verdadeira.
        // Quando usar: quando não se
        // sabe previamente a quantidade
        // de repetições que será realizada.



        //  while (condição)
        //  {
        //      comando 1
        //      comando 2
        //  }

        int x, soma;

        x = int.Parse(Console.ReadLine());
        soma = 0;

        while (x != 0 )
        {
            soma = soma + x;
            x = int.Parse(Console.ReadLine());

        }
        Console.WriteLine(soma);
        Console.ReadLine();





        // for = para

        //  É uma estrutura de controle que
        // repete um bloco de comandos
        // para um certo intervalo de
        // valores.
        // Quando usar: quando se sabe
        // previamente a quantidade de
        // repetições, ou o intervalo de
        // valores.


        // for (início; condição; incremento)
        // {
        //     comando 1
        //     comando 2
        // }

        for (int i = 0; i < 5; i++) 
        {
            Console.WriteLine("Valor de i: " + i);
            Console.ReadLine();
        }
    }
}