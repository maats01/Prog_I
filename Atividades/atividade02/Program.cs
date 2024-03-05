// Substituindo conteúdo de strings
string nomeCompleto = "Matheus Pelozatto Sampaio";
nomeCompleto = nomeCompleto.Replace("Pelozatto", "Dalua");
Console.WriteLine(nomeCompleto);

// Comparação de strings
bool isNomeEqual = (nomeCompleto == "Matheus Pelozatto Sampaio");

bool isNomeEqual2 = string.Equals(nomeCompleto, "Matheus Dalua Sampaio");

Console.WriteLine($"Primeiro resultado: {isNomeEqual}\nSegundo resultado: {isNomeEqual2} ");

// Tipos numéricos
/*
    sbyte: armazena valores entre -128 e 127
    short: armazena valores entre -32,768 e 32,767
    int: armazena valores entre -2,147,483,648 e 2,147,483,647
    long: armazena valores entre -9,223,372,036,854,775,808 e 9,223,372,036,854,775,807 
*/

float myFloat = 10f;
double myDouble = 5d;
decimal myDecimal = 7m;
int myInteger = 0;