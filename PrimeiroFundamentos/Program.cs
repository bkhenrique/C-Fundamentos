// See https://aka.ms/new-console-template for more information
// metodo novo Console.WriteLine("Hello, World!");

//usando metodo antigo

using System;
using System.Globalization;

namespace PrimeiroFundamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello word");
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';
            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            // Console.ReadLine(); // Espera o usuário pressionar Enter antes de fechar
            Console.WriteLine("Pressione qualquer tecla para fechar...");
            Console.ReadKey(); // Espera o usuário pressionar qualquer tecla antes de fechar
        }
    }
}


//declaração de variaveis

// int idade = 25; numero inteiro
// double altura = 1.82; numero ponto flutuante ou decimal
// char sexro  = 'H'; caracter

//   byte  de 0 a 255
//   sbyte de -128 a 127
//   short de -32,768 a 32,767
//   ushort de 0 a 65,535
//   uint de 0 a 4 bilhoes e pouco
//   long de -9 quinquilhoes a 9  quinquilhões 
//   ulong de 0 a 18 quinquilhões

// float armazenar numeros decimais
// double precisao maior que float
// decimal controla o numero de casas decimais
// char um caracter
// string palacras ou textos
// bool true ou false
// object armazena um objeto

// nunca pode criar variaveis com numeros no inicio se colocar entao deve usar _ antes

// padrão camel case esse é o padrão