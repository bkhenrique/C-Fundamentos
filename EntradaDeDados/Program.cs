using System;
using System.Globalization;
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

            // Entrada da idade, convertendo string para int
            Console.WriteLine("Digite Sua Altura:");
            double altura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  // ou int.Parse(Console.ReadLine());

            // Entrada da frase
            Console.WriteLine("Digite uma Frase:");
            string frase = Console.ReadLine();

            // Saída usando interpolação de strings
            Console.WriteLine($"Olá {nome}, você tem {idade} anos.Sua altura:(sem F2) {altura}. Sua altura:(com F2) {(altura.ToString("F2", CultureInfo.InvariantCulture))}.  Sua frase é: \"{frase}\"" );


            // Split , vetor de string separadas por espaço
            Console.WriteLine("Agora vamos fazer Split");
            Console.WriteLine("Digite 3 futras que voce gosta:");
            string frutas = Console.ReadLine();
            
            if (string.IsNullOrEmpty(frutas))
            {
                Console.WriteLine("Digite 3 futras que voce gosta:");
                 frutas = Console.ReadLine();
            }
            
            string[] vet = frutas.Split(' ');
            string f1 = vet[0];
            string f2 = vet[1];
            string f3 = vet[2];
            Console.WriteLine($"Olá {nome}", "As frutas em ordem são:");
            Console.WriteLine("1:" + f1);
            Console.WriteLine("2:" + f2);
            Console.WriteLine("3:" + f3);


            // Pausa para não fechar o terminal imediatamente
            Console.ReadKey();
        }
    }
}