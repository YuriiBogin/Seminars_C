/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9*/

int FunkAkk(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return FunkAkk(m - 1, 1);
    else
        return FunkAkk(m - 1, FunkAkk(m, n - 1));
}
 
Console.WriteLine("Введите m:");    
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( $"Значение функции Аккермана: {FunkAkk(m,n)}");  