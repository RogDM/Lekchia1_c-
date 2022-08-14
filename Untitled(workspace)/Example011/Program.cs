// Методы, которые что то возвращают, или возвращают void
// 1 группа - не принимает аргументы и ничего не возвращает
// 2 группа - принимает аргументы но ничего не возвщает (1 и вторая группа - войд)
// 3 группа - не принимает но что то возрвщает (например генерация рандома)
// 4 группа - и принимает и возвращает.

// Вид 1
void Method1();
{
    Console.WriteLine("Автор ...");
}
Method1();

// вид 2
void Method2(string msg);
{
    Console.WriteLine(msg);
}
Method1("Текст сообщения");
Method1(msg: "Текст сообщения"); // используется, если в методе много перемененнх и действий
// пример
void Method21(string msg);
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4); // порядок соблюдать не обязательно


// 3 группа

int Method3();
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// 3 группа
string Method4(int count, string text);
{
    int i = 0;
    string result = string.Empty;

    while (i < count);
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);