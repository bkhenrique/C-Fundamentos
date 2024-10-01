using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do nome
            Console.WriteLine("Digite Seu nome:");
            string nome = Console.ReadLine();

            // Entrada da idade, convertendo string para int
            Console.WriteLine("Digite Sua Idade:");
            int idade = Convert.ToInt32(Console.ReadLine());  // ou int.Parse(Console.ReadLine());

            // Entrada da frase
            Console.WriteLine("Digite uma Frase:");
            string frase = Console.ReadLine();

            // Saída usando interpolação de strings
            Console.WriteLine($"Olá {nome}, você tem {idade} anos. Sua frase é: \"{frase}\"");

            // Pausa para não fechar o terminal imediatamente
            Console.ReadKey();
        }
    }
}