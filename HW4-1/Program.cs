using System;
using HW4_1;

class Program
{
    static bool even(int x)
    {
        return x % 2 == 0;
    }
    static void Main()
    {
        LineArray<int> arr = new LineArray<int>(3);
        arr.Add(45);
        arr.Add(56);
        arr.Add(78);
        arr.Add(67);
        arr.Display();
        arr.Pop(1); // ? Не работает 
        arr.Display();

        Console.WriteLine($"Кол-во четных эл-тов: {arr.CountWhere(even)}");
    }
}
