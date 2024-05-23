int[,] createMatrix(int rowCount, int colums)
{
    Random rand = new Random();
    int[,] matrix = new int[rowCount, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(100, 1000);
        }
    }
    return matrix;
}
bool isItIntersting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0) return true;
    else return false;
}
int GetSumOfDigits(int value)
{
    int sumOfDigits = 0;
    while (value > 0)
    {
        sumOfDigits = sumOfDigits + value % 10;
        value /=10;
    }
    return sumOfDigits;
}
void showMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

int[,] matrixTask3 = createMatrix(5, 5);
showMatrix(matrixTask3);
Console.WriteLine("Инетерсные числа: ");
foreach (int e in matrixTask3)
{
    if (isItIntersting(e) == true)
    {
        Console.Write($"{e} ");
    }
}
