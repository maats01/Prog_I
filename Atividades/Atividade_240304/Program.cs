/*
Crie um programa em C# que seja capaz de realizar as 4 operações aritméticas básicas:
a) Leia o primeiro operando;	
b) Leia o operador aritmético;
c) Leia o segundo número;
Identifique qual operação foi solicitada pelo usuário, permitindo trabalhar com números reais 
e inteiros, processe e exiba o resultado.

*/

Console.WriteLine("Calculadora de dois operandos");
Console.WriteLine("Operadores: +, -, *, /");

while (true)
{
    Console.WriteLine("Operando 1");
    float op1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Operador");
    string? sign = Console.ReadLine();
    Console.WriteLine("Operando 2");
    float op2 = float.Parse(Console.ReadLine());

    switch (sign)
    {
        case "+":
        Console.WriteLine($"{op1} + {op2} = {op1+op2}");
        break;

        case "-":
        Console.WriteLine($"{op1} - {op2} = {op1-op2}");
        break;

        case "/":
        Console.WriteLine($"{op1} / {op2} = {op1/op2}");
        break;

        case "*":
        Console.WriteLine($"{op1} * {op2} = {op1*op2}");
        break;
    }
    Console.WriteLine("Mais uma vez?");
    if (!(Console.ReadLine().Equals("s")))
        break;
}