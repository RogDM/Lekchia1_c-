// Ввод функции
int Max(int arg1, int arg2, int arg3,)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
}

// Ввод данных
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 333;
int c2 = 55;
int a3 = 151;
int b3 = 44;
int c3 = 5;

int max = a1;
// Вариант без ввода функции
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;
// Console.WriteLine(max);

// Вариант с функцией


Console.WriteLine(max);