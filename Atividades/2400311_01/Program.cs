// OPERADORES

// Acumulador
int a = 3;
int b = a++; // ++ é um acumulador -> b = a + 1
Console.WriteLine($"a é {a} e b é {b}");
// ++ na direita, significa que o acúmulo vai ocorrer depois da atribuição
int c = 3;
int d = ++c;
Console.WriteLine($"c é {c} e d é {d}");
// ++ na esquerda, significa que o acúmulo vai ocorrer antes da atribuição

// Combinando operador de atribuição com operadores aritméticos
int p = 6;
p += 3; // equivale a p = p + 3
p -= 3; // equivale a p = p - 3
p *= 3; // equivale a p = p * 3
p /= 3; // equivale a p = p / 3


// OPERADORES LÓGICOS
bool b_A = true;
bool b_B = false;
Console.WriteLine($"AND  | b_A   | b_B   ");
Console.WriteLine($"b_A  | {b_A & b_A, -5} | {b_A & b_B, -5}");
Console.WriteLine($"b_B  | {b_B & b_A, -5} | {b_B & b_B, -5}");
Console.WriteLine("");
Console.WriteLine($"OR   | b_A   | b_B   ");
Console.WriteLine($"b_A  | {b_A | b_A, -5} | {b_A | b_B, -5}");
Console.WriteLine($"b_B  | {b_B | b_A, -5} | {b_B | b_B, -5}");
Console.WriteLine("");
Console.WriteLine($"XOR  | b_A   | b_B   ");
Console.WriteLine($"b_A  | {b_A ^ b_A, -5} | {b_A ^ b_B, -5}");
Console.WriteLine($"b_B  | {b_B ^ b_A, -5} | {b_B ^ b_B, -5}");