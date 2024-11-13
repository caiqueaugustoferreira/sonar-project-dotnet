using System;
using System.Collections;

namespace CalculadoraRuim
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação desejada: (+, -, *, /, %, média, mediana)");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número (se aplicável):");
            double num2 = double.Parse(Console.ReadLine());

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
                resultado = (double)lista[lista.Count / 2];
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
