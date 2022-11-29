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

// нахождение четных чисел от M до N
string FindingEvenNumbers(int m,  int n)
{
    string value = String.Empty;
    for(int i = m; i<=n; i++)
    {
    if (m % 2==0)
    {
    return value;
    }
    else
    {
    m = m+1;
    value = m + FindingEvenNumbers(m, n);
    }
    }
    
    return value;
}

// вызов функции "четных чисел"

string NaturalNumbers( int m,  int n)
{
    if(m<=n) return m + FindingEvenNumbers(m+1 , n);
    else return String.Empty;
    
}
System.Console.WriteLine();
System.Console.WriteLine(NaturalNumbers(  m,   n));
