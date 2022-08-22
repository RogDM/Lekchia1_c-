// See https://aka.ms/new-console-template for more information
                    // 
/* string[,] table = new string[2, 5]; */
// table[0, 0]    table[0, 1]     table[0, 2]   table[0, 4]
// table[1, 0]    table[1, 1]     table[1, 2]   table[1, 4]

/* 
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}
 */

// печать матрицы чисел

/* for (int i = 0; i < matrix.GetLength(0); i++)  // коммандой matrix.GetLength(0) выбираем длину первой переменной
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}
 */
// Метод для печати матрицы
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  // коммандой matrix.GetLength(0) выбираем длину первой переменной
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
     }
    Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);

// Метод для заполнения матрицы числами

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  // коммандой matrix.GetLength(0) выбираем длину первой переменной
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
     }
    }
}
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
