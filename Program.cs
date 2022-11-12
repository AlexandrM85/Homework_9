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



