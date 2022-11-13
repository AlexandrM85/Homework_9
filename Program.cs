// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.WriteLine("--------------Задача №64.--------------");
Console.WriteLine("Введите значение N ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumber(N, 1));    

string PrintNumber(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + PrintNumber(start - 1, end));
}

// Задача 66: Задайте значения A и B. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("--------------Задача №66.--------------");
Console.WriteLine("Введите значение A ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение B ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumElement(A, B));

int SumElement(int x, int y)
{
    if (x == y) return y;
    return x + SumElement(x + 1, y);
}

