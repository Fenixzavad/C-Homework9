// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");

int funcAkkerman = A(m, n);
int A(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return A(m - 1, 1);
  else return A(m - 1, A(m, n - 1));
}
Console.Write($"Функция Аккермана = {funcAkkerman} ");
