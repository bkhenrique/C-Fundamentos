using System;
using System.Globalization;

namespace FuncoesMatematicas
{
    class Program
    {
        private static void Main(string[] args)
        {

            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            // Cálculo da raiz quadrada
            A = Math.Sqrt(x);  // Raiz quadrada de x (3.0)
            B = Math.Sqrt(y);  // Raiz quadrada de y (4.0)
            C = Math.Sqrt(25.0);  // Raiz quadrada de 25.0
            Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("Raiz quadrada de 25 = " + C);

            // Cálculo da potenciação
            A = Math.Pow(x, y);  // x elevado a y (3.0 ^ 4.0)
            B = Math.Pow(x, 2.0);  // x elevado ao quadrado (3.0 ^ 2.0)
            C = Math.Pow(5.0, 2.0);  // 5.0 elevado ao quadrado (5.0 ^ 2.0)
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            // Cálculo do valor absoluto
            A = Math.Abs(y);  // Valor absoluto de y (|4.0|)
            B = Math.Abs(z);  // Valor absoluto de z (|-5.0|)
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);

            // Operações matemáticas básicas
            A = x + y;  // Soma de x e y (3.0 + 4.0)
            B = x * y;  // Multiplicação de x e y (3.0 * 4.0)
            C = y / x;  // Divisão de y por x (4.0 / 3.0)
            double porcentagem = (x / y) * 100;  // Porcentagem de x em relação a y ((3.0 / 4.0) * 100)

            Console.WriteLine(x + " + " + y + " = " + A);  // Soma
            Console.WriteLine(x + " * " + y + " = " + B);  // Multiplicação
            Console.WriteLine(y + " / " + x + " = " + C);  // Divisão
            Console.WriteLine(x + " é " + porcentagem + "% de " + y);  // Porcentagem

            // Mantém o console aberto para leitura
            Console.ReadLine();
        }
    }
}
