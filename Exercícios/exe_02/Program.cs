/* Escreva um programa que seja capaz de perguntar ao usuário
um operador aritmético específico (+ - * /) e com base na operação
escolhida pelo usuário, imprima na tela a tabuada de 1 a 9 daquela
operação.
*/

using System.Diagnostics;

Console.WriteLine("Digite um operador (+, -, * ou /): ");

string operador = Console.ReadLine();

float result(string op, float a, float b)
{
    switch(op)
    {
        case "+":
            return a + b;
        case "-":
            return a - b;
        case "*":
            return a * b;
        case "/":
            return a / b;
        default:
            Console.WriteLine("bruh");
            return 0;
    }
}

void operation(string op)
{
    for (float i = 1; i < 10; i++)
    {
        for(float j = 1; j < 10; j++)
        {
            if (result(op, j, i) < 10 & result(op, j, i) >= 0)
                Console.Write($"{j} {op} {i} = {result(op, j, i).ToString("N2")}    | ");
            
            else
                Console.Write($"{j} {op} {i} = {result(op, j, i).ToString("N2")}   | ");
        }

        Console.WriteLine("");
    }
}

operation(operador);
