Console.WriteLine("Введите номер задачи:");
int choose = int.Parse(Console.ReadLine()!);
switch (choose)
{
    case 65: Q65(); break;
    case 67: Q67(); break;
    case 69: Q69(); break;
    case 64: Q64(); break;
    case 66: Q66(); break;
    case 68: Q68(); break;
}


// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

void Q65()
{
    Console.WriteLine("Введите значение М");
    int start = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение N");
    int end = int.Parse(Console.ReadLine()!);

    Console.WriteLine(PrintNumbers(start, end));

    string PrintNumbers(int start, int end)
    {
        if (start == end) return start.ToString();
        return start + " " + PrintNumbers(start + 1, end);
    }
}
// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9
void Q67()
{
    Console.WriteLine("Введите цифру");
    int number = int.Parse(Console.ReadLine()!);
    Console.WriteLine(SumNumber(number));

    int SumNumber(int number)
    {
        if (number < 10) return number;
        else return number % 10 + SumNumber(number / 10);
    }
}

// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
void Q69()
{
    Console.WriteLine("Введите значение a");
    int a = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение b");
    int b = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Число {a} в целой степени {b} = {RaisingTwoNumbers(a, b)}");

    int RaisingTwoNumbers(int a, int b)
    {
        if (b > 1) return a * RaisingTwoNumbers(a, b - 1);
        else return a;
    }
}

// ------------------------------------------------------------------------------------------

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void Q64()
{
    Console.WriteLine("Введите значение N");
    int n = int.Parse(Console.ReadLine()!);

    Console.WriteLine(PrintNumbersToN(n));

    string PrintNumbersToN(int n)
    {
        if (n > 1) return n + ", " + PrintNumbersToN(n - 1);
        return n.ToString();
    }
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void Q66()
{
    Console.WriteLine("Введите значение М");
    int start = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение N");
    int end = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    Console.WriteLine(SummNumberMN(start, end));

    int SummNumberMN(int start, int end)
    {
        if (end > start) return start + SummNumberMN(start + 1, end);
        else return end;
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
void Q68()
{
    Console.WriteLine("Введите значение М");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение N");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    Console.WriteLine(AckermannFunc(m, n));

    int AckermannFunc(int m, int n)
    {
        if (m > 0)
        {
            if (n > 0) return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
            else return AckermannFunc(m - 1, 1);
        }
        else return n + 1;
    }
}