﻿using System.Collections;

namespace CalculadoraRuim
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação desejada: (+, -, *, /, %, média, mediana)");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número:");
            double.TryParse(Console.ReadLine(), out double num1);

            Console.WriteLine("Digite o segundo número (se aplicável):");
            double.TryParse(Console.ReadLine(), out double num2);

            if (num1 == null || num2 == null)
            {
                Console.WriteLine("Os valores informados são inválidos");
                return;
            }

            double resultado = 0;

            if (operacao == "+")
            {
                resultado = num1 + num2;
            }
            else if (operacao == "-")
            {
                resultado = num1 - num2;
            }
            else if (operacao == "*")
            {
                resultado = num1 * num2;
            }
            else if (operacao == "/")
            {
                resultado = num1 / num2;
            }
            else if (operacao == "%")
            {
                resultado = num1 * (num2 / 100);
            }
            else if (operacao == "média")
            {
                resultado = (num1 + num2) / 2;
            }
            else if (operacao == "mediana")
            {
                ArrayList lista = new ArrayList { num1, num2 };
                lista.Sort();

                resultado = (double?)lista[lista.Count / 2] ?? 0;
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
