//Вид 1 (Функция которая ничего не принимает и ничего не возвращает)
/*
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); //Вызов метода
*/

// Вид 2 (Метод который что-то принимает, но ничего не возвращает)
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
*/
/* // Метод который выводит сообщение int раз
void Method21(string msg, int count)
{
    int i =0;
    while(i<count)
    {
        Console.WriteLine(msg);  
        i++;
    }
}
Method21(msg:"Текст",count: 4);
*/

// Вид 3 (Метод, который ничего не принимает, а только возвращает)
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/

// Вид 4 (Метод, который принимает какие-то данные и возвращает какие-то данные)

/*
string Method4 (int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10,"text ");
Console.WriteLine(res);
*/

// Пример применения цикла for (вывод таблицы умножения)
/*
for(int i=2;i<=10;i++)
{
    for(int j=2;j<=10;j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

// Задача: Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            0123
// s[3] // r

string Replace(string text, char oldValue,char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i<length;i++)
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text,' ','|');
Console.WriteLine(newText);
*/

// Задача: реализация алгоритма сортировки выбором
/*
int[] arr = {1,3,6,3,5,7,8,4,1};

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i =0;i<count;i++)
    {
    Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i=0;i<array.Length - 1;i++)
    {
        int minPosition = i;
        for(int j = i+1; j<array.Length;j++)
        {
            if (array[j]<array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/
