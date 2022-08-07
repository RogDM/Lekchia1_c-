int[] array = { 15, 11, 22, 33, 44, 11, 2, 5 };

int n = array.Length;
int find = 4;

int index =0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}