Random rand = new Random();
int [,] createMatrix (int rowCount, int colums)
{
int[,] matrix = new int[rowCount, colums];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rand.Next(1, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
return matrix;
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
int [,] matrixTask1 = createMatrix(5,5);
showMatrix(matrixTask1);