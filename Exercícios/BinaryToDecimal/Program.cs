int BinaryToDecimal(string binaryNum)
{
    Queue<int> queueOfBinaryNum = new Queue<int>();

    foreach (var s in binaryNum)
    {
        queueOfBinaryNum.Enqueue(Convert.ToInt32(s));
    }

    double decimalNum = 0;

    for (int totalElements = queueOfBinaryNum.Count; totalElements > 0; totalElements--)
    {
        int currentNum = queueOfBinaryNum.Dequeue();

        if (currentNum == 49) 
            decimalNum += Math.Pow(2, totalElements-1);
    }

    return Convert.ToInt32(decimalNum); 
}

Console.WriteLine("Número binário: ");

string? binaryNum = Console.ReadLine();
int decimalNum = BinaryToDecimal(binaryNum);

Console.WriteLine($"Número decimal: {decimalNum}");