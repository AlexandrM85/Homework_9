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

// Задача 66: Задайте значения A и B. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от A до B.
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

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("--------------Задача №68.--------------");
Console.WriteLine("Введите значение m ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A(m,n) = {AkkermanFunction(m, n)}");

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return AkkermanFunction (m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}