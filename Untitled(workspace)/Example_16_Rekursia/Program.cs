// Рекурсия (вызов методом самого себя) на примере факториала

// 1 метод (не работает на больших числах)
/* int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6
 */
// 1 метод проверка - показывает ошибку
/* int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
} */

// 3 метод заменяем инт на дабл
double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}


