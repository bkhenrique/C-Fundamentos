using System;
using System.Globalization;

namespace ExpressoesComparativasLogicasCondicinal
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Operadores Conparativos
            // > maior
            // < menor
            // >= maior ou igual
            // <= menor ou igual
            // == igual
            // != diferente


            //  int X = 5;
            //  int Y = 10;

            //  X == 5 true
            //  Y == 10 true

            //  X > Y false
            //  X < Y true
            //  X == Y false
            //  X != Y true


            // Operadores Logicos

            // && = E
            // || = ou
            // ! = Não ou negativa

            // Extrutura Condicional

            //  if = se
            // else = se não



            // Switch-case

            //exemplo
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sabado";
                    break;
                default:
                    dia = "Digite de 1 a 7";
                    break;


            }
            Console.WriteLine("Dia da semana =" + dia);
            Console.ReadLine();

        }
    }
}
