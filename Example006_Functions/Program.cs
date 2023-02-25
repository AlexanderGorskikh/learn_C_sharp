// Задача: найти максимальное число среди 9 чисел. Демoнстрация стихийного подхода.
/*
int a1 = 1;
int a2 = 2;
int a3 = 3;
int b1 = 5;
int b2 = 6;
int b3 = 4;
int c1 = 10;
int c2 = 7;
int c3 = 9;

int max = a1;
if(b1>max) max = b1;
if(c1>max) max = c1;

if(a1>max) max = a2;
if(b2>max) max = b2;
if(c2>max) max = c2;

if(a3>max) max = a3;
if(b3>max) max = b3;
if(c3>max) max = c3;

Console.WriteLine(max);
*/
// Решение задачи выше с помощью функции Max
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result)result = arg2;
    if(arg3>result)result = arg3;
    return result;
}
int a1 = 1;
int a2 = 2;
int a3 = 3;
int b1 = 15;
int b2 = 6;
int b3 = 4;
int c1 = 10;
int c2 = 7;
int c3 = 9;

// Альтернативный вариант записи:

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1,max2,max3);

// Предпочтительный варинат записи:
int max = Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a2,b2,c2));

Console.WriteLine(max);
*/
// Решение задачи с помощью массива
/*
int[] array = {1,2,3,4,5,6,7,8,9};
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result)result = arg2;
    if(arg3>result)result = arg3;
    return result;
}
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(max);
*/
// Задача: Имеется одномерный массив array из n элементов,
// требуется найти элемент массива, равный find.
/*
int[] array = {1,2,3,4,5,4,7,8};
int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find){
        Console.Write(index);
        break;
    }
    index++;
}
*/
// Решение с помощью Функций заполнения массива псевдослучайными числами
/*
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[]coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(coll[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/