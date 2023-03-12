/*
string[,] table = new string[2,5];
// table[0,0] // table[0,1] // table[0,2] 
// table[1,0] // table[1,1] // table[1,2]
table[1,2] = "Слово";
for(int rows = 0;rows<2;rows++)
{
    for(int columns = 0; columns<5;columns++)
    {
        System.Console.WriteLine($"-{table[rows,columns]}-");
    }
}
*/
/*
void PrintArray(int[,] matr)
{
    for(int i =0;i<matr.GetLength(0);i++)
    {
        for(int j = 0;j<matr.GetLength(1);j++)
        {
            System.Console.Write($"{matr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i< matr.GetLength(0);i++)
    {
        for(int j = 0; j< matr.GetLength(1);j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
int [,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);
*/

// Как представить черно-белое изображение
// int[,] public = new int[23,25];
// 0 - закрашенный пиксель
// 1 - незакрашенный пиксель
/*
int [,] pic = new int[,]
{
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
{0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
};
void PrintImage(int[,] image)
{
    for(int i =0;i<image.GetLength(0);i++)
    {
        for(int j = 0;j<image.GetLength(1);j++)
        {
            //System.Console.Write($"{image[i,j]} ");
            if(image[i,j] == 0) Console.Write($"   ");
            else Console.Write($" + ");
        }
        System.Console.WriteLine();
    }
}
void FillImage(int row,int col)
{
    if(pic[row,col]==0)
    {
        pic[row,col] = 1;
        FillImage(row-1,col);
        FillImage(row,col-1);
        FillImage(row+1,col);
        FillImage(row,col+1);
    }
}
PrintImage(pic);
FillImage(9,6);
PrintImage(pic);
*/

// Рекурсия на примере нахождения факториала числа:
/*
double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for(int i = 1;i<40;i++)
{
System.Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

//  Рекурсия на примере расчета последовательности Фибонначи
/*
double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1;i < 50;i++)
{
    System.Console.WriteLine($"{i} = {Fibonacci(i)}");
}
*/
