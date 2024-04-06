Queue<char> queueOfBinaryNum = new Queue<char>();

Console.WriteLine("Digite um número binário: ");
string? binaryNum = Console.ReadLine();

foreach (var s in binaryNum)
{
    queueOfBinaryNum.Enqueue(s);
}

double decimalNum = 0;

for (int totalElements = queueOfBinaryNum.Count; totalElements > 0; totalElements--)
{
    int currentNum = Convert.ToInt32(queueOfBinaryNum.Dequeue().ToString());

    if (currentNum == 1) 
        decimalNum += Math.Pow(2, totalElements-1);
}

Console.WriteLine($"Número decimal: {decimalNum}");
