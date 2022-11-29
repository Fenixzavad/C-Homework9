// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");

// функция сумма чисел от M до N
int SumNumbers(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumNumbers(m, n);
        return result;
    }
}
// вызов функции "сумма чисел от M до N"
void SumNumbersMtoN(int m, int n)
{
    Console.Write(SumNumbers(m-1 , n));
}
SumNumbersMtoN(m, n);