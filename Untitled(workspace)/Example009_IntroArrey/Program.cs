// Ввод функции
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// Ввод данных Массива
int[] array = {15, 11, 22, 33, 44, 11, 2, 5, 6};
// array[0] = 12; // Используем номерр в массиве что бы заменить число

// Вариант с функцией 2
int max = Max(
    Max(array[0], array[1] , array[2]), 
    Max(array[3], array[4] , array[5]), 
    Max(array[6], array[7] , array[8]));

Console.WriteLine(max);