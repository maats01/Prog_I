/* Escreva um programa que seja capaz de perguntar ao usuário
um operador aritmético específico (+ - * /) e com base na operação
escolhida pelo usuário, imprima na tela a tabuada de 1 a 9 daquela
operação.
*/

using System.Diagnostics;

Console.WriteLine("Digite um operador (+, -, * ou /): ");

string operador = Console.ReadLine();

void Tabuada(string operador)
{
    switch(operador)
    {
        case "*":
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    if (j*i < 10)
                        Console.Write($"{j} x {i} = {i*j}  | ");
                    else
                        Console.Write($"{j} x {i} = {i*j} | ");
                }

                Console.WriteLine("");
            }
            break;
        
        case "+":
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    if (j+i < 10)
                        Console.Write($"{j} + {i} = {i+j}  | ");
                    else
                        Console.Write($"{j} + {i} = {i+j} | ");
                }

                Console.WriteLine("");
            }
            break;

        case "-":
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    if (j-i < 10)
                        Console.Write($"{j} - {i} = {i-j}  | ");
                    else
                        Console.Write($"{j} - {i} = {i-j} | ");
                }

                Console.WriteLine("");
            }
            break;

        case "/":
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    double result = Convert.ToDouble(j)/Convert.ToDouble(i);
                    Console.Write($"{j} / {i} = {result.ToString("N2")} | ");
                }

                Console.WriteLine("");
            }
            break;
    }
}

Tabuada(operador);
