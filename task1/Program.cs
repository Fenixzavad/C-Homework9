// Задайте значения M и N. Напишите программу, которая выведет
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");
// числа натуральные
if (n < 1 || m < 1)
{
    Console.WriteLine("N и M не натуральные числа");
    return;
}
// когда N < M
if (n < m)
{
    Console.WriteLine("N меньше M");
    return;
}
// нахождение четных чисел от M до N

PrintEvenNumbers(m, n);

void PrintEvenNumbers(int m, int n)
{
    if (m % 2 == 0)
    {
        Console.Write(n - m > 1 ? $"{m}, " : $"{m}");
    }
    if(m == n) return;  
    PrintEvenNumbers(m + 1, n);
}

